#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
#endregion

namespace MahlerNo2.Recorder.Components
{
    public class TtsHelper
    {
        internal const string ApiKey = "07e3d08318bd403dbd9fce92369ba249";
        internal const string VoiceName = "Microsoft Server Speech Text to Speech Voice (ko-KR, HeamiRUS)";
        internal const string Lang = "ko-KR";

        private static void PlayAudio(object sender, GenericEventArgs<Stream> args)
        {
            var player = new SoundPlayer(args.EventData);
            player.PlaySync();
            args.EventData.Dispose();
        }

        private static void ErrorHandler(object sender, GenericEventArgs<Exception> e)
        {
        }

        public static void Speak(string text)
        {
            SpeakAsync(text).Wait();
        }

        public static Task SpeakAsync(string text)
        {
            var auth = new Authentication("https://eastasia.api.cognitive.microsoft.com/sts/v1.0/issueToken", ApiKey);

            var accessToken = auth.GetAccessToken();

            var requestUri = "https://eastasia.tts.speech.microsoft.com/cognitiveservices/v1";
            var cortana = new Synthesize();

            cortana.OnAudioAvailable += PlayAudio;
            cortana.OnError += ErrorHandler;

            return cortana.Speak(CancellationToken.None, new Synthesize.InputOptions
                                                  {
                                                      RequestUri = new Uri(requestUri),
                                                      Text = text,
                                                      VoiceType = Gender.Female,
                                                      Locale = Lang,
                                                      VoiceName = VoiceName,

                                                      OutputFormat = AudioOutputFormat.Riff24Khz16BitMonoPcm,
                                                      AuthorizationToken = "Bearer " + accessToken
                                                  });
        }
    }

    #region TTSClient
    public class Authentication
    {
        private readonly string AccessUri;
        private readonly string apiKey;
        private string accessToken;
        private readonly Timer accessTokenRenewer;

        //Access token expires every 10 minutes. Renew it every 9 minutes only.
        private const int RefreshTokenDuration = 9;

        public Authentication(string issueTokenUri, string apiKey)
        {
            AccessUri = issueTokenUri;
            this.apiKey = apiKey;

            accessToken = HttpPost(issueTokenUri, this.apiKey);

            // renew the token every specfied minutes
            accessTokenRenewer = new Timer(OnTokenExpiredCallback,
                this,
                TimeSpan.FromMinutes(RefreshTokenDuration),
                TimeSpan.FromMilliseconds(-1));
        }

        public string GetAccessToken()
        {
            return accessToken;
        }

        private void RenewAccessToken()
        {
            var newAccessToken = HttpPost(AccessUri, apiKey);
            //swap the new token with old one
            //Note: the swap is thread unsafe
            accessToken = newAccessToken;
            Console.WriteLine("Renewed token for user: {0} is: {1}", apiKey, accessToken);
        }

        private void OnTokenExpiredCallback(object stateInfo)
        {
            try
            {
                RenewAccessToken();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed renewing access token. Details: {0}", ex.Message);
            }
            finally
            {
                try
                {
                    accessTokenRenewer.Change(TimeSpan.FromMinutes(RefreshTokenDuration), TimeSpan.FromMilliseconds(-1));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to reschedule the timer to renew access token. Details: {0}", ex.Message);
                }
            }
        }

        private string HttpPost(string accessUri, string apiKey)
        {
            // Prepare OAuth request
            var webRequest = WebRequest.Create(accessUri);
            webRequest.Method = "POST";
            webRequest.ContentLength = 0;
            webRequest.Headers["Ocp-Apim-Subscription-Key"] = apiKey;

            using (var webResponse = webRequest.GetResponse())
            {
                using (var stream = webResponse.GetResponseStream())
                {
                    using (var ms = new MemoryStream())
                    {
                        byte[] waveBytes = null;
                        var count = 0;
                        do
                        {
                            var buf = new byte[1024];
                            count = stream.Read(buf, 0, 1024);
                            ms.Write(buf, 0, count);
                        } while (stream.CanRead && count > 0);

                        waveBytes = ms.ToArray();

                        return Encoding.UTF8.GetString(waveBytes);
                    }
                }
            }
        }
    }

    public class GenericEventArgs<T> : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GenericEventArgs{T}" /> class.
        /// </summary>
        /// <param name="eventData">The event data.</param>
        public GenericEventArgs(T eventData)
        {
            EventData = eventData;
        }

        /// <summary>
        ///     Gets the event data.
        /// </summary>
        public T EventData { get; }
    }

    public enum Gender
    {
        Female,
        Male
    }

    public enum AudioOutputFormat
    {
        /// <summary>
        ///     raw-8khz-8bit-mono-mulaw request output audio format type.
        /// </summary>
        Raw8Khz8BitMonoMULaw,

        /// <summary>
        ///     raw-16khz-16bit-mono-pcm request output audio format type.
        /// </summary>
        Raw16Khz16BitMonoPcm,

        /// <summary>
        ///     riff-8khz-8bit-mono-mulaw request output audio format type.
        /// </summary>
        Riff8Khz8BitMonoMULaw,

        /// <summary>
        ///     riff-16khz-16bit-mono-pcm request output audio format type.
        /// </summary>
        Riff16Khz16BitMonoPcm,

        // <summary>
        /// ssml-16khz-16bit-mono-silk request output audio format type.
        /// It is a SSML with audio segment, with audio compressed by SILK codec
        /// </summary>
        Ssml16Khz16BitMonoSilk,

        /// <summary>
        ///     raw-16khz-16bit-mono-truesilk request output audio format type.
        ///     Audio compressed by SILK codec
        /// </summary>
        Raw16Khz16BitMonoTrueSilk,

        /// <summary>
        ///     ssml-16khz-16bit-mono-tts request output audio format type.
        ///     It is a SSML with audio segment, and it needs tts engine to play out
        /// </summary>
        Ssml16Khz16BitMonoTts,

        /// <summary>
        ///     audio-16khz-128kbitrate-mono-mp3 request output audio format type.
        /// </summary>
        Audio16Khz128KBitRateMonoMp3,

        /// <summary>
        ///     audio-16khz-64kbitrate-mono-mp3 request output audio format type.
        /// </summary>
        Audio16Khz64KBitRateMonoMp3,

        /// <summary>
        ///     audio-16khz-32kbitrate-mono-mp3 request output audio format type.
        /// </summary>
        Audio16Khz32KBitRateMonoMp3,

        /// <summary>
        ///     audio-16khz-16kbps-mono-siren request output audio format type.
        /// </summary>
        Audio16Khz16KbpsMonoSiren,

        /// <summary>
        ///     riff-16khz-16kbps-mono-siren request output audio format type.
        /// </summary>
        Riff16Khz16KbpsMonoSiren,

        /// <summary>
        ///     raw-24khz-16bit-mono-truesilk request output audio format type.
        /// </summary>
        Raw24Khz16BitMonoTrueSilk,

        /// <summary>
        ///     raw-24khz-16bit-mono-pcm request output audio format type.
        /// </summary>
        Raw24Khz16BitMonoPcm,

        /// <summary>
        ///     riff-24khz-16bit-mono-pcm request output audio format type.
        /// </summary>
        Riff24Khz16BitMonoPcm,

        /// <summary>
        ///     audio-24khz-48kbitrate-mono-mp3 request output audio format type.
        /// </summary>
        Audio24Khz48KBitRateMonoMp3,

        /// <summary>
        ///     audio-24khz-96kbitrate-mono-mp3 request output audio format type.
        /// </summary>
        Audio24Khz96KBitRateMonoMp3,

        /// <summary>
        ///     audio-24khz-160kbitrate-mono-mp3 request output audio format type.
        /// </summary>
        Audio24Khz160KBitRateMonoMp3
    }

    public class Synthesize
    {
        private string GenerateSsml(string locale, string gender, string name, string text)
        {
            var ssmlDoc = new XDocument(
                new XElement("speak",
                    new XAttribute("version", "1.0"),
                    new XAttribute(XNamespace.Xml + "lang", TtsHelper.Lang),
                    new XElement("voice",
                        new XAttribute(XNamespace.Xml + "lang", locale),
                        new XAttribute(XNamespace.Xml + "gender", gender),
                        new XAttribute("name", name),
                        text)));
            return ssmlDoc.ToString();
        }

        private readonly HttpClient client;
        private readonly HttpClientHandler handler;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Synthesize" /> class.
        /// </summary>
        public Synthesize()
        {
            var cookieContainer = new CookieContainer();
            handler = new HttpClientHandler {CookieContainer = new CookieContainer(), UseProxy = false};
            client = new HttpClient(handler);
        }

        ~Synthesize()
        {
            client.Dispose();
            handler.Dispose();
        }

        /// <summary>
        ///     Called when a TTS request has been completed and audio is available.
        /// </summary>
        public event EventHandler<GenericEventArgs<Stream>> OnAudioAvailable;

        /// <summary>
        ///     Called when an error has occured. e.g this could be an HTTP error.
        /// </summary>
        public event EventHandler<GenericEventArgs<Exception>> OnError;

        /// <summary>
        ///     Sends the specified text to be spoken to the TTS service and saves the response audio to a file.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task</returns>
        public Task Speak(CancellationToken cancellationToken, InputOptions inputOptions)
        {
            client.DefaultRequestHeaders.Clear();
            foreach (var header in inputOptions.Headers) client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);

            var genderValue = "";
            switch (inputOptions.VoiceType)
            {
                case Gender.Male:
                    genderValue = "Male";
                    break;

                case Gender.Female:
                default:
                    genderValue = "Female";
                    break;
            }

            var request = new HttpRequestMessage(HttpMethod.Post, inputOptions.RequestUri)
                          {
                              Content = new StringContent(GenerateSsml(inputOptions.Locale, genderValue, inputOptions.VoiceName, inputOptions.Text))
                          };

            var httpTask = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            var saveTask = httpTask.ContinueWith(
                async (responseMessage, token) =>
                {
                    try
                    {
                        if (responseMessage.IsCompleted && responseMessage.Result != null && responseMessage.Result.IsSuccessStatusCode)
                        {
                            var httpStream = await responseMessage.Result.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            AudioAvailable(new GenericEventArgs<Stream>(httpStream));
                        }
                        else
                        {
                            Console.WriteLine(responseMessage.Result);
                            Error(new GenericEventArgs<Exception>(new Exception($"Service returned {responseMessage.Result}")));
                        }
                    }
                    catch (Exception e)
                    {
                        Error(new GenericEventArgs<Exception>(e.GetBaseException()));
                    }
                    finally
                    {
                        responseMessage.Dispose();
                        request.Dispose();
                    }
                },
                TaskContinuationOptions.AttachedToParent,
                cancellationToken);

            return saveTask;
        }

        /// <summary>
        ///     Called when a TTS requst has been successfully completed and audio is available.
        /// </summary>
        private void AudioAvailable(GenericEventArgs<Stream> e)
        {
            var handler = OnAudioAvailable;
            if (handler != null) handler(this, e);
        }

        /// <summary>
        ///     Error handler function
        /// </summary>
        /// <param name="e">The exception</param>
        private void Error(GenericEventArgs<Exception> e)
        {
            var handler = OnError;
            if (handler != null) handler(this, e);
        }

        public class InputOptions
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="Input" /> class.
            /// </summary>
            public InputOptions()
            {
//                this.Locale = TtsHelper.Lang;
//                this.VoiceName = "Microsoft Server Speech Text to Speech Voice (en-US, ZiraRUS)";
                VoiceName = VoiceName;
                // Default to Riff16Khz16BitMonoPcm output format.
                OutputFormat = AudioOutputFormat.Riff16Khz16BitMonoPcm;
            }

            /// <summary>
            ///     Gets or sets the request URI.
            /// </summary>
            public Uri RequestUri { get; set; }

            /// <summary>
            ///     Gets or sets the audio output format.
            /// </summary>
            public AudioOutputFormat OutputFormat { get; set; }

            public IEnumerable<KeyValuePair<string, string>> Headers
            {
                get
                {
                    var toReturn = new List<KeyValuePair<string, string>>();
                    toReturn.Add(new KeyValuePair<string, string>("Content-Type", "application/ssml+xml"));

                    string outputFormat;

                    switch (OutputFormat)
                    {
                        case AudioOutputFormat.Raw16Khz16BitMonoPcm:
                            outputFormat = "raw-16khz-16bit-mono-pcm";
                            break;

                        case AudioOutputFormat.Raw8Khz8BitMonoMULaw:
                            outputFormat = "raw-8khz-8bit-mono-mulaw";
                            break;

                        case AudioOutputFormat.Riff16Khz16BitMonoPcm:
                            outputFormat = "riff-16khz-16bit-mono-pcm";
                            break;

                        case AudioOutputFormat.Riff8Khz8BitMonoMULaw:
                            outputFormat = "riff-8khz-8bit-mono-mulaw";
                            break;

                        case AudioOutputFormat.Ssml16Khz16BitMonoSilk:
                            outputFormat = "ssml-16khz-16bit-mono-silk";
                            break;

                        case AudioOutputFormat.Raw16Khz16BitMonoTrueSilk:
                            outputFormat = "raw-16khz-16bit-mono-truesilk";
                            break;

                        case AudioOutputFormat.Ssml16Khz16BitMonoTts:
                            outputFormat = "ssml-16khz-16bit-mono-tts";
                            break;

                        case AudioOutputFormat.Audio16Khz128KBitRateMonoMp3:
                            outputFormat = "audio-16khz-128kbitrate-mono-mp3";
                            break;

                        case AudioOutputFormat.Audio16Khz64KBitRateMonoMp3:
                            outputFormat = "audio-16khz-64kbitrate-mono-mp3";
                            break;

                        case AudioOutputFormat.Audio16Khz32KBitRateMonoMp3:
                            outputFormat = "audio-16khz-32kbitrate-mono-mp3";
                            break;

                        case AudioOutputFormat.Audio16Khz16KbpsMonoSiren:
                            outputFormat = "audio-16khz-16kbps-mono-siren";
                            break;

                        case AudioOutputFormat.Riff16Khz16KbpsMonoSiren:
                            outputFormat = "riff-16khz-16kbps-mono-siren";
                            break;
                        case AudioOutputFormat.Raw24Khz16BitMonoPcm:
                            outputFormat = "raw-24khz-16bit-mono-pcm";
                            break;
                        case AudioOutputFormat.Riff24Khz16BitMonoPcm:
                            outputFormat = "riff-24khz-16bit-mono-pcm";
                            break;
                        case AudioOutputFormat.Audio24Khz48KBitRateMonoMp3:
                            outputFormat = "audio-24khz-48kbitrate-mono-mp3";
                            break;
                        case AudioOutputFormat.Audio24Khz96KBitRateMonoMp3:
                            outputFormat = "audio-24khz-96kbitrate-mono-mp3";
                            break;
                        case AudioOutputFormat.Audio24Khz160KBitRateMonoMp3:
                            outputFormat = "audio-24khz-160kbitrate-mono-mp3";
                            break;
                        default:
                            outputFormat = "riff-16khz-16bit-mono-pcm";
                            break;
                    }

                    toReturn.Add(new KeyValuePair<string, string>("X-Microsoft-OutputFormat", outputFormat));
                    // authorization Header
                    toReturn.Add(new KeyValuePair<string, string>("Authorization", AuthorizationToken));
                    // Refer to the doc
                    toReturn.Add(new KeyValuePair<string, string>("X-Search-AppId", "07D3234E49CE426DAA29772419F436CA"));
                    // Refer to the doc
                    toReturn.Add(new KeyValuePair<string, string>("X-Search-ClientID", "1ECFAE91408841A480F00935DC390960"));
                    // The software originating the request
                    toReturn.Add(new KeyValuePair<string, string>("User-Agent", "TTSClient"));

                    return toReturn;
                }
                set => Headers = value;
            }

            /// <summary>
            ///     Gets or sets the locale.
            /// </summary>
            public string Locale { get; set; }

            /// <summary>
            ///     Gets or sets the type of the voice; male/female.
            /// </summary>
            public Gender VoiceType { get; set; }

            /// <summary>
            ///     Gets or sets the name of the voice.
            /// </summary>
            public string VoiceName { get; set; }

            /// <summary>
            ///     Authorization Token.
            /// </summary>
            public string AuthorizationToken { get; set; }

            /// <summary>
            ///     Gets or sets the text.
            /// </summary>
            public string Text { get; set; }
        }
    }
    #endregion
}
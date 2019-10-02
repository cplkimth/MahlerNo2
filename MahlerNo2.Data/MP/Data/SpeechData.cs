namespace MahlerNo2.Data
{
    public partial class SpeechData
    {
        public string PickFirstText()
        {
            var speech = GetFirst();

            if (speech == null)
                return null;

            var text = speech.Text;
            DeleteByPK(speech.SpeechId);

            return text;
        }
    }
}
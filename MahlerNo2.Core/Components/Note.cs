using Newtonsoft.Json;

namespace MahlerNo2.Core.Components
{
    [JsonObject(MemberSerialization.OptOut)]
    public class Note
    {
        public NoteType NoteType { get; }

        public string Text { get; }

        public Note(NoteType noteType, string text)
        {
            NoteType = noteType;
            Text = text;
        }
    }
}
namespace Anglo_Lotha_Vocabulary_App.Models
{
    public class Translation
    {
        private string translate;
        private string translated;

        public string Translate { get { return translate; } set { translate = value; } }
        public string Translated { get { return translated; } set { translated = value; } }

        public Translation(string from, string to)
        {
            translate = from;
            translated = to;
        }
    }
}

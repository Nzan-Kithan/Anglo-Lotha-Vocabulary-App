namespace GLOBALS
{

    public enum LANG { ENGLISH, LOTHA };

    public static class GlobalConstants
    {
        public static readonly List<string> Languages = new List<string> { "English", "Lotha" }; // Array of Languages incase of additional languages that may be added
    }

}

namespace Anglo_Lotha_Vocabulary_App.Models
{

    public class Word
    {
        public string Spelling { get; set; }
        public string Index { get; set; }
        public bool IsFavorite { get; set; }

        public Word(string spelling, string index, bool isFavorite)
        {
            Spelling = spelling;
            Index = index;
            IsFavorite = isFavorite;
        }
    }

    class WWord
    {
        public string Spelling { get; set; }
        public List<int> Index { get; set; }
        public List<int> Synonym { get; set; }
        public List<int> Antonym { get; set; }
        public bool isBookmarked { get; set; }
    }

    class TTranslation
    {
        public string From { get; set; }
        public string To { get; set; }

        public List<GLOBALS.LANG> GetLANGs()
        {
            return new List<GLOBALS.LANG> { 
                (GLOBALS.LANG)Enum.Parse(typeof(GLOBALS.LANG), GLOBALS.GlobalConstants.Languages.IndexOf(From).ToString()),
                (GLOBALS.LANG)Enum.Parse(typeof(GLOBALS.LANG), GLOBALS.GlobalConstants.Languages.IndexOf(To).ToString())
            };
        }
    }

    class Result
    {
        public List<Word> Translated { get; set; }
        public List<Word> Synonym { get; set; }
        public List<Word> Antonym { get; set; }
    }
}

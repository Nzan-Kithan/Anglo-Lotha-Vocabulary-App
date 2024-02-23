namespace Anglo_Lotha_Vocabulary_App.ViewModels
{
    public partial class MainPageViewModel : SearchBarFunctions
    {
        [ObservableProperty]
        string translate, translated;
        public MainPageViewModel()
        {
            Title = "Home";
            SearchQuery = "";
            Translation = new Translation(GLOBALS.GlobalConstants.Languages[0], GLOBALS.GlobalConstants.Languages[1]);

            Translate = Translation.Translate;
            Translated = Translation.Translated;
        }

        // Command to swapped the translation languages
        [RelayCommand]
        void SwapLanguage()
        {

            Translate = Translation.Translate = (PrevLang == GLOBALS.LANG.ENGLISH) ? GLOBALS.GlobalConstants.Languages[1] : GLOBALS.GlobalConstants.Languages[0];
            Translated = Translation.Translated = (PrevLang == GLOBALS.LANG.ENGLISH) ? GLOBALS.GlobalConstants.Languages[0] : GLOBALS.GlobalConstants.Languages[1];

            PrevLang = (PrevLang == GLOBALS.LANG.ENGLISH) ? GLOBALS.LANG.LOTHA : GLOBALS.LANG.ENGLISH;

        }
    }
}

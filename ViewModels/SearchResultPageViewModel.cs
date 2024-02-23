namespace Anglo_Lotha_Vocabulary_App.ViewModels
{
    [QueryProperty("TranslatedFrom", "SearchQuery")]
    [QueryProperty("TranslatedTo", "SearchResult")]
    [QueryProperty("Translation", "Translation")]
    public partial class SearchResultPageViewModel : SearchBarFunctions
    {
        [ObservableProperty]
        string bookmarkIconURL;

        [ObservableProperty]
        string translatedFrom, translatedTo;
        

        public SearchResultPageViewModel()
        {
            BookmarkIconURL = "bookmark_inactive.png";
        }

        [RelayCommand]
        void AddToBookmark()
        {
            
        }

    }
}

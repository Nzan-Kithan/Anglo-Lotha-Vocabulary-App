using Anglo_Lotha_Vocabulary_App.Views;

namespace Anglo_Lotha_Vocabulary_App.ViewModels
{
    public partial class SearchBarFunctions : BaseViewModel
    {
        protected List<Word> EnglishWords { get; set; } = new List<Word>
            {
                new Word("car", "1", false),
                new Word("house", "6", false),
                new Word("cat", "2", false),
                new Word("book", "5", false),
                new Word("tree", "0", false),
                new Word("dog", "4", false),
                new Word("sun", "9", false),
                new Word("compute", "3", false),
                new Word("moon", "7", false),
                new Word("flower", "8", false)
            };

        protected List<Word> LothaWords { get; set; } = new List<Word>
            {
                new Word("otong", "4", false),
                new Word("zotoro", "0", false),
                new Word("onyuro", "2", false),
                new Word("zia", "7", false),
                new Word("furro", "5", false),
                new Word("kako", "3", false),
                new Word("oki", "1", false),
                new Word("choro", "8", false),
                new Word("thera", "9", false),
                new Word("eng", "6", false)
            };

        protected GLOBALS.LANG PrevLang = GLOBALS.LANG.ENGLISH;
        protected GLOBALS.LANG FROM = GLOBALS.LANG.ENGLISH;

        [ObservableProperty]
        private Translation translation; // Stores the currrent translation 

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsClearButtonVisible))]
        private string searchQuery;

        [ObservableProperty]
        private string searchResult;

        [ObservableProperty]
        int currentWordIndex;

        public bool IsClearButtonVisible => !string.IsNullOrEmpty(SearchQuery);
        public SearchBarFunctions() 
        {
            
        }


        // Clearing the Search Query
        [RelayCommand]
        void ClearText()
        {
            SearchQuery = string.Empty;
        }

        [RelayCommand]
        async Task PerformSearch()
        {
            Search();
            await Shell.Current.GoToAsync($"{nameof(SearchResultPage)}", true, 
                new Dictionary<string, object>
                {
                    { "SearchQuery", SearchQuery },
                    { "SearchResult", SearchResult },
                    { "Translation", Translation }
                });
        }

        private void Search()
        {
            FROM = (GLOBALS.LANG)Enum.Parse(typeof(GLOBALS.LANG), GLOBALS.GlobalConstants.Languages.IndexOf(Translation.Translate).ToString());

            // Search in the English words list

            if (FROM == GLOBALS.LANG.ENGLISH)
            {
                foreach (var word in EnglishWords)
                {
                    if (word.Spelling.ToLower() == SearchQuery.ToLower())
                    {
                        CurrentWordIndex = EnglishWords.IndexOf(word);
                        SearchResult = LothaWords[int.Parse(word.Index)].Spelling;
                        return;
                    }
                }
            }
            
            // Search in the French words list
            else
            {
                foreach (var word in LothaWords)
                {
                    if (word.Spelling.ToLower() == SearchQuery.ToLower())
                    {
                        CurrentWordIndex = LothaWords.IndexOf(word);
                        SearchResult = EnglishWords[int.Parse(word.Index)].Spelling;
                        return;
                    }
                }
            }

            SearchResult = "Word not Found";
        }
    }
}
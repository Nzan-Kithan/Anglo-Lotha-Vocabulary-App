namespace Anglo_Lotha_Vocabulary_App.Views;

public partial class SearchResultPage : ContentPage
{
    public SearchResultPage(SearchResultPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
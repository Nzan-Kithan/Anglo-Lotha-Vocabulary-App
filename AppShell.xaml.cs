using Anglo_Lotha_Vocabulary_App.Views;

namespace Anglo_Lotha_Vocabulary_App
{
    public partial class AppShell : Shell
    {
        private bool IsBookmarked = false;
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SearchResultPage), typeof(SearchResultPage));
        }

        private async void CloseFlyoutButton_Clicked(object sender, EventArgs e)
        {
            // Close the flyout menu asynchronously
            await Task.Run(() => Shell.Current.FlyoutIsPresented = false);
        }

    }
}

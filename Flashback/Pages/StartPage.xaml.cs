using Flashback.ViewModels;
using Helpers.Navigation;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Flashback.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        public StartPageViewModel StartPageViewModel = new StartPageViewModel();

        public StartPage()
        {
            this.InitializeComponent();
            this.Loaded += StartPage_Loaded;
        }

        private void StartPage_Loaded(object sender, RoutedEventArgs e)
        {
            HelpPage.FirstHelp();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Update titlebar backbutton visibility
            NavigationService.UpdateAppViewBackButtonVisibility();

            //await StartPageViewModel.LoadSavedProject();
            base.OnNavigatedTo(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

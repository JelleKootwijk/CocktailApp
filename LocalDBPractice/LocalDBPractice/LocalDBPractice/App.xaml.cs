using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LocalDBPractice
{
    public partial class App : Application
    {
        public NavigationPage NavigationPage { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new CocktailHomePage());
            NavigationPage.BarBackgroundColor = Color.FromHex("#464646");
            NavigationPage.BarTextColor = Color.FromHex("#464646");


            var rootPage = new RootPage();
            rootPage.Master = menuPage;
            rootPage.Detail = NavigationPage;
            MainPage = rootPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

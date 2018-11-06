using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDBPractice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu";
                

            InitializeComponent();
            // Add your UI code for the menu here or in your XAML file
            DetailImage.Source = ImageSource.FromResource("LocalDBPractice.Images.detail.png");
        }

        async void Add_Cocktail(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }
    }
}
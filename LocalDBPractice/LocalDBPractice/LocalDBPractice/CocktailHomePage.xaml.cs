using Android.Graphics;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDBPractice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CocktailHomePage : ContentPage
	{
		public CocktailHomePage ()
		{
			InitializeComponent ();

            string dbPath = System.IO.Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "CocktailApp.db3");

            var db = new SQLiteConnection(dbPath);

            ShowCocktails(db);
        }

        private void ShowCocktails(SQLiteConnection db)
        {
            var cocktails = db.Table<CockTail>();
            foreach (var cockTail in cocktails)
            {
                StackLayout cocktailStack = new StackLayout();

                Grid infoStack = new Grid();

                Label CocktailName = new Label();
                CocktailName.Text = cockTail.name;
                CocktailName.FontSize = 25;

                Label CocktailTags = new Label();
                CocktailTags.Text = cockTail.tags;
                CocktailTags.FontSize = 20;
                CocktailTags.FontFamily = "GravityBook";

                var cocktailImage = new Image { Source = ImageSource.FromResource("LocalDBPractice.CocktailImages." + cockTail.imagePath) };
                cocktailImage.WidthRequest = 60;
                //cocktailImage.MinimumWidthRequest = 50;

                TapGestureRecognizer tap = new TapGestureRecognizer();
                tap.Tapped += (sender, e) =>
                {
                    OpenPage(cockTail.name, cockTail.desc, cockTail.tags);
                };

                infoStack.Children.Add(cocktailImage);
                infoStack.Children.Add(CocktailName);
                infoStack.Children.Add(CocktailTags);

                infoStack.Padding = new Thickness(50, 0, 0, 0);


                cocktailStack.Children.Add(infoStack);

                var image = new Image { Source = ImageSource.FromResource("LocalDBPractice.Images.line.png") };

                cocktailStack.Children.Add(image);

                cocktailStack.GestureRecognizers.Add(tap);


                HomePageScrollView.Padding = new Thickness(0, 15, 0, 0);
                HomePageScrollView.Children.Add(cocktailStack);
            }
        }

        async Task OpenPage(string name, string desc, string tags)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CocktailPage(name, desc, tags)));
        }
    }
}
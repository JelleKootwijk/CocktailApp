using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalDBPractice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "CocktailAppRelease.db3");

            var db = new SQLiteConnection(dbPath);

            FillDatabase(db);
        }

        private void FillDatabase(SQLiteConnection db)
        {
            string name = CocktailName.Text;
            string desc = CocktailDesc.Text;
            string tags = CocktailTags.Text;
            string path = CocktailPath.Text;

            db.CreateTable<CockTail>();

            var newStock = new CockTail();
            newStock.name = name;
            newStock.desc = desc;
            newStock.tags = tags;
            newStock.imagePath = path;

            db.Insert(newStock);
        }

        async void btnCourseList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Content()));
        }
    }
}

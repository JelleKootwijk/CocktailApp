using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace LocalDBPractice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Content : ContentPage
	{
		public Content ()
		{
			InitializeComponent ();

            string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "CocktailAppRelease.db3");

            var db = new SQLiteConnection(dbPath);

            ShowDatabase(db);
        }

        private void ShowDatabase(SQLiteConnection db)
        {
            var table = db.Table<CockTail>();
            foreach (var s in table)
            {
                Label ding = new Label();
                ding.Text = s.name;
                dick.Children.Add(ding);


                Label dingnogiets = new Label();
                dingnogiets.Text = s.desc;

                double asdasd = Application.Current.MainPage.Width;
                homom.Text = asdasd.ToString();


                dick.Children.Add(dingnogiets);
            }
        }
    }
}
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
	public partial class CocktailPage : ContentPage
	{
		public CocktailPage (string _name, string _desc, string _tags)
		{
			InitializeComponent ();

            lineImage.Source = ImageSource.FromResource("LocalDBPractice.Images.line.png");

            addDetails(_name, _desc, _tags);
        }

        public void addDetails(string name, string desc, string tags)
        {
            CocktailName.Text = name;
            CocktailDesc.Text = desc;
            CocktailTags.Text = tags;
        }
	}
}
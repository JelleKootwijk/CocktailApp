using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LocalDBPractice
{
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}

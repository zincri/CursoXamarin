using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CursoXamarin.Views
{
    public class AppTabbedPage : TabbedPage
    {
        public AppTabbedPage()
        {

            this.BarTextColor = Color.FromHex("#FF0000");
            Children.Add(new OnePage() { Icon="Ic_onepage.png",Title="One"});
            Children.Add(new TwoPage() { Icon = "Ic_twopage.png", Title = "Two" });



        }
    }
}
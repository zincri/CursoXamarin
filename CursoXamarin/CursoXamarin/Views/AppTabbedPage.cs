using CursoXamarin.ViewModels;
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
            this.BarTextColor = Color.FromHex("#4ff2e2");
            MainViewModel main = MainViewModel.GetInstance();
             main.One = new OneViewModel();
             main.Two = new TwoViewModel();

            Children.Add(new OnePage() { Icon = "ic_onepage.png", Title="One" });
            Children.Add(new TwoPage() { Icon = "ic_twopage.png", Title = "Two" });
        }
    }
}
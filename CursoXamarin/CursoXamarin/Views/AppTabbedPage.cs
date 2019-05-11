using System;
using CursoXamarin.ViewModels;
using Xamarin.Forms;

namespace CursoXamarin.Views
{
    public class AppTabbedPage : TabbedPage
    {
        public AppTabbedPage()
        {
            //this.BarBackgroundColor = Color.FromHex("#002E6D");
            this.BarTextColor = Color.FromHex("#fda8ff");
            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.Two = new TwoViewModel();
            mainViewModel.One = new OneViewModel();

            Children.Add(new OnePage() { Icon = "ic_one.png",Title = "One" });
            Children.Add(new TwoPage() { Icon = "ic_two.png",Title = "Two" });
        }
    }
}


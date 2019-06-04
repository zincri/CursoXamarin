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
		public AppTabbedPage ()
		{
            this.BarBackgroundColor = Color.FromHex("#0ED838");
            this.BarTextColor = Color.FromHex("#000000");

            MainViewModel mainViewModel = MainViewModel.GetInstance();
            mainViewModel.One = new OneViewModel();
            mainViewModel.Two = new TwoViewModel();

            Children.Add(new OnePage() { Icon ="ic_one_page.png",Title="One" });
            Children.Add(new TwoPage() { Icon = "ic_two_page.png", Title="Two" });
       
        }
	}
}
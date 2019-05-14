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
            this.BarTextColor = Color.FromHex("#1a237e");
            MainViewModel mn =MainViewModel.GetInstance();
          
            mn.One = new OneViewModel(); 
            mn.Two = new TwoViewModel();
            Children.Add(new OnePage() { Icon="ic_onepage.png",Title="OnePage"});
            Children.Add(new Two() { Icon = "ic_twopage.png", Title = "TwoPage" });
            

            
		}
	}
}
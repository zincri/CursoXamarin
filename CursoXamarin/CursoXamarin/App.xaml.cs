using CursoXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

          
            //MainPage = new NavigationPage(new LoginPage());
            NavigationPage obj= new NavigationPage(new LoginPage());
            obj.BackgroundColor = Color.FromHex("#f75d86");
            obj.BarTextColor = Color.FromHex("#FFFFFF");
            MainPage = obj;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

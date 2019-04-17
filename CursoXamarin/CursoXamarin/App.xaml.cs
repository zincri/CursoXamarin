using System;
using CursoXamarin.Views;
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

           // MainPage = new NavigationPage(new LoginPage());
           NavigationPage obj = new NavigationPage(new LoginPage());
            obj.BarBackgroundColor = Color.FromHex("#ffbfb2");
            obj.BarTextColor = Color.FromHex("#e567ca");
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

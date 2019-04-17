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
            NavigationPage objeto = new NavigationPage(new Views.LoginPage());
            objeto.BarBackgroundColor = Color.FromHex("#320172");
            objeto.BarTextColor = Color.FromHex("#fda8ff");
            MainPage = objeto;
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

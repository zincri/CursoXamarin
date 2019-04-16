using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CursoXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //user.Text = string.Empty;
            //password.Text = string.Empty;
        }
        void Login(object sender, System.EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Mensaje","Click en Login, "+user.Text,"Ok");


        }
        void Register(object sender, System.EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Mensaje", "Click en Register, " + user.Text, "Ok");
        }
    }
}

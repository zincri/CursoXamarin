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
            User.Text = String.Empty;
            Password.Text = String.Empty;    //Cadena Vacia similar a poner Empty

        }

        private void Login(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Login","Click en Login " + User.Text,"Exitoso");
            User.Text = String.Empty;
            Password.Text = String.Empty;    



        }

        private void Register(object sender, EventArgs e)
        {

            App.Current.MainPage.DisplayAlert("Register", "Click en Register " + User.Text,"Aceptado");
        }
    }
}

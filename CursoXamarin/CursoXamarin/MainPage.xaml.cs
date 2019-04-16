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
            usuario.Text = String.Empty;
            password.Text = String.Empty;

        }

            void Login(object sender, System.EventArgs e)
            {

                App.Current.MainPage.DisplayAlert("login", "click en login " + usuario.Text, "Bienvenido");
                usuario.Text = String.Empty;
                password.Text = String.Empty;

            }

            void Register(object sender, System.EventArgs e)
            {
                App.Current.MainPage.DisplayAlert("Register", "Click en register " + usuario.Text, "Registrate");

            }
        }
    }




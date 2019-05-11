
namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using Xamarin.Forms;

    #region Methods
    public class LoginViewModel : INotifyPropertyChanged
    #endregion
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Vars
        private bool _isEnabled;
        private string _usuario;
        private string _password;

        #endregion





        #region Properties
        public String Usuario
        {

            get
            {
                return _usuario;

            }


            set
            {
                _usuario = value;
                OnPropertyChanged();// Evento que nos avisa que se hizo un cambio
            }

        }
        public String password
        {

            get
            {
                return _usuario;

            }


            set
            {
                _password = value;
                OnPropertyChanged();
            }



        }
        public bool IsEnabled { get { return _isEnabled; } set { _isEnabled = value; OnPropertyChanged(); } }


        #endregion

        #region Comands

        public ICommand LoginComand { get { return new RelayCommand(LoginMethod); } } // Relay es una clase
        #endregion 



        #region Methods
        private async void LoginMethod()
        {
            // IsEnabled =false; solo se pone cuando va ha cargar...
            Usuario = string.Empty;
            //password = string.Empty;// La mejor manera de  como poner cadena  vacia... 

            //App.Current.MainPage.DisplayAlert("Login","Click en Login" ,"Ok");
            //IsEnabled = false;

            // await App.Current.MainPage.Navigation.PushAsync(new TwoPage());  // Async (Especifica que va ha mandar una tarea) tiene que ir de la mano con await es un esperador...
            // IsEnabled = false;

            //await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage() { BarBackgroundColor = Color.FromHex("#F8BBD0"), BarTextColor = Color.FromHex("#BBDEFB") });
            App.Current.MainPage = (new AppTabbedPage() { BarBackgroundColor = Color.FromHex("#F8BBD0"), BarTextColor = Color.FromHex("#BBDEFB") });


        }

        #endregion Methods

        #region Constructor
        public LoginViewModel()
        {

            this.Usuario = "Antonio ";
            this.password = "1234";
            IsEnabled = true;
        }

        // Para no esceficar lo que va ha llamar
        //Brackquets especificamos que tiene que pasar por CallerMember
        private void OnPropertyChanged([CallerMemberName] String PropertyName = "")  //Nos sirve para actualizar...//Nos sirve para actualizar...
        {      //Para actualizar el nombre de la propiedad...
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));// Toma el valor que manda a llamar


            }




        }
        #endregion

    }
}

namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    #region Methods
    public class LoginViewModel : INotifyPropertyChanged
    #endregion
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Vars
        private bool _isEnabled;

        #endregion





        #region Properties
        public String Usuario { get; set; }
        public String password { get; set; }
        public bool IsEnabled { get { return _isEnabled; } set { _isEnabled = value; OnPropertyChanged(); } }


        #endregion

        #region Comands

        public ICommand LoginComand { get { return new RelayCommand(LoginMethod); } } // Relay es una clase
        #endregion 



        #region Methods
        private async void LoginMethod()
        {


            //App.Current.MainPage.DisplayAlert("Login","Click en Login" ,"Ok");
            //IsEnabled = false;

            await App.Current.MainPage.Navigation.PushAsync(new TwoPage());  // Para lanzar otra pagina 
            IsEnabled = false;
        }

        #endregion



        #region Constructor
        public LoginViewModel()
        {

            this.Usuario = "Antonio ";
            this.password = "1234";
            IsEnabled = true;
        }

        // Para no esceficar lo que va ha llamar
        //Brackquets especificamos que tiene que pasar por CallerMember
        private void OnPropertyChanged([CallerMemberName] String PropertyName = "")
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));


            }




        }
        #endregion

    }
}

namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;

    public  class LoginViewModel
    {
        #region Properties
        public String Usuario { get; set; }
        public String password { get; set; }
        public bool IsEnabled { get; set; }
        #endregion

        #region Comands
           
        public ICommand LoginComand { get { return new RelayCommand(LoginMethod); } } // Relay es una clase
private  async void LoginMethod()
        {


            //App.Current.MainPage.DisplayAlert("Login","Click en Login" ,"Ok");
            //IsEnabled = false;

            await App.Current.MainPage.Navigation.PushAsync(new TwoPage());  // Para lanzar otra pagina 
        }

        #endregion



        public LoginViewModel()
        {

            this.Usuario = "Antonio ";
            this.password = "1234";
            IsEnabled=true;
        }

    }
}

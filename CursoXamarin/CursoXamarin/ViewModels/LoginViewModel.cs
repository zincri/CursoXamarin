
namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }
        #endregion


        #region Constructors
        public LoginViewModel()
        {
            this.Usuario = "Jhoana Dominguez";
            this.Password = "1234";
            IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(LoginMethod); } }
        #endregion

        #region Method
        private async void LoginMethod()
        {
            //App.Current.MainPage.DisplayAlert("Login", "click en login ", "ok");
            //IsEnabled = false; 
            await App.Current.MainPage.Navigation.PushAsync(new TwoPage());
          
        }

        #endregion
    }
}

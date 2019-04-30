namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region Properties
        public string Usuario
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get;
            set;
        }

        #endregion
        
        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(LoginMethod); } }
        #endregion
        private async void LoginMethod()
        {

            //App.Current.MainPage.DisplayAlert("login","click en login","ok");
            //IsEnabled = false;
            await App.Current.MainPage.Navigation.PushAsync (new TwoPage());
            
        }




        #region Constructors
        public LoginViewModel()
        {
            Usuario = "misa";
            Password = "123456";
            IsEnabled = false;
        }
        #endregion
    
    }
}

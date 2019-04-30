namespace CursoXamarin.ViewModels
{
    using System;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

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
        #region Constructors
        public LoginViewModel()
        {
            Usuario = "zincri";
            Password = "123456";
            IsEnabled = true;
        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(AccessMethod);
            }
        }
        #endregion
        private async void AccessMethod()
        {
            //IsEnabled = false;
            //App.Current.MainPage.DisplayAlert("Message", "Clic en Login", "Ok");
            //IsEnabled = false;
            //App.Current.MainPage.DisplayAlert("Message", "flag: "+IsEnabled, "Ok");
            await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());

        }
    }
}

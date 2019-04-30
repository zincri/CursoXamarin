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

        public bool Isenable
        { get; set; }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            Usuario = "Borraz";
            Password = "1234";
            Isenable = true;
            
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {

            get {
                return new RelayCommand(LoginMethod);
            }
        }

        private async void LoginMethod()
        {
            //App.Current.MainPage.DisplayAlert("Atencion","Click Login","OK");
            //Isenable = false;

            await App.Current.MainPage.Navigation.PushAsync(new Two());

        }
        

        #endregion



    }
}

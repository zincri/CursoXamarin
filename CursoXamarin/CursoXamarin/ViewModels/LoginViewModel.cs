namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Vars
        private bool _isEnable
        {
            get;
            set;
        }
        
        #endregion


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
        {
            get
            {
                return _isEnable;
            }

            set {

                _isEnable = value;
                OnPropertyChanged();

            }

        }
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
        #endregion
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;


        #endregion

        #region Methods
        private async void LoginMethod()
        {
            //App.Current.MainPage.DisplayAlert("Atencion","Click Login","OK");
            //Isenable = false;

            await App.Current.MainPage.Navigation.PushAsync(new Two());
            Isenable = false;

        }

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

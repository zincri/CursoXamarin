namespace CursoXamarin.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Eventss
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Vars
        private bool _isEnabled;
        private string _password;
        private string _usuario;
        #endregion
        #region Properties

        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabled
        {
            get 
            {
                return _isEnabled;
            }
            set 
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
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
        #region Methods
        private async void AccessMethod()
        {
            //IsEnabled = false;
            //App.Current.MainPage.DisplayAlert("Message", "Clic en Login", "Ok");
            //IsEnabled = false;
            //App.Current.MainPage.DisplayAlert("Message", "flag: "+IsEnabled, "Ok");
            await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());
            IsEnabled = false;
        }

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

namespace CursoXamarin.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Vars
        private bool _isEnabled;
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

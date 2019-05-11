namespace CursoXamarin.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
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
                return new RelayCommand(LoginMethod);
            }
        }
        #endregion
        #region Methods
        private async void LoginMethod()
        {

            //await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());


            App.Current.MainPage = new NavigationPage(new AppTabbedPage())
            {
                BarBackgroundColor = Color.FromHex("#320172"),
                BarTextColor = Color.FromHex("#fda8ff")
            };
            /*
            await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage(){
                BarBackgroundColor = Color.FromHex("#320172"),
                BarTextColor = Color.FromHex("#fda8ff")
            }
            );
            */           
            Password = String.Empty;

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

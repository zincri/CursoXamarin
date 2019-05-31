namespace CursoXamarin.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using CursoXamarin.Services;
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Services
        private ApiService apiService;
        #endregion
        #region Vars
        private bool _isEnabled; 
        private bool _AI_isRunning;
        private bool _AI_isEnabled;
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
        public bool AI_IsEnabled
        {
            get
            {
                return _AI_isEnabled;
            }
            set
            {
                _AI_isEnabled = value;
                OnPropertyChanged();
            }

        }
        public bool AI_IsRunning
        {
            get
            {
                return _AI_isRunning;
            }
            set
            {
                _AI_isRunning = value;
                OnPropertyChanged();
            }

        }
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            this.apiService = new ApiService();
            Usuario = "zincri";
            Password = "123456";
            IsEnabled = true;
            AI_IsEnabled = false;
            AI_IsRunning = false;
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
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
        }
        #endregion
        #region Methods
        private async void LoginMethod()
        {
            IsEnabled = false;
            AI_IsEnabled = true;
            AI_IsRunning = true;
            var conection = await this.apiService.CheckConnection();

            if (!conection.IsSuccess)
            {
                IsEnabled = true;
                AI_IsEnabled = false;
                AI_IsRunning = false;
                await App.Current.MainPage.DisplayAlert(
                "Error",
                conection.Message,
                "Ok");
                this.Password = string.Empty;
                return;
            }
            /*
            App.Current.MainPage = new NavigationPage(new AppTabbedPage())
            {
                BarBackgroundColor = Color.FromHex("#320172"),
                BarTextColor = Color.FromHex("#fda8ff")
            };
            */

            await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage(){
                BarBackgroundColor = Color.FromHex("#320172"),
                BarTextColor = Color.FromHex("#fda8ff")
            }
            );
                      
            Password = String.Empty;
            IsEnabled = true;
            AI_IsEnabled = false;
            AI_IsRunning = false;

        }
        private async void RegisterMethod()
        {

            //await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());

            var mainviewModel = MainViewModel.GetInstance();
            mainviewModel.Register = new RegisterViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
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

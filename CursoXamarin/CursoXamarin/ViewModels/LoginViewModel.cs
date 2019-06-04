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
        // INVESTIGAR ESTADOS PUBLICAR FOTOS
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Services
        public ApiService ApiService { get; set; }
        #endregion

        #region Vars
        private bool _isEnabled;
        private string _password;
        private string _usuario;
        private bool _AI_IsEnabled;
        private bool _AI_isRunning;
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
                return _AI_IsEnabled;
            }
            set
            {
                _AI_IsEnabled = value;
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
            this.ApiService = new ApiService();
            Usuario = "Angel";
            Password = "123";
            AI_IsEnabled = false;
            AI_IsRunning = false;   
            //IsEnabled = true;
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

        public object DisplayAlert { get; private set; }

        #endregion

        #region Methods
        private async void LoginMethod()
        {
            //App.Current.MainPage.DisplayAlert("Message", "Clic en Login", "Ok");
            //IsEnabled = false;
            //App.Current.MainPage.DisplayAlert("Message", "flag: "+IsEnabled, "Ok");
            //await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());

            IsEnabled = false;
            AI_IsEnabled = true;
            AI_IsRunning = true;
        
            var connection = await this.ApiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                IsEnabled = true;
                AI_IsEnabled = false;
                AI_IsRunning = false;
                App.Current.MainPage.DisplayAlert("Error",connection.Message,"Ok");
                Password = String.Empty;
            }

            //Usuario = string.Empty;
            //Password = string.Empty;

            await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage() { BarBackgroundColor= Color.FromHex("#1a4356"),BarTextColor=Color.FromHex("#ff1ff6") });
            Password = string.Empty;
            IsEnabled = true;
            AI_IsEnabled = false;
            AI_IsRunning = false;

            /*App.Current.MainPage = new NavigationPage(new AppTabbedPage()) {
                BarBackgroundColor = Color.FromHex("#0ED838"),
                BarTextColor = Color.FromHex("#000000")
            };*/

        }
        private async void RegisterMethod()
        {

            var main = MainViewModel.GetInstance();
            main.Register = new RegisterViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
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

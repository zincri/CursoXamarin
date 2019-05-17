
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

    public class LoginViewModel : INotifyPropertyChanged //interfaz ,nos implenenta el evento
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Services
        public ApiService apiService{
            get; set;
        }
        #endregion

        #region Vars
        private bool _AI_isEnabled;
        private bool _isRunning;
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
                OnPropertyChanged(); //evento que nos avisa 
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
            get { return _AI_isEnabled; }
            set {
                _AI_isEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            set {
                _isRunning = value;
                OnPropertyChanged();
            }

        }

        #endregion
        #region Constructors
        public LoginViewModel()
        {
            Usuario = "jhoana";
            Password = "123";
            IsEnabled = true;
            AI_IsEnabled = false;
            IsRunning = false;

            this.apiService=new ApiService();
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
            get {
                return new RelayCommand(RegisterMethod);
            }
        }
        #endregion
        #region Methods
        // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica. Puede usar el operador 'await' para esperar llamadas API que no sean de bloqueo o 'await Task.Run(...)' para hacer tareas enlazadas a la CPU en un subproceso en segundo plano.
        private async void LoginMethod()
        // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica. Puede usar el operador 'await' para esperar llamadas API que no sean de bloqueo o 'await Task.Run(...)' para hacer tareas enlazadas a la CPU en un subproceso en segundo plano.
        {//Async asincrono avisa que el metodo sera asincrono y tendra await


            //await con esto decimo que lo que sigue va hacer una tarea o hilo
            //await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());
            //await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage() { BarTextColor = Color.FromHex("#4ff2a2"),BarBackgroundColor= Color.FromHex("#f413cf") });

            IsEnabled = false;
            AI_IsEnabled = true;
            IsRunning = true;
            var conection = await this.apiService.CheckConection();
            if (!conection.IsSuccess)
            {
                IsEnabled = true;
                AI_IsEnabled = false;
                IsRunning = false;

                App.Current.MainPage.DisplayAlert("Error", conection.Message, "Ok");
                Password = string.Empty;
                return;
            }

            //App.Current.MainPage = new NavigationPage(new AppTabbedPage()) {BarBackgroundColor= Color.FromHex("#ffbfb2"),BarTextColor = Color.FromHex("#e567ca")};
            await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage() { BarTextColor = Color.FromHex("#4ff2a2"), BarBackgroundColor = Color.FromHex("#f413cf") });
            Password = String.Empty;
            IsEnabled = true;
            AI_IsEnabled = false;
            IsRunning = false;

        }

        // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica. Puede usar el operador 'await' para esperar llamadas API que no sean de bloqueo o 'await Task.Run(...)' para hacer tareas enlazadas a la CPU en un subproceso en segundo plano.
        private async void RegisterMethod() {
#pragma warning restore CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica. Puede usar el operador 'await' para esperar llamadas API que no sean de bloqueo o 'await Task.Run(...)' para hacer tareas enlazadas a la CPU en un subproceso en segundo plano.

            MainViewModel main = MainViewModel.GetInstance();

            main.Register = new RegisterViewModel();

            App.Current.MainPage = new NavigationPage(new RegisterPage());
        }
                              

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {//noa sirve para actualizar
            if (PropertyChanged != null)
            {//       tiene el valor que la manda a llamar
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

       
    }
}

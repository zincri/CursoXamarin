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
        public bool IsEnabled
        {
            get
            {

                return _isEnable;
            }
            set {
                //value= es una palabra reservada, las popiedades son como puentes
                _isEnable = value;
                OnPropertyChanged();

            }
        }

        #endregion
        
        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(LoginMethod); } }


        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods
        private async void LoginMethod()
        {

            //App.Current.MainPage.DisplayAlert("login","click en login","ok");
            //IsEnabled = false;
             await App.Current.MainPage.Navigation.PushAsync(new TwoPage());
            Password = String.Empty;
           
            //Async = asincrono, va ser un metodo asincrono
            //await = esperador, para lanzar una tarea

        }

        private void OnPropertyChanged([CallerMemberName]String PropetyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropetyName));
            }


        }
        #endregion

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

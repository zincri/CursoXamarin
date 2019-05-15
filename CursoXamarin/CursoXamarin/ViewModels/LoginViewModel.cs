namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Vars
        private bool _isEnable
        {
            get;
            set;
        }

        private String _usuario {
            get;
            set;
        }

        private String _password {
            get;
            set; 
        }
        
        #endregion


        #region Properties
        public string Usuario
        {
            get { return _usuario; }
            set {
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

        public ICommand RegisterCommand {

            get {
                return new RelayCommand(RegisterMethod);
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

            //await App.Current.MainPage.Navigation.PushAsync(new Two());
            // Password  = String.Empty;

            /*    await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage() {
                    BarBackgroundColor =Color.FromHex("#e91e63"), BarTextColor=Color.FromHex("#3949ab")});
                Password = String.Empty;*/

            App.Current.MainPage = new NavigationPage(new AppTabbedPage())
            {
                BarBackgroundColor = Color.FromHex("#320172"),
                BarTextColor = Color.FromHex("#fda8ff")
            };
        
        }

        private async void RegisterMethod() {

            MainViewModel mv = MainViewModel.GetInstance();
            mv.Register = new RegisterViewModel();
          await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        private void OnPropertyChanged([CallerMemberName] String PropertyName = "")
                           /*especifca la propiedad que toma el valor que manda a llamar*/
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        #endregion



    }
}

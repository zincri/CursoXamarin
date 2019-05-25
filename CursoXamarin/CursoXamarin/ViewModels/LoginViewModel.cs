namespace CursoXamarin.ViewModels
{
    using CursoXamarin.Services;
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {

        #region Services

        public ApiService apiService{

            get;
            set;

        }
        
        
        #endregion

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

        private bool AI_isEnable {
            get;
            set; 
        }

        private bool _isRunning {
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

        public bool AI_Isenable {

            get { return AI_isEnable; }

            set {

                AI_isEnable = value;
                OnPropertyChanged();
            }

        }

        public bool IsRunnig {
            get { return _isRunning;  }

            set {
                IsRunnig = value;
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
            IsRunnig = false;
            AI_isEnable = false;
            this.apiService = new ApiService();
            
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
            Isenable = false;
            AI_isEnable = true;
            IsRunnig = true;


            var Connection = await this.apiService.CheckConection();

            if (!Connection.IsSuccess) {

                Isenable = true;
                AI_isEnable = false;
                IsRunnig = false;

                App.Current.MainPage.DisplayAlert("Error", Connection.Message, "OK");
                Password = String.Empty;
                return;

            }



            //await App.Current.MainPage.Navigation.PushAsync(new Two());
            // Password  = String.Empty;

                await App.Current.MainPage.Navigation.PushAsync(new AppTabbedPage() {
                BarBackgroundColor =Color.FromHex("#e91e63"), BarTextColor=Color.FromHex("#3949ab")});
                Password = String.Empty;
                Isenable = true;
                AI_isEnable = false;
                IsRunnig = false;



            /*  App.Current.MainPage = new NavigationPage(new AppTabbedPage())
              {
                  BarBackgroundColor = Color.FromHex("#320172"),
                  BarTextColor = Color.FromHex("#fda8ff")
              };*/




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

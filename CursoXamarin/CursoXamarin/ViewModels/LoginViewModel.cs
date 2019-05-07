
namespace CursoXamarin.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

    public class LoginViewModel : INotifyPropertyChanged //interfaz ,nos implenenta el evento
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

        #endregion
        #region Constructors
        public LoginViewModel()
        {
            Usuario = "jhoana";
            Password = "123";
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
        {//Async asincrono avisa que el metodo sera asincrono y tendra await
           
            Password = String.Empty;
            //await con esto decimo que lo que sigue va hacer una tarea o hilo
            await App.Current.MainPage.Navigation.PushAsync(new Views.TwoPage());

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

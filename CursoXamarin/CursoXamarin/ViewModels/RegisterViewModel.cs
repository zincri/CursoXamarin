using System;
using System.Collections.Generic;
using System.Text;

namespace CursoXamarin.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using CursoXamarin.Views;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class RegisterViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Vars
        private string _hello;
        public string RegisterHello
        {
            get
            {
                return _hello;
            }
            set
            {
                _hello = value;
                OnPropertyChanged();
            }
        }

        #region Constructors
        public RegisterViewModel()
        {
            RegisterHello = "Hola RegisterPage";
        }
        #endregion

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

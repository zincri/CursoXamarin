namespace CursoXamarin.ViewModels
{
    using System;
    public class LoginViewModel
    {
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
            get;
            set;
        }

        #endregion
        #region Constructors
        public LoginViewModel()
        {
            Usuario = "zincri";
            Password = "123456";
            IsEnabled = false;
        }
        #endregion
    }
}

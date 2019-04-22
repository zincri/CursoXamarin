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

        public bool Isenable
        { get; set; }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            Usuario = "Borraz";
            Password = "1234";
            Isenable = false;
        
        }
        #endregion
    }
}


namespace CursoXamarin.ViewModels
{
    using System;

    public class LoginViewModel
    {
        #region Properties
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }
        #endregion


        #region Constructors
        public LoginViewModel()
        {
            this.Usuario = "Jhoana Dominguez";
            this.Password = "1234";
            IsEnabled = false;
        }
        #endregion
    }
}

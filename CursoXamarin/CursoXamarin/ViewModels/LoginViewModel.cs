﻿namespace CursoXamarin.ViewModels
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
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            Usuario = "zincri";
        }
        #endregion
    }
}

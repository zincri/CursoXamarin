
namespace CursoXamarin.ViewModels
{
    using System;
    public class MainViewModel
    {

        private static MainViewModel instance;


        #region ViewModels
        public LoginViewModel Login { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        #endregion

        #region Methods

        public static MainViewModel GetInstance() {

            if (instance ==null)  { return new MainViewModel(); }
            return instance;

        }
        #endregion 


       


    }
}

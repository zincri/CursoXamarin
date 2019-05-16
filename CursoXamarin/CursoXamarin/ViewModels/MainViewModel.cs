using System;
namespace CursoXamarin.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel instance;

        #region ViewModels
        public LoginViewModel Login { get; set; }
        public OneViewModel One { get; set; }
        public TwoViewModel Two { get; set; }
        public RegisterViewModel Register { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            //patron de singleton
            instance = this;
            this.Login = new LoginViewModel();

        }
        #endregion

        #region Methods
        public static MainViewModel GetInstance (){
            if (instance == null) { return new MainViewModel(); }
            return instance;
        }
        #endregion
    }
}

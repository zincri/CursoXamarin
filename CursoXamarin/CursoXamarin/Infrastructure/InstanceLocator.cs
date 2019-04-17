namespace CursoXamarin.Infrastructure
{
    using CursoXamarin.ViewModels;
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        #endregion
    }

}

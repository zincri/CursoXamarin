namespace CursoXamarin.Infrastructure
{
    using System;
    using CursoXamarin.ViewModels;

    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        #endregion


    }
}

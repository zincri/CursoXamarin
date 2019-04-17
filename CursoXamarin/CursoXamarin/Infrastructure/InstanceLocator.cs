
namespace CursoXamarin.Infrastructure
{
    using CursoXamarin.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class  InstanceLocator
    {
        #region MyRegion
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

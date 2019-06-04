using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CursoXamarin.ViewModels
{
    public class TwoViewModel
    {
        #region Properties
        public string Text { get; set; }
        #endregion
        #region Constructor
        public TwoViewModel() { Text = "TwoViewModel"; }
        #endregion
    }
}
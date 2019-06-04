using System;
using System.Collections.Generic;
using System.Text;

namespace CursoXamarin.Models
{
    public class Response
    {
        #region Properties 
        public bool IsSuccess { get; set; }
        public String Message { get; set; }
        public Object Result  { get; set; }
        #endregion
    }
}

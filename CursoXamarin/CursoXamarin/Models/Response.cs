using System;
using System.Collections.Generic;
using System.Text;

namespace CursoXamarin.Models
{
    class Response
    {
        #region Propierties
        public bool isSuccess { get; set; }
        public bool IsSuccess { get; internal set; }
        public string Message { get; set; }
        public object Result{ get; set; }

        #endregion
    }
}

using CursoXamarin.Models;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoXamarin.Services
{
    public class ApiService
    {
        #region Methods
        public async Task<Response> CheckConnection()
        {
            try
            {
                if (!CrossConnectivity.Current.IsConnected)
                {
                    return new Response { IsSuccess = false, Message = "No hay conexión, Checa tu conexión en Ajustes!" };
                }
                var isReacheable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

                if (!isReacheable)
                {
                    return new Response { IsSuccess = false, Message = "No hay conexión, verifica tu conexion a Internet"};
                }

                return new Response { IsSuccess = true, Message = "Si hay conexión a Internet" };
            }
            catch (Exception)
            {
                return new Response { IsSuccess = false, Message = "Upps... Algo salió mal, intenta de nuevo!!" };
            }
     }
    #endregion

    }
}

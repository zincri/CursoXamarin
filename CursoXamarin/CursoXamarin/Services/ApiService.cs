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
        public async Task<Response> CheckConection() {

            try
            {
                if (!CrossConnectivity.Current.IsConnected)
                {
                    return new Response { IsSuccess = false, Message = "Por favor checa tu conexion en ajustes" };
                }
                /// 
                var IsReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

                if (!IsReachable)
                {

                    return new Response{ IsSuccess=false,Message="Por favor checa tu conexion en internet"};

                }

                return new Response { IsSuccess = true, Message = "Listo conexion hecha" };
            }
            catch (Exception)
            {
                
                return new Response{ Message="Algo salio mal vuelve intentar"};
            }

        }
    }
}

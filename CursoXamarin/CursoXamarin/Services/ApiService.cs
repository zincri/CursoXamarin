namespace CursoXamarin.Services
{
    using System;
    using System.Threading.Tasks;
    using CursoXamarin.Models;
    using Plugin.Connectivity;

    public class ApiService
    {
        /// <summary>
        /// Checks the connection.
        /// Este Metodo sirve para checar la conexion de internet haciendo un ping a Google
        /// Antes de cada servicio se debe validar la conexion, falta pornerle el try y catch
        /// sin try y catch el metodo devolvera una excepcion cuando haga el ping.
        /// </summary>
        /// <returns>The connection.</returns>
        public async Task<Response> CheckConnection()
        {
            try
            {
                if (!CrossConnectivity.Current.IsConnected)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "Por favor checa tu conexion en ajustes.",
                    };
                }

                var isReachable = await CrossConnectivity.Current.IsRemoteReachable(
                    "google.com");
                if (!isReachable)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "Checa tu conexion a internet.",
                    };
                }

                return new Response
                {
                    IsSuccess = true,
                    Message = "Ok",
                };
            }
            catch (Exception)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = "Algo salio mal, vuelve a intentarlo.",
                };
            }
        }
    }
}


namespace CursoXamarin.Services
{
    using CursoXamarin.Models;
    using Plugin.Connectivity;
    using System;
    using System.Threading.Tasks;




    public class ApiServices
    {

        public async Task<Response> CheckConection()
        {


            try
            {
                     if(!CrossConnectivity.Current.IsConnected)
                {
                    return new Response { IsSuces = false, Message = "verifica tu conexion en ajustes" };


                }

              

                var IsReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

                if (!CrossConnectivity.Current.IsConnected)
                {
                    return new Response { IsSuces = false, Message = "Checa tu conexion a internet" };


                }

                 return new Response { IsSuces = true, Message = "Ok" };


                

            }
            catch (Exception)
            {
                
                return new Response { IsSuces = false, Message = "Vuelve a intentar" };
            }

            

        }

    }
}

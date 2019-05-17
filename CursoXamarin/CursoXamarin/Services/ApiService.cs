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
        public async Task<Response> CheckConection(){

      
            try
            {
                if (!CrossConnectivity.Current.IsConnected)
                {
                    return new Response { IsSuccess = false, Message = "checa tu conecion en ajustes" }; 

                }

                var IsReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

                if (!IsReachable) {
                    return new Response { IsSuccess = false, Message = "checa tu conecion a internet" };
                }

                return new Response { IsSuccess = false, Message = "Ya la hiciste" };


            } catch (Exception)
            {

                return new Response { Message = "Upps!!, Salio algo mal" };
            }

        }
    }
}

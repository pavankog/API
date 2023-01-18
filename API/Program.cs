using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new RestClient("https://secure17.cyclelution.com/CyclelutionV4_WebAPI_Test/api/CyclelutionWebSite/UserLogin");
                //client.Timeout = -1;
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                @"""UserName"": ""EEAdmin"",
" + "\n" +
                @"""Password"": ""@Ec$OH9""
" + "\n" +
                @"}
" + "\n" +
                @"";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                var response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

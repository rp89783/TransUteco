using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TransUteco.ViewModel;
using Newtonsoft.Json;

namespace TransUteco.Services
{
    public class LoginResponse
    {
        public string token;
    }
    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }
    public class WebServices
    {
        //https://fakerestapi.azurewebsites.net/api/Activities
        HttpClient httpClient;
        public WebServices()
        {
            httpClient = new HttpClient();
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var url = @"https://reqres.in/api/login";
            //var url = @"https://prosolution.dx.am/Login.php";
            try
            {

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseString);
                    return loginResponse;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        //public async Task<List<Activity>> GetActivities()
        //{
        //    var url = @"https://fakerestapi.azurewebsites.net/api/Activities";

        //    var data = await httpClient.GetAsync(url);
        //    if (data.IsSuccessStatusCode)
        //    {
        //        try
        //        {
        //            var result = await data.Content.ReadAsStringAsync();
        //            List<Activity> lista = JsonConvert.DeserializeObject<List<Activity>>(result);

        //            return lista;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            return null;
        //        }
        //    }
        //    return null;
        //}
    }
}

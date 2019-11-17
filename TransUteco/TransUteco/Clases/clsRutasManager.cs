using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json; 
namespace TransUteco.Clases
{
    class clsRutasManager
    {
        const string URL = "http://prosolution.dx.am/Listado.php";

        private HttpClient getRutas()
        {
            HttpClient Rut = new HttpClient();

            Rut.DefaultRequestHeaders.Add("Acecept", "application/jason");
            Rut.DefaultRequestHeaders.Add("Connection", "close");
            
            return Rut;
        }

        public async Task<IEnumerable<clsRutas>> getRuta()
        {

            HttpClient Ruta = new HttpClient();
            var res = await Ruta.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<clsRutas>>(content);
            }
            return Enumerable.Empty<clsRutas>();


        }
    }
}

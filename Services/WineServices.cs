using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace frontend.Services
{
    public class WineServices : IWineServices
    {
        static HttpClient client = new HttpClient();
        public WineServices()
        {
            client.BaseAddress = new Uri("http://localhost:3333/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public async Task<string> teste()
        {
            HttpResponseMessage response = await client.GetAsync("wine");
            response.EnsureSuccessStatusCode();
            Console.WriteLine("+========================================== passou 1");
            string a = "aaaa";
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("+========================================== passou 2");
                a = await response.Content.ReadAsStringAsync();
            }       
            
Console.WriteLine(a);     

Console.WriteLine("+========================================== passou 3");
            return a;
        }
        
    }
}
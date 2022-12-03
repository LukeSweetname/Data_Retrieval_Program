using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApiClient
{
    class Program
    {

        /*
        HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync(
                "https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:windows_10:-:id:*:*:*:*:*:*");

            Console.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {

            }
        }
        */
        public class Product
        {
            public string id { get; set; }
            // id
            public string cisaRequiredAction { get; set; }
            // cisarequiredaction
            public decimal value { get; set; }
            // description (value)
            public string accessComplexity { get; set; }
            // accesscomplexity
            public string baseSeverity { get; set; }
            // baseseverity
            public string exploitabilityScore { get; set; }
            // exploitabilityscore
            public string impactScore { get; set; }
            // impactscore
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("press any key to continue");
            Console.ReadLine();

            
            using (System.Net.Http.HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:windows_10:-:id:*:*:*:*:*:*");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"response error code: {response.StatusCode}");
                }
                
            }

        }
    }
}
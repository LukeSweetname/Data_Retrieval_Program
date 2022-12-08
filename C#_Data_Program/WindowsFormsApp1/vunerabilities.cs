using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
namespace WindowsFormsApp1
{
// API
// https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:windows_10:-:*:*:*:*:*:*:*
// API
namespace HttpClientSample
    {
        public class Product
        {
            public string id { get; set; }
            // id
            public string cisaRequiredAction { get; set; }
            // cisarequiredaction
            public string value { get; set; }
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

        class Program
        {
            static HttpClient client = new HttpClient();

            static void ShowProduct(Product product)
            {
                Console.WriteLine($"id: {product.id}\tcisaRequiredAction: " +
                    $"{product.cisaRequiredAction}\tvalue: {product.value}");
                Console.WriteLine($"accessComplexity: {product.accessComplexity}\tbaseSeverity: " +
                    $"{product.baseSeverity}\texploitabilityScore: {product.exploitabilityScore}");
                Console.WriteLine($"impactScore: {product.impactScore}");

            }

            static async Task<Uri> CreateProductAsync(Product product)
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    "api/products", product);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                return response.Headers.Location;
            }

            static async Task<Product> GetProductAsync(string path)
            {
                Product product = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<Product>();
                }
                return product;
            }

           /* static async Task<Product> UpdateProductAsync(Product product)
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                    $"api/products/{product.Id}", product);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                product = await response.Content.ReadAsAsync<Product>();
                return product;
            }

            static async Task<HttpStatusCode> DeleteProductAsync(string id)
            {
                HttpResponseMessage response = await client.DeleteAsync(
                    $"api/products/{id}");
                return response.StatusCode;
            }*/

            static void Main()
            {
                RunAsync().GetAwaiter().GetResult();
            }

            static async Task RunAsync()
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri("https://services.nvd.nist.gov/rest/json/cves/2.0");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    // Create a new product
                    Product product = new Product
                    {
                        id = "CVE - 2013 - 3900",
                        cisaRequiredAction = "Apply updates per vendor instructions.",
                        value = "The WinVerifyTrust function in Microsoft Windows XP SP2 and SP3, Windows Server 2003 SP2, Windows Vista SP2," +
                        "Windows Server 2008 SP2 and R2 SP1, Windows 7 SP1, Windows 8, Windows 8.1, Windows Server 2012 Gold and R2," +
                        "and Windows RT Gold and 8.1 does not properly validate PE file digests during Authenticode signature verification," +
                        "which allows remote attackers to execute arbitrary code via a crafted PE file, aka \"WinVerifyTrust Signature Validation Vulnerability.\"",
                        accessComplexity = "HIGH",
                        baseSeverity = "HIGH",
                        exploitabilityScore = "4.9",
                        impactScore = "10"
                    };

                    var url = await CreateProductAsync(product);
                    Console.WriteLine($"Created at {url}");

                    // Get the product
                    product = await GetProductAsync(url.PathAndQuery);
                    ShowProduct(product);

                    /*// Update the product
                    Console.WriteLine("Updating price...");
                    product.Price = 80;
                    await UpdateProductAsync(product);

                    // Get the updated product
                    product = await GetProductAsync(url.PathAndQuery);
                    ShowProduct(product);

                    // Delete the product
                    var statusCode = await DeleteProductAsync(product.Id);
                    Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");*/

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();
            }
        }
    }

}

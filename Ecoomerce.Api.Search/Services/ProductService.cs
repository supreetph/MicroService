using Ecoomerce.Api.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Search.Services
{
    public class ProductService : IproductService
    {
        private  IHttpClientFactory _httpClientFactory;
        public ProductService(IHttpClientFactory httpClientFactory  )
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<(bool IsSuccess, IEnumerable<Product> products)> GetProductAsync()
        {
            try
            {
                var client = _httpClientFactory.CreateClient("ProductService");
               var response=await  client.GetAsync("api/Product");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsByteArrayAsync();
                    var options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var result = JsonSerializer.Deserialize<IEnumerable<Product>>(
                        content,
                        options);
                    return (true, result);
                }
                return (false, null);
            }
            catch (Exception e)
            {

                throw e;
             
            }
        }
    }
}

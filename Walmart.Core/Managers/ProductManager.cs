using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Walmart.Core.Models;

namespace Walmart.Core.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IWebClientManager _webClientManager;
        private readonly ILogger _logger;

        public ProductManager(IWebClientManager webClientManager
            , ILoggerFactory loggerFactory)
        {
            _webClientManager = webClientManager ?? throw new ArgumentNullException(nameof(webClientManager));
            _logger = loggerFactory?.CreateLogger<ProductManager>();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            if (id <= 0) { return null; }
            return Deserialize<Product>(await _webClientManager.GetAsync($"v1/items/{id}?"));
        }

        public async Task<SearchQuery> FindByQuery(string queryString)
        {
            if (string.IsNullOrWhiteSpace(queryString)) { return null; }
            return Deserialize<SearchQuery>(await _webClientManager.GetAsync($"v1/search?query={queryString}"));
        }

        public async Task<IEnumerable<Product>> FindRecommendationsByIdAsync(int id)
        {
            if (id <= 0) { return null; }
            return Deserialize<IEnumerable<Product>>(await _webClientManager.GetAsync($"v1/nbp?itemId={id}"));
            //if no reommendations are found it returns a different Json structure. //Error//
        }

        private T Deserialize<T>(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value)) { return default(T); }
                return JsonConvert.DeserializeObject<T>(value, new JsonSerializerSettings()
                    { NullValueHandling = NullValueHandling.Ignore });
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message, exception.StackTrace);
                return default(T);
            }
        }
    }
}

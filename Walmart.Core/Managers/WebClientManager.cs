using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Walmart.Core.Helpers;
using Walmart.Core.Options;

namespace Walmart.Core.Managers
{
    public class WebClientManager : IWebClientManager
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly WebClientManagerOptions _webClientManagerOptions;
        private readonly ILogger _logger;

        public WebClientManager(IOptions<WebClientManagerOptions> optionsAccessor
             , ILoggerFactory loggerFactory)
        {
            _webClientManagerOptions = optionsAccessor.Value ?? throw new ArgumentNullException(nameof(optionsAccessor));
            _logger = loggerFactory?.CreateLogger<WebClientManager>();
            _httpClient.BaseAddress = new Uri(_webClientManagerOptions.BaseUri);
        }

        public async Task<string> GetAsync(string requestUriEx)
        {
            try
            {
                var httpResponseMessage = await _httpClient.GetAsync(
                    $"{requestUriEx}&format={_webClientManagerOptions.Format}&apiKey={_webClientManagerOptions.ApiKey}");

                if (!httpResponseMessage.IsSuccessStatusCode)
                {
                    _logger.LogError($"{httpResponseMessage?.StatusCode} - {httpResponseMessage?.RequestMessage?.RequestUri.RemoveQueryValue("apiKey")}");
                    return null;
                }

                return await httpResponseMessage.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException httpRequestException)
            {
                _logger.LogError(httpRequestException.Message, httpRequestException.StackTrace);
                return null;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message, exception.StackTrace);
                return null;
            }
        }      
     }
}

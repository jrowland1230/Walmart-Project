using System.Threading.Tasks;

namespace Walmart.Core.Managers
{
    public interface IWebClientManager
    {
        Task<string> GetAsync(string requestUriEx);
    }
}

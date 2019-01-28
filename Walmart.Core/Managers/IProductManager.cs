using System.Collections.Generic;
using System.Threading.Tasks;
using Walmart.Core.Models;

namespace Walmart.Core.Managers
{
    public interface IProductManager
    {
        Task<Product> FindByIdAsync(int id);
        Task<SearchQuery> FindByQuery(string queryString);
        Task<IEnumerable<Product>> FindRecommendationsByIdAsync(int id);
    }
}

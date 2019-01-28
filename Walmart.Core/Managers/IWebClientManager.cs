using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Walmart.Core.Managers
{
    public interface IWebClientManager
    {
        Task<string> GetAsync(string requestUriEx);
    }
}

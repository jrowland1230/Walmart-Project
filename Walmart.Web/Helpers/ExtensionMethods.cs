using System;
using System.Linq;

namespace Walmart.Web.Helpers
{
    public static class ExtensionMethods
    {
        public static string RemoveQueryValue(this Uri uri, string name)
        {
            if (uri == null) { return null; }

            var querystring = uri.Query.Split("&");
            var value = string.Join("", querystring?.Where(w => w.Contains(name)));

            if (value == null) { return null; }

            return value.Replace(value, "");
        }
    }
}

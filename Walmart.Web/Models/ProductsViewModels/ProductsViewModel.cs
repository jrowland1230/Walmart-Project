using System;
using System.Collections.Generic;

namespace Walmart.Web.Models.ProductsViewModels
{
    public class SearchQueryViewModel
    {
        public string Query { get; set; }
        public string Sort { get; set; }
        public string ResponseGroup { get; set; }
        public long TotalResults { get; set; }
        public long Start { get; set; }
        public long NumItems { get; set; }
        public List<object> Facets { get; set; }
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }

    public class ProductViewModel
    {
        public long ItemId { get; set; }
        public long ParentItemId { get; set; }
        public string Name { get; set; }
        public long Msrp { get; set; }
        public long SalePrice { get; set; }
        public string Upc { get; set; }
        public string CategoryPath { get; set; }
        public string LongDescription { get; set; }
        public string BrandName { get; set; }
        public Uri ThumbnailImage { get; set; }
        public Uri MediumImage { get; set; }
        public Uri LargeImage { get; set; }
        public List<ProductViewModel> Recommendations { get; set; } = new List<ProductViewModel>();
    }
}

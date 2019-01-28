using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Walmart.Core.Managers;
using Walmart.Core.Models;
using Walmart.Web.Models.ProductsViewModels;

namespace Walmart.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductManager _productManager;
        private readonly ILogger _logger;

        public ProductsController(IProductManager productManager
            , ILoggerFactory loggerFactory)
        {
            _productManager = productManager ?? throw new ArgumentNullException(nameof(productManager));
            _logger = loggerFactory?.CreateLogger<ProductsController>();
        }

        public IActionResult Search()
        {
            return View(new SearchQueryViewModel());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ProductViewModel model = new ProductViewModel();

            var product = await _productManager.FindByIdAsync(id);

            if (product != null)
            {
                model.BrandName = product.BrandName;
                model.CategoryPath = product.CategoryPath;
                model.ItemId = product.ItemId;
                model.LargeImage = product.LargeImage;
                model.LongDescription = product.LongDescription;
                model.MediumImage = product.MediumImage;
                model.Msrp = product.Msrp;
                model.Name = product.Name;
                model.ParentItemId = product.ParentItemId;
                model.SalePrice = product.SalePrice;
                model.ThumbnailImage = product.ThumbnailImage;
                model.Upc = product.Upc;
            }

            var recommendations = await _productManager.FindRecommendationsByIdAsync(id);

            if (recommendations != null)
            {
                foreach (var recommendation in recommendations)
                {
                    model.Recommendations.Add(new ProductViewModel()
                    {
                        BrandName = recommendation.BrandName
                        ,CategoryPath = recommendation.CategoryPath
                        ,ItemId = recommendation.ItemId
                        ,LargeImage = recommendation.LargeImage
                        ,LongDescription = recommendation.LongDescription
                        ,MediumImage = recommendation.MediumImage
                        ,Msrp = recommendation.Msrp
                        ,Name = recommendation.Name
                        ,ParentItemId = recommendation.ParentItemId
                        ,SalePrice = recommendation.SalePrice
                        ,ThumbnailImage = recommendation.ThumbnailImage
                        ,Upc = recommendation.Upc
                    });
                }
            }

            return View("details", model);
        }

        public async Task<IActionResult> Results(string query)
        {
            SearchQueryViewModel model = new SearchQueryViewModel();

            var searchQuery = await _productManager.FindByQuery(query);

            if (searchQuery != null)
            {
                model.NumItems = searchQuery.NumItems;
                model.Query = searchQuery.Query;

                if (searchQuery.Items != null && searchQuery.Items.Count > 0)
                {
                    foreach (var item in searchQuery.Items)
                    {
                        model.Products.Add(new ProductViewModel()
                        {
                            BrandName = item.BrandName
                            , CategoryPath = item.CategoryPath
                            , ItemId = item.ItemId
                            , LargeImage = item.LargeImage
                            , LongDescription = item.LongDescription
                            , MediumImage = item.MediumImage
                            , Msrp = item.Msrp
                            , Name = item.Name
                            , ParentItemId = item.ParentItemId
                            , SalePrice = item.SalePrice
                            , ThumbnailImage = item.ThumbnailImage
                            , Upc = item.Upc
                        });
                    }
                }
            }

            ViewData["Query"] = query;

            return View("search", model);
        }
    }
}
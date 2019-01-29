using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Walmart.Core.Models
{
    public class Product
    {
        [JsonProperty("itemId")]
        public long ItemId { get; set; }

        [JsonProperty("parentItemId")]
        public long ParentItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("msrp")]
        public long Msrp { get; set; }

        [JsonProperty("salePrice")]
        public long SalePrice { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }

        [JsonProperty("categoryPath")]
        public string CategoryPath { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        [JsonProperty("thumbnailImage")]
        public Uri ThumbnailImage { get; set; }

        [JsonProperty("mediumImage")]
        public Uri MediumImage { get; set; }

        [JsonProperty("largeImage")]
        public Uri LargeImage { get; set; }

        [JsonProperty("productTrackingUrl")]
        public Uri ProductTrackingUrl { get; set; }

        [JsonProperty("ninetySevenCentShipping")]
        public bool NinetySevenCentShipping { get; set; }

        [JsonProperty("standardShipRate")]
        public long StandardShipRate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("marketplace")]
        public bool Marketplace { get; set; }

        [JsonProperty("shipToStore")]
        public bool ShipToStore { get; set; }

        [JsonProperty("freeShipToStore")]
        public bool FreeShipToStore { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("productUrl")]
        public Uri ProductUrl { get; set; }

        [JsonProperty("customerRating")]
        public string CustomerRating { get; set; }

        [JsonProperty("customerRatingImage")]
        public Uri CustomerRatingImage { get; set; }

        [JsonProperty("categoryNode")]
        public string CategoryNode { get; set; }

        [JsonProperty("rollBack")]
        public bool RollBack { get; set; }

        [JsonProperty("bundle")]
        public bool Bundle { get; set; }

        [JsonProperty("clearance")]
        public bool Clearance { get; set; }

        [JsonProperty("stock")]
        public string Stock { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("addToCartUrl")]
        public Uri AddToCartUrl { get; set; }

        [JsonProperty("affiliateAddToCartUrl")]
        public Uri AffiliateAddToCartUrl { get; set; }

        [JsonProperty("freeShippingOver35Dollars")]
        public bool FreeShippingOver35Dollars { get; set; }

        [JsonProperty("giftOptions")]
        public GiftOptions GiftOptions { get; set; }

        [JsonProperty("imageEntities")]
        public List<ImageEntity> ImageEntities { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        [JsonProperty("shippingPassEligible")]
        public bool ShippingPassEligible { get; set; }

        [JsonProperty("availableOnline")]
        public bool AvailableOnline { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace JsonHelper
{
    public class Product
    {
        [JsonProperty("salsify:id")]
        public string? salsifyid { get; set; }

        [JsonProperty("salsify:created_at")]
        public DateTime? salsifycreated_at { get; set; }

        [JsonProperty("salsify:updated_at")]
        public DateTime? salsifyupdated_at { get; set; }

        [JsonProperty("salsify:version")]
        public int? salsifyversion { get; set; }

        [JsonProperty("salsify:profile_asset_id")]
        public object? salsifyprofile_asset_id { get; set; }

        [JsonProperty("salsify:system_id")]
        public string? salsifysystem_id { get; set; }
        public string? SKU { get; set; }

        [JsonProperty("Product Name")]
        public string? ProductName { get; set; }
        public bool? Purchasable { get; set; }
        public string? AvaTaxCode { get; set; }

        [JsonProperty("System Long Description")]
        public string? SystemLongDescription { get; set; }

        [JsonProperty("System Short Description")]
        public string? SystemShortDescription { get; set; }
        public bool? IsActive { get; set; }
        public string? NetsuiteIncomeAccount { get; set; }
        public object? Courses { get; set; }
        public string? ProductType { get; set; }
        public string? NetSuiteDepartment { get; set; }
        public string? NetSuiteID { get; set; }
        public string? NetsuiteLocation { get; set; }
        public string? NetSuiteClass { get; set; }
        public string? NetsuiteSubsidiary { get; set; }
        public string? NetsuiteRevenueRecognitionRule { get; set; }
        public string? Brand { get; set; }
        public string? LeadProductManager { get; set; }
        public bool? ShowPrice { get; set; }

        [JsonProperty("eCommerce Status")]
        public string? eCommerceStatus { get; set; }
        public string? RetailPrice { get; set; }
        public object? Keywords { get; set; }
        public string? Product_Type_Computed { get; set; }
        public string? Table_Example { get; set; }

        [JsonProperty("Salesforce ID")]
        public string? SalesforceID { get; set; }

        [JsonProperty("Short Description")]
        public string? ShortDescription { get; set; }

        [JsonProperty("Long Description")]
        public string? LongDescription { get; set; }

        [JsonProperty("Minimum Quantity")]
        public string? MinimumQuantity { get; set; }

        [JsonProperty("Maximum Quantity")]
        public string? MaximumQuantity { get; set; }

        [JsonProperty("Free Shipping")]
        public bool? FreeShipping { get; set; }

        [JsonProperty("Ship Separately")]
        public bool? ShipSeparately { get; set; }

        [JsonProperty("Overlay Opacity")]
        public string? OverlayOpacity { get; set; }

        [JsonProperty("Main Image")]
        public string? MainImage { get; set; }
        public string? Status { get; set; }

        [JsonProperty("salsify:digital_assets")]
        public List<SalsifyDigitalAsset>? salsifydigital_assets { get; set; }
        public bool? isFeatured { get; set; }
    }

    public class Root
    {
        public List<Product>? products { get; set; }
    }

    public class SalsifyDigitalAsset
    {
        [JsonProperty("salsify:id")]
        public string? salsifyid { get; set; }

        [JsonProperty("salsify:url")]
        public string? salsifyurl { get; set; }

        [JsonProperty("salsify:name")]
        public string? salsifyname { get; set; }

        [JsonProperty("salsify:created_at")]
        public DateTime? salsifycreated_at { get; set; }

        [JsonProperty("salsify:updated_at")]
        public DateTime? salsifyupdated_at { get; set; }

        [JsonProperty("salsify:status")]
        public string? salsifystatus { get; set; }

        [JsonProperty("salsify:asset_height")]
        public int? salsifyasset_height { get; set; }

        [JsonProperty("salsify:asset_width")]
        public int? salsifyasset_width { get; set; }

        [JsonProperty("salsify:asset_resource_type")]
        public string? salsifyasset_resource_type { get; set; }

        [JsonProperty("salsify:filename")]
        public string? salsifyfilename { get; set; }

        [JsonProperty("salsify:bytes")]
        public int? salsifybytes { get; set; }

        [JsonProperty("salsify:format")]
        public string? salsifyformat { get; set; }

        [JsonProperty("salsify:etag")]
        public string? salsifyetag { get; set; }

        [JsonProperty("salsify:system_id")]
        public string? salsifysystem_id { get; set; }

        [JsonProperty("salsify:source_url")]
        public string? salsifysource_url { get; set; }
    }
}


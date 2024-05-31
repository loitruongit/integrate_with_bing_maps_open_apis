using Newtonsoft.Json;

namespace integrate_with_bing_maps_open_apis.Responses
{
    public class GetLocationsResponse
    {
        [JsonProperty("authenticationResultCode")]
        public string AuthenticationResultCode { get; set; }

        [JsonProperty("brandLogoUri")]
        public string BrandLogoUri { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("resourceSets")]
        public List<ResourceSetLocations> ResourceSets { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("traceId")]
        public string TraceId { get; set; }
    }
    public class ResourceSetLocations
    {
        [JsonProperty("estimatedTotal")]
        public int EstimatedTotal { get; set; }

        [JsonProperty("resources")]
        public List<ResourceLocations> Resources { get; set; }
    }

    public class ResourceLocations
    {
        [JsonProperty("__type")]
        public string Type { get; set; }

        [JsonProperty("bbox")]
        public List<decimal> Bbox { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("point")]
        public PointLocations Point { get; set; }

        [JsonProperty("address")]
        public AddressLocations Address { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("geocodePoints")]
        public List<GeocodePointLocations> GeocodePoints { get; set; }

        [JsonProperty("matchCodes")]
        public List<string> MatchCodes { get; set; }
    }

    public class PointLocations
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<decimal> Coordinates { get; set; }
    }

    public class AddressLocations
    {
        [JsonProperty("addressLine")]
        public string AddressLine { get; set; }

        [JsonProperty("adminDistrict")]
        public string AdminDistrict { get; set; }

        [JsonProperty("adminDistrict2")]
        public string AdminDistrict2 { get; set; }

        [JsonProperty("countryRegion")]
        public string CountryRegion { get; set; }

        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class GeocodePointLocations
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public List<decimal> Coordinates { get; set; }

        [JsonProperty("calculationMethod")]
        public string CalculationMethod { get; set; }

        [JsonProperty("usageTypes")]
        public List<string> UsageTypes { get; set; }
    }
}

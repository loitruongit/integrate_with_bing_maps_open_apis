using Newtonsoft.Json;

namespace integrate_with_bing_maps_open_apis.Responses
{
    public class GetDistanceMatrixResponse
    {
        [JsonProperty("authenticationResultCode")]
        public string AuthenticationResultCode { get; set; }

        [JsonProperty("brandLogoUri")]
        public string BrandLogoUri { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("resourceSets")]
        public List<ResourceSetDistanceMatrix> ResourceSets { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("traceId")]
        public string TraceId { get; set; }
    }

    public class ResourceSetDistanceMatrix
    {
        [JsonProperty("estimatedTotal")]
        public int EstimatedTotal { get; set; }

        [JsonProperty("resources")]
        public List<ResourceDistanceMatrix> Resources { get; set; }
    }

    public class ResourceDistanceMatrix
    {
        [JsonProperty("__type")]
        public string Type { get; set; }

        [JsonProperty("destinations")]
        public List<DestinationDistanceMatrix> Destinations { get; set; }

        [JsonProperty("origins")]
        public List<OriginDistanceMatrix> Origins { get; set; }

        [JsonProperty("results")]
        public List<ResultDistanceMatrix> Results { get; set; }
    }

    public class DestinationDistanceMatrix
    {
        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }
    }

    public class OriginDistanceMatrix
    {
        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }
    }

    public class ResultDistanceMatrix
    {
        [JsonProperty("destinationIndex")]
        public decimal DestinationIndex { get; set; }

        [JsonProperty("originIndex")]
        public decimal OriginIndex { get; set; }

        [JsonProperty("totalWalkDuration")]
        public decimal TotalWalkDuration { get; set; }

        [JsonProperty("travelDistance")]
        public decimal TravelDistance { get; set; }

        [JsonProperty("travelDuration")]
        public decimal TravelDuration { get; set; }
    }
}

using Newtonsoft.Json;

namespace integrate_with_bing_maps_open_apis.Requests
{
    public class GetDistanceMatrixRequest
    {
        [JsonProperty("origins")]
        public List<LocationBingMaps> Origins { get; set; }

        [JsonProperty("destinations")]
        public List<LocationBingMaps> Destinations { get; set; }

        [JsonProperty("travelMode")]
        public string TravelMode { get; set; }

        public GetDistanceMatrixRequest()
        {
            TravelMode = "Driving";
        }
    }

    public class LocationBingMaps
    {
        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }
    }
}

namespace integrate_with_bing_maps_open_apis.Requests
{
    public class GetDistanceMatrixByBingMapsRequest
    {
        public List<LocationByBingMapsRequest> Origins { get; set; }

        public List<LocationByBingMapsRequest> Destinations { get; set; }
    }

    public class LocationByBingMapsRequest
    {
        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}

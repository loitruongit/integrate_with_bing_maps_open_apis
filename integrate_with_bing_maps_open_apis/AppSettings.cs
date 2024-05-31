namespace integrate_with_bing_maps_open_apis
{
    public class AppSettings
    {
        public BingMapsSettings BingMapsSettings { get; set; }
    }

    public class BingMapsSettings
    {
        public string GetLocationsEndpoint { get; set; }

        public string GetDistanceMatrixEndpoint { get; set; }

        public string BingMapsKey { get; set; }
    }
}

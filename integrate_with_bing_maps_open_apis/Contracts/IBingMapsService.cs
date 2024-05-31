using integrate_with_bing_maps_open_apis.Requests;
using integrate_with_bing_maps_open_apis.Responses;

namespace integrate_with_bing_maps_open_apis.Contracts
{
    public interface IBingMapsService
    {
        Task<GetLocationsResponse> GetLocationsByBingMapsAsync(GetLocationsByBingMapsRequest request);

        Task<GetDistanceMatrixResponse> GetDistanceMatrixByBingMapsAsync(GetDistanceMatrixByBingMapsRequest request);
    }
}

using integrate_with_bing_maps_open_apis.Contracts;
using integrate_with_bing_maps_open_apis.Requests;
using integrate_with_bing_maps_open_apis.Responses;
using Microsoft.AspNetCore.Mvc;

namespace integrate_with_bing_maps_open_apis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BingMapsController : ControllerBase
    {
        private readonly IBingMapsService _bingMapsService;
        public BingMapsController(IBingMapsService bingMapsService)
        {
            _bingMapsService = bingMapsService;
        }

        /// <summary>
        /// Get locations by BingMaps async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("locations")]
        public async Task<GetLocationsResponse> GetLocationsByBingMapsAsync([FromBody] GetLocationsByBingMapsRequest request)
        {
            return await _bingMapsService.GetLocationsByBingMapsAsync(request);
        }

        /// <summary>
        /// Get distance matrix by BingMaps Async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("distance-matrix")]
        public async Task<GetDistanceMatrixResponse> GetDistanceMatrixByBingMapsAsync([FromBody] GetDistanceMatrixByBingMapsRequest request)
        {
            return await _bingMapsService.GetDistanceMatrixByBingMapsAsync(request);
        }
    }
}

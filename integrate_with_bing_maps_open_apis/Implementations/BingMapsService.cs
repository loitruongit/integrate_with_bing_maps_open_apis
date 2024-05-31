using AutoMapper;
using integrate_with_bing_maps_open_apis.Contracts;
using integrate_with_bing_maps_open_apis.Requests;
using integrate_with_bing_maps_open_apis.Responses;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;

namespace integrate_with_bing_maps_open_apis.Implementations
{
    public class BingMapsService : IBingMapsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppSettings _appSettings;
        private readonly IMapper _mapper;
        public BingMapsService(IHttpClientFactory httpClientFactory, IOptions<AppSettings> options, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _appSettings = options.Value;
            _mapper = mapper;
        }

        /// <summary>
        /// Get locations by BingMaps async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetLocationsResponse> GetLocationsByBingMapsAsync(GetLocationsByBingMapsRequest request)
        {

            var _httpClient = _httpClientFactory.CreateClient();

            var fullAddress = BuildFullAddressForBingMaps(request);
            var endpoint = string.Format(_appSettings.BingMapsSettings.GetLocationsEndpoint, fullAddress, _appSettings.BingMapsSettings.BingMapsKey);
            var response = await _httpClient.GetAsync(endpoint);
            var content = await response.Content.ReadAsStringAsync();

            var apiResult = JsonConvert.DeserializeObject<GetLocationsResponse>(content);
            return apiResult;
        }

        /// <summary>
        /// Get distance matrix by BingMaps async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetDistanceMatrixResponse> GetDistanceMatrixByBingMapsAsync(GetDistanceMatrixByBingMapsRequest request)
        {

            var _httpClient = _httpClientFactory.CreateClient();

            var distanceMatrixRequest = new GetDistanceMatrixRequest
            {
                Origins = _mapper.Map<List<LocationByBingMapsRequest>, List<LocationBingMaps>>(request.Origins),
                Destinations = _mapper.Map<List<LocationByBingMapsRequest>, List<LocationBingMaps>>(request.Destinations)
            };

            var payload = new StringContent(JsonConvert.SerializeObject(distanceMatrixRequest), Encoding.UTF8, "application/json");

            var endpoint = string.Format(_appSettings.BingMapsSettings.GetDistanceMatrixEndpoint, _appSettings.BingMapsSettings.BingMapsKey);
            var response = await _httpClient.PostAsync(endpoint, payload);
            var content = await response.Content.ReadAsStringAsync();

            var apiResult = JsonConvert.DeserializeObject<GetDistanceMatrixResponse>(content);

            return apiResult;
        }

        /// <summary>
        /// Build full address for BingMaps
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private string BuildFullAddressForBingMaps(GetLocationsByBingMapsRequest request)
        {

            var listAddress = new List<string>();
            if (!string.IsNullOrEmpty(request.ProvinceName))
            {
                listAddress.Add(request.ProvinceName);
            }

            if (!string.IsNullOrEmpty(request.DistrictName))
            {
                listAddress.Add(request.DistrictName);
            }

            if (!string.IsNullOrEmpty(request.WardName))
            {
                listAddress.Add(request.WardName);
            }

            if (!string.IsNullOrEmpty(request.Address))
            {
                listAddress.Add(request.Address);
            }

            return Uri.EscapeDataString(string.Join("/ ", listAddress));
        }
    }
}

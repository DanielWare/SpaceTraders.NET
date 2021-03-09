using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using SpaceTraders.NET.Request;
using SpaceTraders.NET.Response;

namespace SpaceTraders.NET
{
    public class SpaceTraderApi
    {
        private static readonly HttpClient HttpClient = new();
        private const string BaseUrl = "https://api.spacetraders.io";

        private static readonly JsonSerializerOptions SerializerOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        
        private static async Task<TResponse?> AuthenticatedPost<TRequest, TResponse>(string relativeUrl, TRequest request, Func<TRequest, string> serialize) where TRequest : BaseAuthenticatedRequest
        {
            StringContent content = new(serialize(request));
            HttpRequestMessage requestMessage = new()
            {
                RequestUri = new Uri($"{BaseUrl}/{relativeUrl}"),
                Method = HttpMethod.Post,
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", request.Token)
                },
                Content = content
            };

            return await AuthenticatedSend<TRequest, TResponse>(requestMessage);
        }

        private static async Task<TResponse?> AuthenticatedGet<TRequest, TResponse>(string relativeUrl, TRequest request) where TRequest : BaseAuthenticatedRequest
        {
            HttpRequestMessage requestMessage = new()
            {
                RequestUri = new Uri($"{BaseUrl}/{relativeUrl}"),
                Method = HttpMethod.Get,
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", request.Token)
                }
            };

            return await AuthenticatedSend<TRequest, TResponse>(requestMessage);
        }

        private static async Task<TResponse?> AuthenticatedPut<TRequest, TResponse>(string relativeUrl, TRequest request) where TRequest : BaseAuthenticatedRequest
        {
            HttpRequestMessage requestMessage = new()
            {
                RequestUri = new Uri($"{BaseUrl}/{relativeUrl}"),
                Method = HttpMethod.Put,
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", request.Token)
                }
            };

            return await AuthenticatedSend<TRequest, TResponse>(requestMessage);
        }

        private static async Task<TResponse?> AuthenticatedSend<TRequest, TResponse>(HttpRequestMessage requestMessage)
        {
            HttpResponseMessage responseMessage = await HttpClient.SendAsync(requestMessage);
            return await DeserializeAsync<TResponse>(responseMessage);
        }
        
        private static async Task<T?> DeserializeAsync<T>(HttpResponseMessage response)
        {
            byte[] bytes = await response.Content.ReadAsByteArrayAsync();
            return JsonSerializer.Deserialize<T>(bytes, SerializerOptions);
        }

        private static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj, SerializerOptions);
        }
        
        public async Task<GetStatusResponse?> GetStatus()
        {
            HttpRequestMessage requestMessage = new()
            {
                RequestUri = new Uri($"{BaseUrl}/game/status"),
                Method = HttpMethod.Get
            };
            HttpResponseMessage responseMessage = await HttpClient.SendAsync(requestMessage);
            return await DeserializeAsync<GetStatusResponse>(responseMessage);
        }

        public async Task<CreateUserResponse?> CreateUser(CreateUserRequest request)
        {
            HttpRequestMessage requestMessage = new()
            {
                RequestUri = new Uri($"{BaseUrl}/users/{request.Username}/token"),
                Method = HttpMethod.Post
            };
            HttpResponseMessage responseMessage = await HttpClient.SendAsync(requestMessage);
            return await DeserializeAsync<CreateUserResponse>(responseMessage);
        }
        
        public async Task<GetYourUserResponse?> GetYourUser(BaseAuthenticatedRequest request) => 
            await AuthenticatedGet<BaseAuthenticatedRequest, GetYourUserResponse>($"users/{request.UserName}", request);

        public async Task<YourLoansResponse?> GetYourLoans(BaseAuthenticatedRequest request) =>
            await AuthenticatedGet<BaseAuthenticatedRequest, YourLoansResponse>($"users/{request.UserName}/loans", request);

        public async Task<TakeLoanResponse?> TakeLoan(TakeLoanRequest request) =>
            await AuthenticatedPost<TakeLoanRequest, TakeLoanResponse>($"users/{request.UserName}/loans", 
                request, (req) => Serialize(new { req.Type }));

        public async Task<PayLoanResponse?> PayLoan(PayLoanRequest request) =>
            await AuthenticatedPut<PayLoanRequest, PayLoanResponse>($"users/{request.UserName}/loans/{request.LoanId}",
                request);
        
        public async Task<YourShipsResponse?> GetYourShips(BaseAuthenticatedRequest request) => 
            await AuthenticatedGet<BaseAuthenticatedRequest, YourShipsResponse>($"users/{request.UserName}/ships", request);

        public async Task<PurchaseShipResponse?> PurchaseShip(PurchaseShipRequest request) =>
            await AuthenticatedPost<PurchaseShipRequest, PurchaseShipResponse>($"users/{request.UserName}/ships",
                request, (req) => Serialize(new { req.Type, req.Location }));

        public async Task<YourFlightPlanResponse?> GetFlightPlan(YourFlightPlanRequest request) =>
            await AuthenticatedGet<YourFlightPlanRequest, YourFlightPlanResponse>(
                $"users/{request.UserName}/flight-plans/{request.FlightPlanId}", request);

        public async Task<CreateFlightPlanResponse?> CreateFlightPlan(CreateFlightPlanRequest request) =>
            await AuthenticatedPost<CreateFlightPlanRequest, CreateFlightPlanResponse>($"users/{request.UserName}/flight-plans", 
                request, req => Serialize(new { req.ShipId, req.Location }));

        public async Task<ShipsResponse?> AvailableShips(BaseAuthenticatedRequest request) =>
            await AuthenticatedGet<BaseAuthenticatedRequest, ShipsResponse>($"game/ships", request);
        
        public async Task<LoansResponse?> AvailableLoans(BaseAuthenticatedRequest request) =>
            await AuthenticatedGet<BaseAuthenticatedRequest, LoansResponse>($"game/loans", request);

        public async Task<SystemsResponse?> Systems(BaseAuthenticatedRequest request) =>
            await AuthenticatedGet<BaseAuthenticatedRequest, SystemsResponse>($"game/systems", request);

        public async Task<LocationsResponse?> Locations(LocationsRequest request) =>
            await AuthenticatedGet<LocationsRequest, LocationsResponse>(
                $"game/systems/{request.SystemSymbol}/locations", request);

        public async Task<LocationResponse?> Location(LocationRequest request) =>
            await AuthenticatedGet<LocationRequest, LocationResponse>($"game/locations/{request.LocationSymbol}",
                request);

        public async Task<MarketplaceResponse?> Marketplace(MarketplaceRequest request) =>
            await AuthenticatedGet<MarketplaceRequest, MarketplaceResponse>(
                $"game/locations/{request.LocationSymbol}/marketplace", request);
    }
}
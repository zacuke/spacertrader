using Microsoft.Extensions.DependencyInjection;
using spacertrader.Services;
using GlobalSystem = global::System;

namespace spacertrader_client_api
{
  
    public partial class SpaceTradersClient
    {
 
        // Implement the partial method to add the authorization header
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            var apiToken = _configuration["SpaceTraders:ApiToken"];
            request.Headers.Authorization = new GlobalSystem.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
        }
        partial void PrepareRequest(GlobalSystem.Net.Http.HttpClient client, GlobalSystem.Net.Http.HttpRequestMessage request, GlobalSystem.Text.StringBuilder urlBuilder)
        {
            var apiToken = _configuration["SpaceTraders:ApiToken"];
            request.Headers.Authorization = new GlobalSystem.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);

        }

    }
     
}

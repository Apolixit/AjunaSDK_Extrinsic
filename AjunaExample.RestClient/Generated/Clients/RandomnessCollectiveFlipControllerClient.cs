//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using AjunaExample.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using AjunaExample.RestClient.Generated.Interfaces;
   
   public sealed class RandomnessCollectiveFlipControllerClient : BaseClient, IRandomnessCollectiveFlipControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public RandomnessCollectiveFlipControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT1> GetRandomMaterial()
      {
         return await SendRequestAsync<BoundedVecT1>(_httpClient, "randomnesscollectiveflip/randommaterial");
      }
      public async Task<bool> SubscribeRandomMaterial()
      {
         return await _subscriptionClient.SubscribeAsync("RandomnessCollectiveFlip.RandomMaterial");
      }
   }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using AjunaExample.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   using AjunaExample.NetApiExt.Generated.Model.pallet_transaction_payment;
   using AjunaExample.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TransactionPaymentControllerMockupClient : MockupBaseClient, ITransactionPaymentControllerMockupClient
   {
      private HttpClient _httpClient;
      public TransactionPaymentControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetNextFeeMultiplier(FixedU128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionPayment/NextFeeMultiplier", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.TransactionPaymentStorage.NextFeeMultiplierParams());
      }
      public async Task<bool> SetStorageVersion(EnumReleases value)
      {
         return await SendMockupRequestAsync(_httpClient, "TransactionPayment/StorageVersion", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.TransactionPaymentStorage.StorageVersionParams());
      }
   }
}
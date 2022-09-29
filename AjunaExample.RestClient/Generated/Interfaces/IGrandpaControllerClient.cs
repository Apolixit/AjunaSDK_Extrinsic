//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using AjunaExample.NetApiExt.Generated.Model.pallet_grandpa;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface IGrandpaControllerClient
   {
      Task<EnumStoredState> GetState();
      Task<bool> SubscribeState();
      Task<StoredPendingChange> GetPendingChange();
      Task<bool> SubscribePendingChange();
      Task<U32> GetNextForced();
      Task<bool> SubscribeNextForced();
      Task<BaseTuple<U32, U32>> GetStalled();
      Task<bool> SubscribeStalled();
      Task<U64> GetCurrentSetId();
      Task<bool> SubscribeCurrentSetId();
      Task<U32> GetSetIdSession(U64 key);
      Task<bool> SubscribeSetIdSession(U64 key);
   }
}
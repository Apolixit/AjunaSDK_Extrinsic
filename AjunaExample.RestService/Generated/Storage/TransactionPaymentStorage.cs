//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AjunaExample.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ITransactionPaymentStorage interface definition.
    /// </summary>
    public interface ITransactionPaymentStorage : IStorage
    {
        
        /// <summary>
        /// >> NextFeeMultiplier
        /// </summary>
        AjunaExample.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 GetNextFeeMultiplier();
        
        /// <summary>
        /// >> StorageVersion
        /// </summary>
        AjunaExample.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases GetStorageVersion();
    }
    
    /// <summary>
    /// TransactionPaymentStorage class definition.
    /// </summary>
    public sealed class TransactionPaymentStorage : ITransactionPaymentStorage
    {
        
        /// <summary>
        /// _nextFeeMultiplierTypedStorage typed storage field
        /// </summary>
        private TypedStorage<AjunaExample.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128> _nextFeeMultiplierTypedStorage;
        
        /// <summary>
        /// _storageVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<AjunaExample.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases> _storageVersionTypedStorage;
        
        /// <summary>
        /// TransactionPaymentStorage constructor.
        /// </summary>
        public TransactionPaymentStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.NextFeeMultiplierTypedStorage = new TypedStorage<AjunaExample.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128>("TransactionPayment.NextFeeMultiplier", storageDataProvider, storageChangeDelegates);
            this.StorageVersionTypedStorage = new TypedStorage<AjunaExample.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases>("TransactionPayment.StorageVersion", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _nextFeeMultiplierTypedStorage property
        /// </summary>
        public TypedStorage<AjunaExample.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128> NextFeeMultiplierTypedStorage
        {
            get
            {
                return _nextFeeMultiplierTypedStorage;
            }
            set
            {
                _nextFeeMultiplierTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _storageVersionTypedStorage property
        /// </summary>
        public TypedStorage<AjunaExample.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases> StorageVersionTypedStorage
        {
            get
            {
                return _storageVersionTypedStorage;
            }
            set
            {
                _storageVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await NextFeeMultiplierTypedStorage.InitializeAsync("TransactionPayment", "NextFeeMultiplier");
            await StorageVersionTypedStorage.InitializeAsync("TransactionPayment", "StorageVersion");
        }
        
        /// <summary>
        /// Implements any storage change for TransactionPayment.NextFeeMultiplier
        /// </summary>
        [StorageChange("TransactionPayment", "NextFeeMultiplier")]
        public void OnUpdateNextFeeMultiplier(string data)
        {
            NextFeeMultiplierTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextFeeMultiplier
        /// </summary>
        public AjunaExample.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 GetNextFeeMultiplier()
        {
            return NextFeeMultiplierTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TransactionPayment.StorageVersion
        /// </summary>
        [StorageChange("TransactionPayment", "StorageVersion")]
        public void OnUpdateStorageVersion(string data)
        {
            StorageVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> StorageVersion
        /// </summary>
        public AjunaExample.NetApiExt.Generated.Model.pallet_transaction_payment.EnumReleases GetStorageVersion()
        {
            return StorageVersionTypedStorage.Get();
        }
    }
}
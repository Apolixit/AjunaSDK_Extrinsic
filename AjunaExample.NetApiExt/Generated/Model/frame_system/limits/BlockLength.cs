//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace AjunaExample.NetApiExt.Generated.Model.frame_system.limits
{
    
    
    /// <summary>
    /// >> 57 - Composite[frame_system.limits.BlockLength]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class BlockLength : BaseType
    {
        
        /// <summary>
        /// >> max
        /// </summary>
        private AjunaExample.NetApiExt.Generated.Model.frame_support.weights.PerDispatchClassT3 _max;
        
        public AjunaExample.NetApiExt.Generated.Model.frame_support.weights.PerDispatchClassT3 Max
        {
            get
            {
                return this._max;
            }
            set
            {
                this._max = value;
            }
        }
        
        public override string TypeName()
        {
            return "BlockLength";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Max.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Max = new AjunaExample.NetApiExt.Generated.Model.frame_support.weights.PerDispatchClassT3();
            Max.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

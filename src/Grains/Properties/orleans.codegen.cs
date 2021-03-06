//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Cloudrocket.Grains
{
    using Cloudrocket.Interfaces;
    using Orleans.CodeGeneration;
    using Orleans;
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    using Cloudrocket.AvaTax;
    using PayPal.Api;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Cloudrocket.Grains.Cloudrocket.Grains.GrainCart")]
    public class GrainCartState : global::Orleans.CodeGeneration.GrainState, IGrainCartState
    {
        

            public Cart @Cart { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Cart", out value)) @Cart = (Cart) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("GrainCartState( Cart={0} )", @Cart);
            }
        
        public GrainCartState() : 
                base("Cloudrocket.Grains.GrainCart")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Cart"] = this.Cart;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Cart = new Cart();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            GrainCartState input = ((GrainCartState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            GrainCartState input = ((GrainCartState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            GrainCartState result = new GrainCartState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Cloudrocket.Grains.Cloudrocket.Grains.GrainPurchase")]
    public class GrainPurchaseState : global::Orleans.CodeGeneration.GrainState, IGrainPurchaseState
    {
        

            public Purchase @Purchase { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Purchase", out value)) @Purchase = (Purchase) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("GrainPurchaseState( Purchase={0} )", @Purchase);
            }
        
        public GrainPurchaseState() : 
                base("Cloudrocket.Grains.GrainPurchase")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Purchase"] = this.Purchase;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Purchase = new Purchase();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            GrainPurchaseState input = ((GrainPurchaseState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            GrainPurchaseState input = ((GrainPurchaseState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            GrainPurchaseState result = new GrainPurchaseState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Cloudrocket.Grains.Cloudrocket.Grains.ServiceGrainAvalara")]
    public class ServiceGrainAvalaraState : global::Orleans.CodeGeneration.GrainState, IServiceGrainAvalaraState
    {
        

            public GetTaxRequest @GetTaxRequest { get; set; }

            public GetTaxResult @GetTaxResult { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("GetTaxRequest", out value)) @GetTaxRequest = (GetTaxRequest) value;
                if (values.TryGetValue("GetTaxResult", out value)) @GetTaxResult = (GetTaxResult) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("ServiceGrainAvalaraState( GetTaxRequest={0} GetTaxResult={1} )", @GetTaxRequest, @GetTaxResult);
            }
        
        public ServiceGrainAvalaraState() : 
                base("Cloudrocket.Grains.ServiceGrainAvalara")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["GetTaxRequest"] = this.GetTaxRequest;
            result["GetTaxResult"] = this.GetTaxResult;
            return result;
        }
        
        private void InitStateFields()
        {
            this.GetTaxRequest = new GetTaxRequest();
            this.GetTaxResult = new GetTaxResult();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            ServiceGrainAvalaraState input = ((ServiceGrainAvalaraState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            ServiceGrainAvalaraState input = ((ServiceGrainAvalaraState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            ServiceGrainAvalaraState result = new ServiceGrainAvalaraState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Cloudrocket.Grains.Cloudrocket.Grains.ServiceGrainBingLocation")]
    public class ServiceGrainBingLocationState : global::Orleans.CodeGeneration.GrainState, IServiceGrainBingLocationState
    {
        

            public GeoLocation @BingLocation { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("BingLocation", out value)) @BingLocation = (GeoLocation) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("ServiceGrainBingLocationState( BingLocation={0} )", @BingLocation);
            }
        
        public ServiceGrainBingLocationState() : 
                base("Cloudrocket.Grains.ServiceGrainBingLocation")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["BingLocation"] = this.BingLocation;
            return result;
        }
        
        private void InitStateFields()
        {
            this.BingLocation = new GeoLocation();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            ServiceGrainBingLocationState input = ((ServiceGrainBingLocationState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            ServiceGrainBingLocationState input = ((ServiceGrainBingLocationState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            ServiceGrainBingLocationState result = new ServiceGrainBingLocationState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Cloudrocket.Grains.Cloudrocket.Grains.ServiceGrainPayPal")]
    public class ServiceGrainPayPalState : global::Orleans.CodeGeneration.GrainState, IServiceGrainPayPalState
    {
        

            public Payment @Payment { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Payment", out value)) @Payment = (Payment) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("ServiceGrainPayPalState( Payment={0} )", @Payment);
            }
        
        public ServiceGrainPayPalState() : 
                base("Cloudrocket.Grains.ServiceGrainPayPal")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Payment"] = this.Payment;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Payment = new Payment();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            ServiceGrainPayPalState input = ((ServiceGrainPayPalState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            ServiceGrainPayPalState input = ((ServiceGrainPayPalState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            ServiceGrainPayPalState result = new ServiceGrainPayPalState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Cloudrocket.Grains.Cloudrocket.Grains.ServiceGrainSendGrid")]
    public class ServiceGrainSendGridState : global::Orleans.CodeGeneration.GrainState, IServiceGrainSendGridState
    {
        

            public EmailMessage @EmailMessage { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("EmailMessage", out value)) @EmailMessage = (EmailMessage) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("ServiceGrainSendGridState( EmailMessage={0} )", @EmailMessage);
            }
        
        public ServiceGrainSendGridState() : 
                base("Cloudrocket.Grains.ServiceGrainSendGrid")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["EmailMessage"] = this.EmailMessage;
            return result;
        }
        
        private void InitStateFields()
        {
            this.EmailMessage = new EmailMessage();
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            ServiceGrainSendGridState input = ((ServiceGrainSendGridState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            ServiceGrainSendGridState input = ((ServiceGrainSendGridState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            ServiceGrainSendGridState result = new ServiceGrainSendGridState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HQOrderEntryImplementation.HQProductServiceASMXClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HQProductServiceASMXClient.HQProductServiceASMXSoap")]
    public interface HQProductServiceASMXSoap {
        
        // CODEGEN: Generating message contract since element name productID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsProductAvailableForCountry", ReplyAction="*")]
        HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse IsProductAvailableForCountry(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsProductAvailableForCountry", ReplyAction="*")]
        System.Threading.Tasks.Task<HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse> IsProductAvailableForCountryAsync(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsProductAvailableForCountryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsProductAvailableForCountry", Namespace="http://tempuri.org/", Order=0)]
        public HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody Body;
        
        public IsProductAvailableForCountryRequest() {
        }
        
        public IsProductAvailableForCountryRequest(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsProductAvailableForCountryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string productID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string countryCode;
        
        public IsProductAvailableForCountryRequestBody() {
        }
        
        public IsProductAvailableForCountryRequestBody(string productID, string countryCode) {
            this.productID = productID;
            this.countryCode = countryCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsProductAvailableForCountryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsProductAvailableForCountryResponse", Namespace="http://tempuri.org/", Order=0)]
        public HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponseBody Body;
        
        public IsProductAvailableForCountryResponse() {
        }
        
        public IsProductAvailableForCountryResponse(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsProductAvailableForCountryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool IsProductAvailableForCountryResult;
        
        public IsProductAvailableForCountryResponseBody() {
        }
        
        public IsProductAvailableForCountryResponseBody(bool IsProductAvailableForCountryResult) {
            this.IsProductAvailableForCountryResult = IsProductAvailableForCountryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HQProductServiceASMXSoapChannel : HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HQProductServiceASMXSoapClient : System.ServiceModel.ClientBase<HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap>, HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap {
        
        public HQProductServiceASMXSoapClient() {
        }
        
        public HQProductServiceASMXSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HQProductServiceASMXSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HQProductServiceASMXSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HQProductServiceASMXSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap.IsProductAvailableForCountry(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request) {
            return base.Channel.IsProductAvailableForCountry(request);
        }
        
        public bool IsProductAvailableForCountry(string productID, string countryCode) {
            HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest inValue = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest();
            inValue.Body = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody();
            inValue.Body.productID = productID;
            inValue.Body.countryCode = countryCode;
            HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse retVal = ((HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap)(this)).IsProductAvailableForCountry(inValue);
            return retVal.Body.IsProductAvailableForCountryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse> HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap.IsProductAvailableForCountryAsync(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request) {
            return base.Channel.IsProductAvailableForCountryAsync(request);
        }
        
        public System.Threading.Tasks.Task<HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse> IsProductAvailableForCountryAsync(string productID, string countryCode) {
            HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest inValue = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest();
            inValue.Body = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody();
            inValue.Body.productID = productID;
            inValue.Body.countryCode = countryCode;
            return ((HQOrderEntryImplementation.HQProductServiceASMXClient.HQProductServiceASMXSoap)(this)).IsProductAvailableForCountryAsync(inValue);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.MyServicesRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServicesRef.IMyServices")]
    public interface IMyServices {
        
        // CODEGEN: Generating message contract since the operation GetEmployeeInfo is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyServices/GetEmployeeInfo", ReplyAction="http://tempuri.org/IMyServices/GetEmployeeInfoResponse")]
        WebClient.MyServicesRef.EmployeeInfo GetEmployeeInfo(WebClient.MyServicesRef.GetEmployeeInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyServices/GetEmployeeInfo", ReplyAction="http://tempuri.org/IMyServices/GetEmployeeInfoResponse")]
        System.Threading.Tasks.Task<WebClient.MyServicesRef.EmployeeInfo> GetEmployeeInfoAsync(WebClient.MyServicesRef.GetEmployeeInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEmployeeInfoRequest {
        
        public GetEmployeeInfoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EmployeeInfo {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string VerificationKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Name;
        
        public EmployeeInfo() {
        }
        
        public EmployeeInfo(string VerificationKey, string Name) {
            this.VerificationKey = VerificationKey;
            this.Name = Name;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServicesChannel : WebClient.MyServicesRef.IMyServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServicesClient : System.ServiceModel.ClientBase<WebClient.MyServicesRef.IMyServices>, WebClient.MyServicesRef.IMyServices {
        
        public MyServicesClient() {
        }
        
        public MyServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.MyServicesRef.EmployeeInfo WebClient.MyServicesRef.IMyServices.GetEmployeeInfo(WebClient.MyServicesRef.GetEmployeeInfoRequest request) {
            return base.Channel.GetEmployeeInfo(request);
        }
        
        public string GetEmployeeInfo(out string Name) {
            WebClient.MyServicesRef.GetEmployeeInfoRequest inValue = new WebClient.MyServicesRef.GetEmployeeInfoRequest();
            WebClient.MyServicesRef.EmployeeInfo retVal = ((WebClient.MyServicesRef.IMyServices)(this)).GetEmployeeInfo(inValue);
            Name = retVal.Name;
            return retVal.VerificationKey;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.MyServicesRef.EmployeeInfo> WebClient.MyServicesRef.IMyServices.GetEmployeeInfoAsync(WebClient.MyServicesRef.GetEmployeeInfoRequest request) {
            return base.Channel.GetEmployeeInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.MyServicesRef.EmployeeInfo> GetEmployeeInfoAsync() {
            WebClient.MyServicesRef.GetEmployeeInfoRequest inValue = new WebClient.MyServicesRef.GetEmployeeInfoRequest();
            return ((WebClient.MyServicesRef.IMyServices)(this)).GetEmployeeInfoAsync(inValue);
        }
    }
}
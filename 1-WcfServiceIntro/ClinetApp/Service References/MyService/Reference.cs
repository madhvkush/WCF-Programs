//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinetApp.MyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Welcome", ReplyAction="http://tempuri.org/IMyService/WelcomeResponse")]
        string Welcome();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Welcome", ReplyAction="http://tempuri.org/IMyService/WelcomeResponse")]
        System.Threading.Tasks.Task<string> WelcomeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/MyName", ReplyAction="http://tempuri.org/IMyService/MyNameResponse")]
        string MyName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/MyName", ReplyAction="http://tempuri.org/IMyService/MyNameResponse")]
        System.Threading.Tasks.Task<string> MyNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : ClinetApp.MyService.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<ClinetApp.MyService.IMyService>, ClinetApp.MyService.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Welcome() {
            return base.Channel.Welcome();
        }
        
        public System.Threading.Tasks.Task<string> WelcomeAsync() {
            return base.Channel.WelcomeAsync();
        }
        
        public string MyName(string name) {
            return base.Channel.MyName(name);
        }
        
        public System.Threading.Tasks.Task<string> MyNameAsync(string name) {
            return base.Channel.MyNameAsync(name);
        }
    }
}

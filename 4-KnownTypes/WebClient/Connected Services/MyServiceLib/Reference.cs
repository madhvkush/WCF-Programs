﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.MyServiceLib {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/_4_KnownTypes")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebClient.MyServiceLib.Employee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebClient.MyServiceLib.EndUser))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/_4_KnownTypes")]
    [System.SerializableAttribute()]
    public partial class Employee : WebClient.MyServiceLib.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpCode {
            get {
                return this.EmpCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpCodeField, value) != true)) {
                    this.EmpCodeField = value;
                    this.RaisePropertyChanged("EmpCode");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EndUser", Namespace="http://schemas.datacontract.org/2004/07/_4_KnownTypes")]
    [System.SerializableAttribute()]
    public partial class EndUser : WebClient.MyServiceLib.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceLib.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetPerson", ReplyAction="http://tempuri.org/IMyService/GetPersonResponse")]
        WebClient.MyServiceLib.Person GetPerson(WebClient.MyServiceLib.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetPerson", ReplyAction="http://tempuri.org/IMyService/GetPersonResponse")]
        System.Threading.Tasks.Task<WebClient.MyServiceLib.Person> GetPersonAsync(WebClient.MyServiceLib.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : WebClient.MyServiceLib.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<WebClient.MyServiceLib.IMyService>, WebClient.MyServiceLib.IMyService {
        
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
        
        public WebClient.MyServiceLib.Person GetPerson(WebClient.MyServiceLib.Person person) {
            return base.Channel.GetPerson(person);
        }
        
        public System.Threading.Tasks.Task<WebClient.MyServiceLib.Person> GetPersonAsync(WebClient.MyServiceLib.Person person) {
            return base.Channel.GetPersonAsync(person);
        }
    }
}

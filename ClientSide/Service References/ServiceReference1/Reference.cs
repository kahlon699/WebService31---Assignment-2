﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientSide.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertToArray", ReplyAction="http://tempuri.org/IService1/ConvertToArrayResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebService31.MyError), Action="http://tempuri.org/IService1/ConvertToArrayMyErrorFault", Name="MyError", Namespace="http://schemas.datacontract.org/2004/07/WebService31")]
        string[] ConvertToArray(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertToArray", ReplyAction="http://tempuri.org/IService1/ConvertToArrayResponse")]
        System.Threading.Tasks.Task<string[]> ConvertToArrayAsync(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertToUpperCase", ReplyAction="http://tempuri.org/IService1/ConvertToUpperCaseResponse")]
        string ConvertToUpperCase(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertToUpperCase", ReplyAction="http://tempuri.org/IService1/ConvertToUpperCaseResponse")]
        System.Threading.Tasks.Task<string> ConvertToUpperCaseAsync(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LengthOfString", ReplyAction="http://tempuri.org/IService1/LengthOfStringResponse")]
        int LengthOfString(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LengthOfString", ReplyAction="http://tempuri.org/IService1/LengthOfStringResponse")]
        System.Threading.Tasks.Task<int> LengthOfStringAsync(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordLengths", ReplyAction="http://tempuri.org/IService1/WordLengthsResponse")]
        WebService31.CustomClass[] WordLengths(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordLengths", ReplyAction="http://tempuri.org/IService1/WordLengthsResponse")]
        System.Threading.Tasks.Task<WebService31.CustomClass[]> WordLengthsAsync(string str);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientSide.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientSide.ServiceReference1.IService1>, ClientSide.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ConvertToArray(string str) {
            return base.Channel.ConvertToArray(str);
        }
        
        public System.Threading.Tasks.Task<string[]> ConvertToArrayAsync(string str) {
            return base.Channel.ConvertToArrayAsync(str);
        }
        
        public string ConvertToUpperCase(string str) {
            return base.Channel.ConvertToUpperCase(str);
        }
        
        public System.Threading.Tasks.Task<string> ConvertToUpperCaseAsync(string str) {
            return base.Channel.ConvertToUpperCaseAsync(str);
        }
        
        public int LengthOfString(string str) {
            return base.Channel.LengthOfString(str);
        }
        
        public System.Threading.Tasks.Task<int> LengthOfStringAsync(string str) {
            return base.Channel.LengthOfStringAsync(str);
        }
        
        public WebService31.CustomClass[] WordLengths(string str) {
            return base.Channel.WordLengths(str);
        }
        
        public System.Threading.Tasks.Task<WebService31.CustomClass[]> WordLengthsAsync(string str) {
            return base.Channel.WordLengthsAsync(str);
        }
    }
}

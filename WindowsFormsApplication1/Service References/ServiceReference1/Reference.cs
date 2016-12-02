﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DatePerHour", Namespace="http://schemas.datacontract.org/2004/07/SmartH2O_Service")]
    [System.SerializableAttribute()]
    public partial class DatePerHour : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string valueField;
        
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
        public string hour {
            get {
                return this.hourField;
            }
            set {
                if ((object.ReferenceEquals(this.hourField, value) != true)) {
                    this.hourField = value;
                    this.RaisePropertyChanged("hour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string value {
            get {
                return this.valueField;
            }
            set {
                if ((object.ReferenceEquals(this.valueField, value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.SmartH20Service")]
    public interface SmartH20Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartH20Service/GetHourlyInSpecificDay", ReplyAction="http://tempuri.org/SmartH20Service/GetHourlyInSpecificDayResponse")]
        WindowsFormsApplication1.ServiceReference1.DatePerHour[] GetHourlyInSpecificDay(string year, string month, string day, string parameter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SmartH20Service/GetHourlyInSpecificDay", ReplyAction="http://tempuri.org/SmartH20Service/GetHourlyInSpecificDayResponse")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.DatePerHour[]> GetHourlyInSpecificDayAsync(string year, string month, string day, string parameter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SmartH20ServiceChannel : WindowsFormsApplication1.ServiceReference1.SmartH20Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmartH20ServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.SmartH20Service>, WindowsFormsApplication1.ServiceReference1.SmartH20Service {
        
        public SmartH20ServiceClient() {
        }
        
        public SmartH20ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SmartH20ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartH20ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmartH20ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApplication1.ServiceReference1.DatePerHour[] GetHourlyInSpecificDay(string year, string month, string day, string parameter) {
            return base.Channel.GetHourlyInSpecificDay(year, month, day, parameter);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.DatePerHour[]> GetHourlyInSpecificDayAsync(string year, string month, string day, string parameter) {
            return base.Channel.GetHourlyInSpecificDayAsync(year, month, day, parameter);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyVacationWorkflow.HolidayBroker {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Holiday", Namespace="http://schemas.datacontract.org/2004/07/HolidayBrokerService")]
    [System.SerializableAttribute()]
    public partial class Holiday : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationAirportField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HotelNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginAirportField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DestinationAirport {
            get {
                return this.DestinationAirportField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationAirportField, value) != true)) {
                    this.DestinationAirportField = value;
                    this.RaisePropertyChanged("DestinationAirport");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DestinationCity {
            get {
                return this.DestinationCityField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationCityField, value) != true)) {
                    this.DestinationCityField = value;
                    this.RaisePropertyChanged("DestinationCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HotelName {
            get {
                return this.HotelNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelNameField, value) != true)) {
                    this.HotelNameField = value;
                    this.RaisePropertyChanged("HotelName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginAirport {
            get {
                return this.OriginAirportField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginAirportField, value) != true)) {
                    this.OriginAirportField = value;
                    this.RaisePropertyChanged("OriginAirport");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HolidayBroker.IHolidayBroker")]
    public interface IHolidayBroker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHolidayBroker/GetHolidayOptions", ReplyAction="http://tempuri.org/IHolidayBroker/GetHolidayOptionsResponse")]
        MyVacationWorkflow.HolidayBroker.GetHolidayOptionsResponse GetHolidayOptions(MyVacationWorkflow.HolidayBroker.GetHolidayOptionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHolidayBroker/GetHolidayOptions", ReplyAction="http://tempuri.org/IHolidayBroker/GetHolidayOptionsResponse")]
        System.Threading.Tasks.Task<MyVacationWorkflow.HolidayBroker.GetHolidayOptionsResponse> GetHolidayOptionsAsync(MyVacationWorkflow.HolidayBroker.GetHolidayOptionsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetHolidayOptions", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetHolidayOptionsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.DateTime startDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.DateTime endDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int budget;
        
        public GetHolidayOptionsRequest() {
        }
        
        public GetHolidayOptionsRequest(System.DateTime startDate, System.DateTime endDate, int budget) {
            this.startDate = startDate;
            this.endDate = endDate;
            this.budget = budget;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetHolidayOptionsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetHolidayOptionsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public MyVacationWorkflow.HolidayBroker.Holiday[] GetHolidayOptionsResult;
        
        public GetHolidayOptionsResponse() {
        }
        
        public GetHolidayOptionsResponse(MyVacationWorkflow.HolidayBroker.Holiday[] GetHolidayOptionsResult) {
            this.GetHolidayOptionsResult = GetHolidayOptionsResult;
        }
    }
}

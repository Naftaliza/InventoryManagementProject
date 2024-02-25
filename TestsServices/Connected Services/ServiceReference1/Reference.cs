﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestsServices.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InventoryItem", Namespace="http://schemas.datacontract.org/2004/07/WCFProject")]
    [System.SerializableAttribute()]
    public partial class InventoryItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IInventoryService")]
    public interface IInventoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/AddInventoryItemResponse")]
        int AddInventoryItem(TestsServices.ServiceReference1.InventoryItem item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/AddInventoryItemResponse")]
        System.Threading.Tasks.Task<int> AddInventoryItemAsync(TestsServices.ServiceReference1.InventoryItem item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/GetInventoryItemResponse")]
        TestsServices.ServiceReference1.InventoryItem GetInventoryItem(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/GetInventoryItemResponse")]
        System.Threading.Tasks.Task<TestsServices.ServiceReference1.InventoryItem> GetInventoryItemAsync(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/UpdateInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/UpdateInventoryItemResponse")]
        void UpdateInventoryItem(TestsServices.ServiceReference1.InventoryItem item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/UpdateInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/UpdateInventoryItemResponse")]
        System.Threading.Tasks.Task UpdateInventoryItemAsync(TestsServices.ServiceReference1.InventoryItem item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/DeleteInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/DeleteInventoryItemResponse")]
        void DeleteInventoryItem(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/DeleteInventoryItem", ReplyAction="http://tempuri.org/IInventoryService/DeleteInventoryItemResponse")]
        System.Threading.Tasks.Task DeleteInventoryItemAsync(int itemId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryServiceChannel : TestsServices.ServiceReference1.IInventoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryServiceClient : System.ServiceModel.ClientBase<TestsServices.ServiceReference1.IInventoryService>, TestsServices.ServiceReference1.IInventoryService {
        
        public InventoryServiceClient() {
        }
        
        public InventoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddInventoryItem(TestsServices.ServiceReference1.InventoryItem item) {
            return base.Channel.AddInventoryItem(item);
        }
        
        public System.Threading.Tasks.Task<int> AddInventoryItemAsync(TestsServices.ServiceReference1.InventoryItem item) {
            return base.Channel.AddInventoryItemAsync(item);
        }
        
        public TestsServices.ServiceReference1.InventoryItem GetInventoryItem(int itemId) {
            return base.Channel.GetInventoryItem(itemId);
        }
        
        public System.Threading.Tasks.Task<TestsServices.ServiceReference1.InventoryItem> GetInventoryItemAsync(int itemId) {
            return base.Channel.GetInventoryItemAsync(itemId);
        }
        
        public void UpdateInventoryItem(TestsServices.ServiceReference1.InventoryItem item) {
            base.Channel.UpdateInventoryItem(item);
        }
        
        public System.Threading.Tasks.Task UpdateInventoryItemAsync(TestsServices.ServiceReference1.InventoryItem item) {
            return base.Channel.UpdateInventoryItemAsync(item);
        }
        
        public void DeleteInventoryItem(int itemId) {
            base.Channel.DeleteInventoryItem(itemId);
        }
        
        public System.Threading.Tasks.Task DeleteInventoryItemAsync(int itemId) {
            return base.Channel.DeleteInventoryItemAsync(itemId);
        }
    }
}
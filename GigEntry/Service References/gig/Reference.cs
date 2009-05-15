﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigEntry.gig {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LinkItem", Namespace="http://schemas.datacontract.org/2004/07/ContentTypes")]
    [System.SerializableAttribute()]
    public partial class LinkItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateEndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateStartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrlField;
        
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
        public System.DateTime DateEnd {
            get {
                return this.DateEndField;
            }
            set {
                if ((this.DateEndField.Equals(value) != true)) {
                    this.DateEndField = value;
                    this.RaisePropertyChanged("DateEnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateStart {
            get {
                return this.DateStartField;
            }
            set {
                if ((this.DateStartField.Equals(value) != true)) {
                    this.DateStartField = value;
                    this.RaisePropertyChanged("DateStart");
                }
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
        public long Id {
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
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Url {
            get {
                return this.UrlField;
            }
            set {
                if ((object.ReferenceEquals(this.UrlField, value) != true)) {
                    this.UrlField = value;
                    this.RaisePropertyChanged("Url");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.thatindigogirl.com/samples/2006/06", ConfigurationName="gig.GigManagerServiceContract", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface GigManagerServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/GigManagerServiceContract/SaveGig", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/GigManagerServiceContract/SaveGigRe" +
            "sponse")]
        void SaveGig(GigEntry.gig.LinkItem item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.thatindigogirl.com/samples/2006/06/GigManagerServiceContract/GetGig", ReplyAction="http://www.thatindigogirl.com/samples/2006/06/GigManagerServiceContract/GetGigRes" +
            "ponse")]
        GigEntry.gig.LinkItem GetGig();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface GigManagerServiceContractChannel : GigEntry.gig.GigManagerServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GigManagerServiceContractClient : System.ServiceModel.ClientBase<GigEntry.gig.GigManagerServiceContract>, GigEntry.gig.GigManagerServiceContract {
        
        public GigManagerServiceContractClient() {
        }
        
        public GigManagerServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GigManagerServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GigManagerServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GigManagerServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveGig(GigEntry.gig.LinkItem item) {
            base.Channel.SaveGig(item);
        }
        
        public GigEntry.gig.LinkItem GetGig() {
            return base.Channel.GetGig();
        }
    }
}
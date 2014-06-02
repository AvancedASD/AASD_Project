﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.AASDServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AASD_Contracts/WebService", ConfigurationName="AASDServiceReference.IAASDService")]
    public interface IAASDService {
        
        // CODEGEN: Generating message contract since the operation RetrieveSearch is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="AASD_Contracts/WebService/IAASDService/RetrieveSearch", ReplyAction="AASD_Contracts/WebService/IAASDService/RetrieveSearchResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Test.AASDServiceReference.RetrieveSearchResponse RetrieveSearch(Test.AASDServiceReference.RetrieveSearchRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AASD_Contracts/WebService/IAASDService/RetrieveSearch", ReplyAction="AASD_Contracts/WebService/IAASDService/RetrieveSearchResponse")]
        System.Threading.Tasks.Task<Test.AASDServiceReference.RetrieveSearchResponse> RetrieveSearchAsync(Test.AASDServiceReference.RetrieveSearchRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="AASD_Contracts/Message")]
    public partial class RetrieveSearchRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private QueryContract requestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public QueryContract Request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
                this.RaisePropertyChanged("Request");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="AASD_Contracts/Data")]
    public partial class QueryContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string queryField;
        
        private string optionsField;
        
        private string webSearchOptionsField;
        
        private string marketField;
        
        private string adultField;
        
        private string latitudeField;
        
        private string longitudeField;
        
        private string webFileTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Query {
            get {
                return this.queryField;
            }
            set {
                this.queryField = value;
                this.RaisePropertyChanged("Query");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
                this.RaisePropertyChanged("Options");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string WebSearchOptions {
            get {
                return this.webSearchOptionsField;
            }
            set {
                this.webSearchOptionsField = value;
                this.RaisePropertyChanged("WebSearchOptions");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string Market {
            get {
                return this.marketField;
            }
            set {
                this.marketField = value;
                this.RaisePropertyChanged("Market");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string Adult {
            get {
                return this.adultField;
            }
            set {
                this.adultField = value;
                this.RaisePropertyChanged("Adult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
                this.RaisePropertyChanged("Latitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
                this.RaisePropertyChanged("Longitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string WebFileType {
            get {
                return this.webFileTypeField;
            }
            set {
                this.webFileTypeField = value;
                this.RaisePropertyChanged("WebFileType");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="AASD_Contracts/Data")]
    public partial class ResultContract : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string titleField;
        
        private string descriptionField;
        
        private string displayUrlField;
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string DisplayUrl {
            get {
                return this.displayUrlField;
            }
            set {
                this.displayUrlField = value;
                this.RaisePropertyChanged("DisplayUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("Url");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetrieveSearchRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AASD_Contracts/Message", Order=0)]
        public Test.AASDServiceReference.RetrieveSearchRequest RetrieveSearchRequest;
        
        public RetrieveSearchRequest1() {
        }
        
        public RetrieveSearchRequest1(Test.AASDServiceReference.RetrieveSearchRequest RetrieveSearchRequest) {
            this.RetrieveSearchRequest = RetrieveSearchRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetrieveSearchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AASD_Contracts/Message", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Response", IsNullable=false)]
        public Test.AASDServiceReference.ResultContract[] listResultContract;
        
        public RetrieveSearchResponse() {
        }
        
        public RetrieveSearchResponse(Test.AASDServiceReference.ResultContract[] listResultContract) {
            this.listResultContract = listResultContract;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAASDServiceChannel : Test.AASDServiceReference.IAASDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AASDServiceClient : System.ServiceModel.ClientBase<Test.AASDServiceReference.IAASDService>, Test.AASDServiceReference.IAASDService {
        
        public AASDServiceClient() {
        }
        
        public AASDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AASDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AASDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AASDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Test.AASDServiceReference.RetrieveSearchResponse Test.AASDServiceReference.IAASDService.RetrieveSearch(Test.AASDServiceReference.RetrieveSearchRequest1 request) {
            return base.Channel.RetrieveSearch(request);
        }
        
        public Test.AASDServiceReference.ResultContract[] RetrieveSearch(Test.AASDServiceReference.RetrieveSearchRequest RetrieveSearchRequest) {
            Test.AASDServiceReference.RetrieveSearchRequest1 inValue = new Test.AASDServiceReference.RetrieveSearchRequest1();
            inValue.RetrieveSearchRequest = RetrieveSearchRequest;
            Test.AASDServiceReference.RetrieveSearchResponse retVal = ((Test.AASDServiceReference.IAASDService)(this)).RetrieveSearch(inValue);
            return retVal.listResultContract;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Test.AASDServiceReference.RetrieveSearchResponse> Test.AASDServiceReference.IAASDService.RetrieveSearchAsync(Test.AASDServiceReference.RetrieveSearchRequest1 request) {
            return base.Channel.RetrieveSearchAsync(request);
        }
        
        public System.Threading.Tasks.Task<Test.AASDServiceReference.RetrieveSearchResponse> RetrieveSearchAsync(Test.AASDServiceReference.RetrieveSearchRequest RetrieveSearchRequest) {
            Test.AASDServiceReference.RetrieveSearchRequest1 inValue = new Test.AASDServiceReference.RetrieveSearchRequest1();
            inValue.RetrieveSearchRequest = RetrieveSearchRequest;
            return ((Test.AASDServiceReference.IAASDService)(this)).RetrieveSearchAsync(inValue);
        }
    }
}

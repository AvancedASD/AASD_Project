using AASD_ServiceLayer.DataContract;


namespace AASD_ServiceLayer.MessageContract
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="AASD_Contracts/Message", TypeName="RetrieveSearchRequest")]
    public partial class RetrieveSearchRequest : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private QueryContract requestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0, ElementName="Request")]
        public QueryContract Request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
                this.RaisePropertyChanged("Request");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

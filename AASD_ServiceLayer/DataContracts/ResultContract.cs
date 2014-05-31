namespace AASD_ServiceLayer
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="AASD_Contracts/Data", TypeName="ResultContract")]
    public partial class ResultContract : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string titleField;
        
        private string descriptionField;
        
        private string displayUrlField;
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0, ElementName="Title")]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1, ElementName="Description")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2, ElementName="DisplayUrl")]
        public string DisplayUrl
        {
            get
            {
                return this.displayUrlField;
            }
            set
            {
                this.displayUrlField = value;
                this.RaisePropertyChanged("DisplayUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3, ElementName="Url")]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
                this.RaisePropertyChanged("Url");
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

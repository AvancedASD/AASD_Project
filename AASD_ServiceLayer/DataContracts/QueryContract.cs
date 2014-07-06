namespace AASD_ServiceLayer.DataContract
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "AASD_Contracts/Data", TypeName = "QueryContract")]
    public partial class QueryContract : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string queryField;

        private string contextField;

        private string optionsField;

        private string webSearchOptionsField;

        private string marketField;

        private string adultField;

        private string latitudeField;

        private string longitudeField;

        private string webFileTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "Query")]
        public string Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
                this.RaisePropertyChanged("Query");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1, ElementName = "Context")]
        public string Context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
                this.RaisePropertyChanged("Context");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2, ElementName = "Options")]
        public string Options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
                this.RaisePropertyChanged("Options");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3, ElementName = "WebSearchOptions")]
        public string WebSearchOptions
        {
            get
            {
                return this.webSearchOptionsField;
            }
            set
            {
                this.webSearchOptionsField = value;
                this.RaisePropertyChanged("WebSearchOptions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4, ElementName = "Market")]
        public string Market
        {
            get
            {
                return this.marketField;
            }
            set
            {
                this.marketField = value;
                this.RaisePropertyChanged("Market");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5, ElementName = "Adult")]
        public string Adult
        {
            get
            {
                return this.adultField;
            }
            set
            {
                this.adultField = value;
                this.RaisePropertyChanged("Adult");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6, ElementName = "Latitude")]
        public string Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
                this.RaisePropertyChanged("Latitude");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7, ElementName = "Longitude")]
        public string Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
                this.RaisePropertyChanged("Longitude");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8, ElementName = "WebFileType")]
        public string WebFileType
        {
            get
            {
                return this.webFileTypeField;
            }
            set
            {
                this.webFileTypeField = value;
                this.RaisePropertyChanged("WebFileType");
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

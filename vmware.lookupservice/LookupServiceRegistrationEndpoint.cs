using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DebuggerStepThrough]
    [XmlType(Namespace = "urn:lookup")]
    [DesignerCategory("code")]
    [Serializable]
    public class LookupServiceRegistrationEndpoint : DynamicData
    {
        private string urlField;
        private LookupServiceRegistrationEndpointType endpointTypeField;
        private string[] sslTrustField;
        private LookupServiceRegistrationAttribute[] endpointAttributesField;

        [XmlElement(DataType = "anyURI", Order = 0)]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        [XmlElement(Order = 1)]
        public LookupServiceRegistrationEndpointType endpointType
        {
            get
            {
                return this.endpointTypeField;
            }
            set
            {
                this.endpointTypeField = value;
            }
        }

        [XmlElement("sslTrust", Order = 2)]
        public string[] sslTrust
        {
            get
            {
                return this.sslTrustField;
            }
            set
            {
                this.sslTrustField = value;
            }
        }

        [XmlElement("endpointAttributes", Order = 3)]
        public LookupServiceRegistrationAttribute[] endpointAttributes
        {
            get
            {
                return this.endpointAttributesField;
            }
            set
            {
                this.endpointAttributesField = value;
            }
        }
    }
}

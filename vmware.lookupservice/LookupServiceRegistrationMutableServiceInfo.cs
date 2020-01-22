using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(LookupServiceRegistrationInfo))]
    [XmlInclude(typeof(LookupServiceRegistrationCreateSpec))]
    [XmlInclude(typeof(LookupServiceRegistrationCommonServiceInfo))]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [DebuggerStepThrough]    
    [XmlInclude(typeof(LookupServiceRegistrationSetSpec))]
    [Serializable]
    public class LookupServiceRegistrationMutableServiceInfo: DynamicData
    {
        private string serviceVersionField;
        private string vendorNameResourceKeyField;
        private string vendorNameDefaultField;
        private string vendorProductInfoResourceKeyField;
        private string vendorProductInfoDefaultField;
        private LookupServiceRegistrationEndpoint[] serviceEndpointsField;
        private LookupServiceRegistrationAttribute[] serviceAttributesField;
        private string serviceNameResourceKeyField;
        private string serviceNameDefaultField;
        private string serviceDescriptionResourceKeyField;
        private string serviceDescriptionDefaultField;

        [XmlElement(Order = 0)]
        public string serviceVersion
        {
            get
            {
                return this.serviceVersionField;
            }
            set
            {
                this.serviceVersionField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string vendorNameResourceKey
        {
            get
            {
                return this.vendorNameResourceKeyField;
            }
            set
            {
                this.vendorNameResourceKeyField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string vendorNameDefault
        {
            get
            {
                return this.vendorNameDefaultField;
            }
            set
            {
                this.vendorNameDefaultField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string vendorProductInfoResourceKey
        {
            get
            {
                return this.vendorProductInfoResourceKeyField;
            }
            set
            {
                this.vendorProductInfoResourceKeyField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string vendorProductInfoDefault
        {
            get
            {
                return this.vendorProductInfoDefaultField;
            }
            set
            {
                this.vendorProductInfoDefaultField = value;
            }
        }

        [XmlElement("serviceEndpoints", Order = 5)]
        public LookupServiceRegistrationEndpoint[] serviceEndpoints
        {
            get
            {
                return this.serviceEndpointsField;
            }
            set
            {
                this.serviceEndpointsField = value;
            }
        }

        [XmlElement("serviceAttributes", Order = 6)]
        public LookupServiceRegistrationAttribute[] serviceAttributes
        {
            get
            {
                return this.serviceAttributesField;
            }
            set
            {
                this.serviceAttributesField = value;
            }
        }

        [XmlElement(Order = 7)]
        public string serviceNameResourceKey
        {
            get
            {
                return this.serviceNameResourceKeyField;
            }
            set
            {
                this.serviceNameResourceKeyField = value;
            }
        }

        [XmlElement(Order = 8)]
        public string serviceNameDefault
        {
            get
            {
                return this.serviceNameDefaultField;
            }
            set
            {
                this.serviceNameDefaultField = value;
            }
        }

        [XmlElement(Order = 9)]
        public string serviceDescriptionResourceKey
        {
            get
            {
                return this.serviceDescriptionResourceKeyField;
            }
            set
            {
                this.serviceDescriptionResourceKeyField = value;
            }
        }

        [XmlElement(Order = 10)]
        public string serviceDescriptionDefault
        {
            get
            {
                return this.serviceDescriptionDefaultField;
            }
            set
            {
                this.serviceDescriptionDefaultField = value;
            }
        }
    }
}

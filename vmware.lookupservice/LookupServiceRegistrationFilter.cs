using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [DebuggerStepThrough]    
    [Serializable]
    public class LookupServiceRegistrationFilter : DynamicData
    {
        private string siteIdField;
        private string nodeIdField;
        private LookupServiceRegistrationServiceType serviceTypeField;
        private LookupServiceRegistrationEndpointType endpointTypeField;

        [XmlElement(Order = 0)]
        public string siteId
        {
            get
            {
                return this.siteIdField;
            }
            set
            {
                this.siteIdField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string nodeId
        {
            get
            {
                return this.nodeIdField;
            }
            set
            {
                this.nodeIdField = value;
            }
        }

        [XmlElement(Order = 2)]
        public LookupServiceRegistrationServiceType serviceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        [XmlElement(Order = 3)]
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
    }
}

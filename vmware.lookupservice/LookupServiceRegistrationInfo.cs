using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    [XmlType(Namespace = "urn:lookup")]    
    [Serializable]
    public class LookupServiceRegistrationInfo : LookupServiceRegistrationCommonServiceInfo
    {
        private string serviceIdField;
        private string siteIdField;

        [XmlElement(Order = 0)]
        public string serviceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }

        [XmlElement(Order = 1)]
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
    }
}

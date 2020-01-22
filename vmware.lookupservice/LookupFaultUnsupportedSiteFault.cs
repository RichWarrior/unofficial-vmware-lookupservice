using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlType(Namespace = "urn:lookup")]    
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class LookupFaultUnsupportedSiteFault : LookupFaultServiceFault
    {
        private string operatingSiteField;
        private string requestedSiteField;

        [XmlElement(Order = 0)]
        public string operatingSite
        {
            get
            {
                return this.operatingSiteField;
            }
            set
            {
                this.operatingSiteField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string requestedSite
        {
            get
            {
                return this.requestedSiteField;
            }
            set
            {
                this.requestedSiteField = value;
            }
        }

    }
}

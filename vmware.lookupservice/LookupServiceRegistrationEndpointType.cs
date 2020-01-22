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
    public class LookupServiceRegistrationEndpointType : DynamicData
    {
        private string protocolField;
        private string typeField;

        [XmlElement(Order = 0)]
        public string protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
}

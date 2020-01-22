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
    public class LookupServiceRegistrationServiceType : DynamicData
    {
        private string productField;
        private string typeField;

        [XmlElement(Order = 0)]
        public string product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
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

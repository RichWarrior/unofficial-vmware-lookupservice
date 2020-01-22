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
    public class LookupServiceRegistrationAttribute : DynamicData
    {
        private string keyField;
        private string valueField;

        [XmlElement(Order = 0)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}

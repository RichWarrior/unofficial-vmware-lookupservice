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
    public class InvalidType : InvalidRequest
    {
        private string argumentField;

        [XmlElement(Order = 0)]
        public string argument
        {
            get
            {
                return this.argumentField;
            }
            set
            {
                this.argumentField = value;
            }
        }
    }
}

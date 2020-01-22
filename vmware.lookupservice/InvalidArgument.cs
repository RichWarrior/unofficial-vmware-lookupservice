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
    public class InvalidArgument : RuntimeFault
    {
        private string invalidPropertyField;

        [XmlElement(Order = 0)]
        public string invalidProperty
        {
            get
            {
                return this.invalidPropertyField;
            }
            set
            {
                this.invalidPropertyField = value;
            }
        }
    }
}

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
    public class UnexpectedFault : RuntimeFault
    {
        private string faultNameField;
        private LocalizedMethodFault faultField;

        [XmlElement(Order = 0)]
        public string faultName
        {
            get
            {
                return this.faultNameField;
            }
            set
            {
                this.faultNameField = value;
            }
        }

        [XmlElement(Order = 1)]
        public LocalizedMethodFault fault
        {
            get
            {
                return this.faultField;
            }
            set
            {
                this.faultField = value;
            }
        }
    }
}

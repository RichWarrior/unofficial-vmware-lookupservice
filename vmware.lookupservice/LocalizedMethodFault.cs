using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace vmware.lookupservice
{    
    [XmlType(Namespace = "urn:lookup")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class LocalizedMethodFault :DynamicData
    {
        private MethodFault faultField;
        private string localizedMessageField;

        [XmlElement(Order = 0)]
        public MethodFault fault
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

        [XmlElement(Order = 1)]
        public string localizedMessage
        {
            get
            {
                return this.localizedMessageField;
            }
            set
            {
                this.localizedMessageField = value;
            }
        }
    }
}

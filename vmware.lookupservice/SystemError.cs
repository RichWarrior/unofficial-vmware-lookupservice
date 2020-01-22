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
    public class SystemError : RuntimeFault
    {
        private string reasonField;

        [XmlElement(Order = 0)]
        public string reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }
}

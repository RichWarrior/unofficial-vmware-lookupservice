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
    public class MethodNotFound : InvalidRequest
    {
        private ManagedObjectReference receiverField;
        private string methodField;

        [XmlElement(Order = 0)]
        public ManagedObjectReference receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }
    }
}

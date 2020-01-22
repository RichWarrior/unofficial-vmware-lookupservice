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
    public class LocalizableMessage : DynamicData
    {
        private string keyField;
        private KeyAnyValue[] argField;
        private string messageField;

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

        [XmlElement("arg", Order = 1)]
        public KeyAnyValue[] arg
        {
            get
            {
                return this.argField;
            }
            set
            {
                this.argField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

    }
}

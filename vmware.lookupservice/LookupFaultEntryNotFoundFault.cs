using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DebuggerStepThrough]    
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [Serializable]
    public class LookupFaultEntryNotFoundFault : LookupFaultServiceFault
    {
        private string nameField;

        [XmlElement(Order = 0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}

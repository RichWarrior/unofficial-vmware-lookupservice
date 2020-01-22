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
    public class ManagedObjectNotFound : RuntimeFault
    {
        private ManagedObjectReference objField;

        [XmlElement(Order = 0)]
        public ManagedObjectReference obj
        {
            get
            {
                return this.objField;
            }
            set
            {
                this.objField = value;
            }
        }
    }
}

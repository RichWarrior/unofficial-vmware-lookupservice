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
    public  class RetrieveServiceContentRequestType
    {
        private ManagedObjectReference _thisField;

        [XmlElement(Order = 0)]
        public ManagedObjectReference _this
        {
            get
            {
                return this._thisField;
            }
            set
            {
                this._thisField = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]    
    [DebuggerStepThrough]
    [Serializable]
    public class GetLocaleRequestType
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

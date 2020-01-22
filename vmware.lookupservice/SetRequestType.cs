using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace vmware.lookupservice
{    
    [XmlType(Namespace = "urn:lookup")]
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    [Serializable]
    public class SetRequestType
    {
        private ManagedObjectReference _thisField;
        private string serviceIdField;
        private LookupServiceRegistrationSetSpec serviceSpecField;

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

        [XmlElement(Order = 1)]
        public string serviceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }

        [XmlElement(Order = 2)]
        public LookupServiceRegistrationSetSpec serviceSpec
        {
            get
            {
                return this.serviceSpecField;
            }
            set
            {
                this.serviceSpecField = value;
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    //[GeneratedCode("svcutil", "4.0.30319.33440")]
    [Serializable]
    public class CreateRequestType
    {
        private ManagedObjectReference _thisField;
        private string serviceIdField;
        private LookupServiceRegistrationCreateSpec createSpecField;

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
        public LookupServiceRegistrationCreateSpec createSpec
        {
            get
            {
                return this.createSpecField;
            }
            set
            {
                this.createSpecField = value;
            }
        }
    }
}

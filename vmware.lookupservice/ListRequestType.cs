using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    [XmlType(Namespace = "urn:lookup")]    
    [Serializable]
    public class ListRequestType
    {
        private ManagedObjectReference _thisField;
        private LookupServiceRegistrationFilter filterCriteriaField;

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
        public LookupServiceRegistrationFilter filterCriteria
        {
            get
            {
                return this.filterCriteriaField;
            }
            set
            {
                this.filterCriteriaField = value;
            }
        }
    }
}

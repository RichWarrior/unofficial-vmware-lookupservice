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
    public class LookupServiceContent : DynamicData
    {
        private ManagedObjectReference lookupServiceField;
        private ManagedObjectReference serviceRegistrationField;
        private ManagedObjectReference deploymentInformationServiceField;
        private ManagedObjectReference l10nField;

        [XmlElement(Order = 0)]
        public ManagedObjectReference lookupService
        {
            get
            {
                return this.lookupServiceField;
            }
            set
            {
                this.lookupServiceField = value;
            }
        }

        [XmlElement(Order = 1)]
        public ManagedObjectReference serviceRegistration
        {
            get
            {
                return this.serviceRegistrationField;
            }
            set
            {
                this.serviceRegistrationField = value;
            }
        }

        [XmlElement(Order = 2)]
        public ManagedObjectReference deploymentInformationService
        {
            get
            {
                return this.deploymentInformationServiceField;
            }
            set
            {
                this.deploymentInformationServiceField = value;
            }
        }

        [XmlElement(Order = 3)]
        public ManagedObjectReference l10n
        {
            get
            {
                return this.l10nField;
            }
            set
            {
                this.l10nField = value;
            }
        }
    }
}

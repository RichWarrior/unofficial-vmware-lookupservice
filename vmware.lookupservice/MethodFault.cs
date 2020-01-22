using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(MethodNotFound))]
    [XmlInclude(typeof(RequestCanceled))]
    [XmlInclude(typeof(NotSupported))]
    [XmlInclude(typeof(NotImplemented))]
    [XmlInclude(typeof(NotEnoughLicenses))]
    [XmlInclude(typeof(ManagedObjectNotFound))]
    [XmlInclude(typeof(InvalidRequest))]
    [XmlInclude(typeof(LookupFaultServiceFault))]
    [XmlInclude(typeof(InvalidType))]
    [XmlInclude(typeof(InvalidArgument))]
    [XmlInclude(typeof(HostCommunication))]
    [XmlInclude(typeof(HostNotReachable))]
    [XmlInclude(typeof(HostNotConnected))]    
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [XmlInclude(typeof(LookupFaultUnsupportedSiteFault))]
    [XmlInclude(typeof(LookupFaultEntryNotFoundFault))]
    [XmlInclude(typeof(LookupFaultEntryExistsFault))]
    [XmlInclude(typeof(RuntimeFault))]
    [XmlInclude(typeof(UnexpectedFault))]
    [XmlInclude(typeof(SystemError))]
    [XmlInclude(typeof(SecurityError))]
    [Serializable]
    public class MethodFault
    {
        private LocalizedMethodFault faultCauseField;
        private LocalizableMessage[] faultMessageField;

        [XmlElement(Order = 0)]
        public LocalizedMethodFault faultCause
        {
            get
            {
                return this.faultCauseField;
            }
            set
            {
                this.faultCauseField = value;
            }
        }

        [XmlElement("faultMessage", Order = 1)]
        public LocalizableMessage[] faultMessage
        {
            get
            {
                return this.faultMessageField;
            }
            set
            {
                this.faultMessageField = value;
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(NotEnoughLicenses))]
    [XmlInclude(typeof(ManagedObjectNotFound))]
    [XmlInclude(typeof(InvalidRequest))]
    [XmlInclude(typeof(MethodNotFound))]
    [XmlInclude(typeof(InvalidType))]
    [XmlInclude(typeof(InvalidArgument))]
    [XmlInclude(typeof(HostCommunication))]
    [XmlInclude(typeof(HostNotReachable))]
    [XmlInclude(typeof(HostNotConnected))]
    [XmlInclude(typeof(NotImplemented))]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [XmlInclude(typeof(UnexpectedFault))]
    [XmlInclude(typeof(SystemError))]
    [XmlInclude(typeof(SecurityError))]
    [XmlInclude(typeof(RequestCanceled))]
    [XmlInclude(typeof(NotSupported))]
    [Serializable]
    public class RuntimeFault : MethodFault
    {
    }
}

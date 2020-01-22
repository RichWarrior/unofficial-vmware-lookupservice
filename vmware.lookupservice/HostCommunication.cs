using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(HostNotConnected))]
    [XmlInclude(typeof(HostNotReachable))]
    [DebuggerStepThrough]
    [XmlType(Namespace = "urn:lookup")]
    [DesignerCategory("code")]
    [Serializable]
    public class HostCommunication : RuntimeFault
    {
    }
}

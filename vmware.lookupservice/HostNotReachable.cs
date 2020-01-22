using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [Serializable]
    public class HostNotReachable : HostCommunication
    {

    }
}

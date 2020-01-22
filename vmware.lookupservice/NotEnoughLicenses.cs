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
    public class NotEnoughLicenses : RuntimeFault
    {
    }
}

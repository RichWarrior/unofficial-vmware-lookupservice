using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(LookupFaultEntryExistsFault))]
    [DebuggerStepThrough]
    [XmlInclude(typeof(LookupFaultUnsupportedSiteFault))]
    [XmlInclude(typeof(LookupFaultEntryNotFoundFault))]
    [XmlType(Namespace = "urn:lookup")]    
    [DesignerCategory("code")]
    [Serializable]
    public class LookupFaultServiceFault : MethodFault
    {
    }
}

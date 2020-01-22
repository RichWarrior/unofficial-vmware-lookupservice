using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [XmlInclude(typeof(InvalidType))]
    [DebuggerStepThrough]
    [XmlInclude(typeof(MethodNotFound))]    
    [Serializable]
    public class InvalidRequest : RuntimeFault
    {

    }
}

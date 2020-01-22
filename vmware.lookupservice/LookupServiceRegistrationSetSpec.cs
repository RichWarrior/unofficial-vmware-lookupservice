using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlType(Namespace = "urn:lookup")]    
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [Serializable]
    public class LookupServiceRegistrationSetSpec : LookupServiceRegistrationMutableServiceInfo
    {
    }
}

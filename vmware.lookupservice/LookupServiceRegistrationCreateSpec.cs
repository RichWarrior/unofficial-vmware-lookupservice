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
    public class LookupServiceRegistrationCreateSpec : LookupServiceRegistrationCommonServiceInfo
    {

    }
}

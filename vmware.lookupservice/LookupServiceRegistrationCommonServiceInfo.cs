using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(LookupServiceRegistrationCreateSpec))]
    [XmlInclude(typeof(LookupServiceRegistrationInfo))]    
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [Serializable]
    public class LookupServiceRegistrationCommonServiceInfo : LookupServiceRegistrationMutableServiceInfo
    {
    }
}

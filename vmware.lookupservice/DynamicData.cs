using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlInclude(typeof(LookupServiceRegistrationFilter))]
    [XmlInclude(typeof(LookupServiceRegistrationEndpoint))]
    [XmlInclude(typeof(LookupServiceRegistrationCommonServiceInfo))]
    [XmlInclude(typeof(LookupServiceRegistrationInfo))]
    [XmlInclude(typeof(LookupServiceRegistrationCreateSpec))]
    [XmlInclude(typeof(LocalizedMethodFault))]
    [XmlInclude(typeof(LocalizableMessage))]
    [XmlInclude(typeof(KeyAnyValue))]    
    [XmlInclude(typeof(LookupServiceRegistrationEndpointType))]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:lookup")]
    [XmlInclude(typeof(LookupServiceRegistrationMutableServiceInfo))]
    [XmlInclude(typeof(LookupHaBackupNodeConfiguration))]
    [DebuggerStepThrough]
    [XmlInclude(typeof(LookupServiceRegistrationSetSpec))]
    [XmlInclude(typeof(LookupServiceContent))]
    [XmlInclude(typeof(LookupServiceRegistrationServiceType))]
    [XmlInclude(typeof(LookupServiceRegistrationAttribute))]
    [Serializable]
    public class DynamicData
    {
    }
}

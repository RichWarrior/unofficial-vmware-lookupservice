using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [DebuggerStepThrough]
    [MessageContract(IsWrapped = true, WrapperName = "ListResponse", WrapperNamespace = "urn:lookup")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class ListResponse
    {
        [MessageBodyMember(Namespace = "urn:lookup", Order = 0)]
        [XmlElement("returnval")]
        public LookupServiceRegistrationInfo[] returnval;

        public ListResponse()
        {
        }

        public ListResponse(LookupServiceRegistrationInfo[] returnval)
        {
            this.returnval = returnval;
        }
    }
}

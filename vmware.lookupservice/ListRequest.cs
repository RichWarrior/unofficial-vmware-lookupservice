using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace vmware.lookupservice
{

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerStepThrough]
    [MessageContract(IsWrapped = true, WrapperName = "List", WrapperNamespace = "urn:lookup")]
    public class ListRequest
    {
        [MessageBodyMember(Namespace = "urn:lookup", Order = 0)]
        public ManagedObjectReference _this;
        [MessageBodyMember(Namespace = "urn:lookup", Order = 1)]
        public LookupServiceRegistrationFilter filterCriteria;

        public ListRequest()
        {
        }

        public ListRequest(ManagedObjectReference _this, LookupServiceRegistrationFilter filterCriteria)
        {
            this._this = _this;
            this.filterCriteria = filterCriteria;
        }
    }
}

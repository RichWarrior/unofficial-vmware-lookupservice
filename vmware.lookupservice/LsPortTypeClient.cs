using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace vmware.lookupservice
{
    [DebuggerStepThrough]
    public class LsPortTypeClient : ClientBase<LsPortType>, LsPortType
    {
        public LsPortTypeClient()
        {
        }

        public LsPortTypeClient(string endpointConfigurationName)
          : base(endpointConfigurationName)
        {
        }

        public LsPortTypeClient(string endpointConfigurationName, string remoteAddress)
          : base(endpointConfigurationName, remoteAddress)
        {
        }

        public LsPortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress)
          : base(endpointConfigurationName, remoteAddress)
        {
        }

        public LsPortTypeClient(Binding binding, EndpointAddress remoteAddress)
          : base(binding, remoteAddress)
        {
        }

        public LookupHaBackupNodeConfiguration RetrieveHaBackupConfiguration(
          ManagedObjectReference _this)
        {
            return this.Channel.RetrieveHaBackupConfiguration(_this);
        }

        public Task<LookupHaBackupNodeConfiguration> RetrieveHaBackupConfigurationAsync(
          ManagedObjectReference _this)
        {
            return this.Channel.RetrieveHaBackupConfigurationAsync(_this);
        }

        public string SetLocale(ManagedObjectReference _this, string locale)
        {
            return this.Channel.SetLocale(_this, locale);
        }

        public Task<string> SetLocaleAsync(ManagedObjectReference _this, string locale)
        {
            return this.Channel.SetLocaleAsync(_this, locale);
        }

        public string GetLocale(ManagedObjectReference _this)
        {
            return this.Channel.GetLocale(_this);
        }

        public Task<string> GetLocaleAsync(ManagedObjectReference _this)
        {
            return this.Channel.GetLocaleAsync(_this);
        }

        public LookupServiceContent RetrieveServiceContent(
          ManagedObjectReference _this)
        {
            return this.Channel.RetrieveServiceContent(_this);
        }

        public Task<LookupServiceContent> RetrieveServiceContentAsync(
          ManagedObjectReference _this)
        {
            return this.Channel.RetrieveServiceContentAsync(_this);
        }

        public void Create(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationCreateSpec createSpec)
        {
            this.Channel.Create(_this, serviceId, createSpec);
        }

        public Task CreateAsync(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationCreateSpec createSpec)
        {
            return this.Channel.CreateAsync(_this, serviceId, createSpec);
        }

        public void Delete(ManagedObjectReference _this, string serviceId)
        {
            this.Channel.Delete(_this, serviceId);
        }

        public Task DeleteAsync(ManagedObjectReference _this, string serviceId)
        {
            return this.Channel.DeleteAsync(_this, serviceId);
        }

        public void Set(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationSetSpec serviceSpec)
        {
            this.Channel.Set(_this, serviceId, serviceSpec);
        }

        public Task SetAsync(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationSetSpec serviceSpec)
        {
            return this.Channel.SetAsync(_this, serviceId, serviceSpec);
        }

        public LookupServiceRegistrationInfo Get(
          ManagedObjectReference _this,
          string serviceId)
        {
            return this.Channel.Get(_this, serviceId);
        }

        public Task<LookupServiceRegistrationInfo> GetAsync(
          ManagedObjectReference _this,
          string serviceId)
        {
            return this.Channel.GetAsync(_this, serviceId);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ListResponse LsPortType.List(ListRequest request)
        {
            return this.Channel.List(request);
        }

        public LookupServiceRegistrationInfo[] List(
          ManagedObjectReference _this,
          LookupServiceRegistrationFilter filterCriteria)
        {
            return ((LsPortType)this).List(new ListRequest()
            {
                _this = _this,
                filterCriteria = filterCriteria
            }).returnval;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ListResponse> LsPortType.ListAsync(ListRequest request)
        {
            return this.Channel.ListAsync(request);
        }

        public Task<ListResponse> ListAsync(
          ManagedObjectReference _this,
          LookupServiceRegistrationFilter filterCriteria)
        {
            return ((LsPortType)this).ListAsync(new ListRequest()
            {
                _this = _this,
                filterCriteria = filterCriteria
            });
        }

        public string GetSiteId(ManagedObjectReference _this)
        {
            return this.Channel.GetSiteId(_this);
        }

        public Task<string> GetSiteIdAsync(ManagedObjectReference _this)
        {
            return this.Channel.GetSiteIdAsync(_this);
        }
    }
}

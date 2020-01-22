using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace vmware.lookupservice
{
    [ServiceContract(ConfigurationName = "vmware.lookupservice.LsPortType", Namespace = "urn:lookup")]
    public interface LsPortType
    {
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [ServiceKnownType(typeof(string[]))]
        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [return: MessageParameter(Name = "returnval")]
        LookupHaBackupNodeConfiguration RetrieveHaBackupConfiguration(
      ManagedObjectReference _this);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        Task<LookupHaBackupNodeConfiguration> RetrieveHaBackupConfigurationAsync(
          ManagedObjectReference _this);

        [ServiceKnownType(typeof(object[]))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(string[]))]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [return: MessageParameter(Name = "returnval")]
        string SetLocale(ManagedObjectReference _this, string locale);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        Task<string> SetLocaleAsync(ManagedObjectReference _this, string locale);

        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(string[]))]
        [ServiceKnownType(typeof(object[]))]
        [return: MessageParameter(Name = "returnval")]
        string GetLocale(ManagedObjectReference _this);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        Task<string> GetLocaleAsync(ManagedObjectReference _this);

        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [ServiceKnownType(typeof(string[]))]
        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        LookupServiceContent RetrieveServiceContent(ManagedObjectReference _this);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        Task<LookupServiceContent> RetrieveServiceContentAsync(
          ManagedObjectReference _this);

        [ServiceKnownType(typeof(string[]))]
        [FaultContract(typeof(LookupFaultEntryExistsFault), Action = "urn:lookup/2.0", Name = "LookupFaultEntryExistsFaultFault")]
        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [FaultContract(typeof(SecurityError), Action = "urn:lookup/2.0", Name = "SecurityErrorFault")]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [FaultContract(typeof(InvalidArgument), Action = "urn:lookup/2.0", Name = "InvalidArgumentFault")]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        void Create(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationCreateSpec createSpec);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        Task CreateAsync(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationCreateSpec createSpec);

        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(string[]))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [FaultContract(typeof(LookupFaultEntryNotFoundFault), Action = "urn:lookup/2.0", Name = "LookupFaultEntryNotFoundFaultFault")]
        [FaultContract(typeof(SecurityError), Action = "urn:lookup/2.0", Name = "SecurityErrorFault")]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        void Delete(ManagedObjectReference _this, string serviceId);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        Task DeleteAsync(ManagedObjectReference _this, string serviceId);

        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(string[]))]
        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [FaultContract(typeof(InvalidArgument), Action = "urn:lookup/2.0", Name = "InvalidArgumentFault")]
        [FaultContract(typeof(SecurityError), Action = "urn:lookup/2.0", Name = "SecurityErrorFault")]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [FaultContract(typeof(LookupFaultEntryNotFoundFault), Action = "urn:lookup/2.0", Name = "LookupFaultEntryNotFoundFaultFault")]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        void Set(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationSetSpec serviceSpec);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        Task SetAsync(
          ManagedObjectReference _this,
          string serviceId,
          LookupServiceRegistrationSetSpec serviceSpec);

        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(string[]))]
        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [ServiceKnownType(typeof(CreateRequestType))]
        [FaultContract(typeof(LookupFaultEntryNotFoundFault), Action = "urn:lookup/2.0", Name = "LookupFaultEntryNotFoundFaultFault")]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [return: MessageParameter(Name = "returnval")]
        LookupServiceRegistrationInfo Get(
          ManagedObjectReference _this,
          string serviceId);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        Task<LookupServiceRegistrationInfo> GetAsync(
          ManagedObjectReference _this,
          string serviceId);

        [ServiceKnownType(typeof(object[]))]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(string[]))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        ListResponse List(ListRequest request);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        Task<ListResponse> ListAsync(ListRequest request);

        [ServiceKnownType(typeof(SetLocaleRequestType))]
        [FaultContract(typeof(RuntimeFault), Action = "urn:lookup/2.0", Name = "RuntimeFaultFault")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(GetSiteIdRequestType))]
        [ServiceKnownType(typeof(ListRequestType))]
        [ServiceKnownType(typeof(GetRequestType))]
        [ServiceKnownType(typeof(SetRequestType))]
        [ServiceKnownType(typeof(DeleteRequestType))]
        [ServiceKnownType(typeof(KeyAnyValue[]))]
        [ServiceKnownType(typeof(object[]))]
        [ServiceKnownType(typeof(GetLocaleRequestType))]
        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [ServiceKnownType(typeof(RetrieveHaBackupConfigurationRequestType))]
        [ServiceKnownType(typeof(DynamicData))]
        [ServiceKnownType(typeof(DynamicProperty[]))]
        [ServiceKnownType(typeof(RetrieveServiceContentRequestType))]
        [ServiceKnownType(typeof(CreateRequestType))]
        [ServiceKnownType(typeof(LocalizableMessage[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationInfo[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationEndpoint[]))]
        [ServiceKnownType(typeof(LookupServiceRegistrationAttribute[]))]
        [ServiceKnownType(typeof(string[]))]
        [return: MessageParameter(Name = "returnval")]
        string GetSiteId(ManagedObjectReference _this);

        [OperationContract(Action = "urn:lookup/2.0", ReplyAction = "*")]
        [return: MessageParameter(Name = "returnval")]
        Task<string> GetSiteIdAsync(ManagedObjectReference _this);
    }
}

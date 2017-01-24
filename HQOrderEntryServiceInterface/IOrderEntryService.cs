using System.ServiceModel;

namespace HQOrderEntryServiceInterface
{
    public interface IOrderEntryService
    {
        [OperationContract(IsOneWay = true, Action = "*")]
        void SendOrderEntry(System.ServiceModel.MsmqIntegration.MsmqMessage<HQOrderEntryServiceInterface.HQOrderEntry> orderEntry);
    }
}

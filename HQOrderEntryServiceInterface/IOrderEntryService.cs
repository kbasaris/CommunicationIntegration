using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HQOrderEntryServiceInterface
{
    public interface IOrderEntryService
    {
        [OperationContract(IsOneWay = true, Action = "*")]
        void SendOrderEntry(System.ServiceModel.MsmqIntegration.MsmqMessage<HQOrderEntryServiceInterface.HQOrderEntry> orderEntry);
    }
}

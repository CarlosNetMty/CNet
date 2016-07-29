using Delta.Service.Model.Orders;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Delta.Service
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract] Task<PerformResponse> Perform(PerformRequest request);
        [OperationContract] Task<CancelResponse> Cancel(CancelRequest request);
    }
}

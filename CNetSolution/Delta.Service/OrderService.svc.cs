using Delta.Service.Model.Orders;
using MediatR;
using System.Threading.Tasks;

namespace Delta.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : DeltaService, IOrderService
    {
        public OrderService(IMediator mediator) : base(mediator) { }
        public async Task<PerformResponse> Perform(PerformRequest request)
        {
            return await base.SendAsync<PerformResponse>(request);
        }
        public async Task<CancelResponse> Cancel(CancelRequest request)
        {
            return await base.SendAsync<CancelResponse>(request);
        }
    }
}

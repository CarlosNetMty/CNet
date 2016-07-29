using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Delta.Service.Model.Orders;

namespace Delta.Service.Order
{
    public class CancelHandler : IAsyncRequestHandler<CancelRequest, CancelResponse>
    {
        public Task<CancelResponse> Handle(CancelRequest message)
        {
            throw new NotImplementedException();
        }
    }
}
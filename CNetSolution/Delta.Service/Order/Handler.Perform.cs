using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Delta.Service.Model.Orders;

namespace Delta.Service.Order
{
    public class PerformHandler : IAsyncRequestHandler<PerformRequest, PerformResponse>
    {
        public Task<PerformResponse> Handle(PerformRequest message)
        {
            throw new NotImplementedException();
        }
    }
}
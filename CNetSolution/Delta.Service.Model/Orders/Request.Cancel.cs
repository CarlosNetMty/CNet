using MediatR;
using System;

namespace Delta.Service.Model.Orders
{
    public class CancelRequest : IAsyncRequest<CancelResponse>
    {
    }
}
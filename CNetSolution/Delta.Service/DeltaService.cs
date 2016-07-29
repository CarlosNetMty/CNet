using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Delta.Service
{
    public abstract class DeltaService
    {
        protected IMediator MediatR { get; private set; }
        public DeltaService(IMediator mediator)
        {
            MediatR = mediator;
        }
        protected TResponse Send<TResponse>(IRequest<TResponse> request)
        {
            return MediatR.Send<TResponse>(request);
        }
        protected async Task<TResponse> SendAsync<TResponse>(IAsyncRequest<TResponse> request)
        {
            return await MediatR.SendAsync<TResponse>(request);
        }
    }
}
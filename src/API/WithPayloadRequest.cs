using System;
using System.Threading.Tasks;

namespace Automated.Api
{
    internal sealed class WithPayloadRequest : IRequest
    {
        private readonly Uri uri;
        private readonly string method;
        private object payload;

        internal WithPayloadRequest(Uri uri, string method, object payload)
        {
            this.uri = uri;
            this.method = method;
            this.payload = payload;
        }
        public Task<Response> Execute()
        {
            throw new NotImplementedException();
        }
    }
}

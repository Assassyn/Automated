using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Automated.Api
{
    internal sealed class JustQueryRequest : IRequest
    {
        private readonly Uri uri;
        private readonly string method;

        internal JustQueryRequest(Uri uri, string method)
        {
            this.uri = uri;
            this.method = method;
        }
        public async Task<Response> Execute()
        {
            var client = new HttpClient();

            var response = await client.GetAsync(this.uri);

            return new Response(response.StatusCode, string.Empty);
        }
    }
}

using System.Net;

namespace Automated.Api
{
    public sealed class Response
    {
        public Response(HttpStatusCode code, string body)
        {
            this.HttpStatusCode = code;
            this.Body = body;
        }
        public HttpStatusCode HttpStatusCode { get; }
        public string Body { get; }
    }
}

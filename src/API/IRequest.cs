using System.Threading.Tasks;

namespace Automated.Api
{
    public interface IRequest
    {
        Task<Response> Execute();
    }
}

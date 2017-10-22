using System.Threading.Tasks;
using MeiLian.Sessions.Dto;

namespace MeiLian.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}

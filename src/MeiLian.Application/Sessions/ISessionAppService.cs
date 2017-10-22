using System.Threading.Tasks;
using Abp.Application.Services;
using MeiLian.Sessions.Dto;

namespace MeiLian.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MeiLian.Authorization.Users.Dto;

namespace MeiLian.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}

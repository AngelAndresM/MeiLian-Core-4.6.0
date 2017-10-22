using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MeiLian.Authorization.Permissions.Dto;

namespace MeiLian.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}

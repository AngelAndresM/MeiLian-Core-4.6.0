using System.Threading.Tasks;
using Abp.Application.Services;
using MeiLian.Configuration.Tenants.Dto;

namespace MeiLian.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}

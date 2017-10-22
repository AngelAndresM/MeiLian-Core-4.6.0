using System.Threading.Tasks;
using Abp.Application.Services;
using MeiLian.Editions.Dto;
using MeiLian.MultiTenancy.Dto;

namespace MeiLian.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}

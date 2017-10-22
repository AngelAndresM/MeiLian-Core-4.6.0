using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MeiLian.Common.Dto;
using MeiLian.Editions.Dto;

namespace MeiLian.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}

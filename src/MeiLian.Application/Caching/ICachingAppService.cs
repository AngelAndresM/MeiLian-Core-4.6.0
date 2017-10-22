using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MeiLian.Caching.Dto;

namespace MeiLian.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}

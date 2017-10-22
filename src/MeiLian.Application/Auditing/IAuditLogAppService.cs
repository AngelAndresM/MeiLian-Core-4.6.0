using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MeiLian.Auditing.Dto;
using MeiLian.Dto;

namespace MeiLian.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}

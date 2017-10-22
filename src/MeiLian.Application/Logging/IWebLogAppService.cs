using Abp.Application.Services;
using MeiLian.Dto;
using MeiLian.Logging.Dto;

namespace MeiLian.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}

using System.Collections.Generic;
using MeiLian.Auditing.Dto;
using MeiLian.Dto;

namespace MeiLian.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}

using System.Collections.Generic;
using MeiLian.Authorization.Users.Dto;
using MeiLian.Dto;

namespace MeiLian.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}

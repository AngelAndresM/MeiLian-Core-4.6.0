using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MeiLian.Security;

namespace MeiLian.Web.Areas.AppAreaName.Models.Users
{
    public class UsersViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Permissions { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }
    }
}

using System.Collections.Generic;
using MeiLian.Authorization.Users.Dto;

namespace MeiLian.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}

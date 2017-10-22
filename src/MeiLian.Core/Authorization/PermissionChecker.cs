using Abp.Authorization;
using MeiLian.Authorization.Roles;
using MeiLian.Authorization.Users;

namespace MeiLian.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

using Abp.AspNetCore.Mvc.Authorization;

namespace MeiLian.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(IAppFolders appFolders)
            : base(appFolders)
        {
        }
    }
}

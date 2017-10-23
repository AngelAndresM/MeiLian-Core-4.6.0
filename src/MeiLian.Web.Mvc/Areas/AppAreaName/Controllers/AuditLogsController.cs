using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using MeiLian.Authorization;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

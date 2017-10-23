using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

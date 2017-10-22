using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace MeiLian.Web.Controllers
{
    public class HomeController : AbpZeroTemplateControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}

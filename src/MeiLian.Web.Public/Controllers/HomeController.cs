using Microsoft.AspNetCore.Mvc;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Public.Controllers
{
    public class HomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

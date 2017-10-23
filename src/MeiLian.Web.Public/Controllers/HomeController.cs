using Microsoft.AspNetCore.Mvc;
using MeiLian.Web.Controllers;

namespace MeiLian.Web.Public.Controllers
{
    public class HomeController : MeiLianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

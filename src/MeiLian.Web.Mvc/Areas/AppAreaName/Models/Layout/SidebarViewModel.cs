using Abp.Application.Navigation;

namespace MeiLian.Web.Areas.AppAreaName.Models.Layout
{
    public class SidebarViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}

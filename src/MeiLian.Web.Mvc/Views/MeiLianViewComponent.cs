using Abp.AspNetCore.Mvc.ViewComponents;

namespace MeiLian.Web.Views
{
    public abstract class MeiLianViewComponent : AbpViewComponent
    {
        protected MeiLianViewComponent()
        {
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}

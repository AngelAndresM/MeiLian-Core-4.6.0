using Abp.AspNetCore.Mvc.ViewComponents;

namespace MeiLian.Web.Public.Views
{
    public abstract class MeiLianViewComponent : AbpViewComponent
    {
        protected MeiLianViewComponent()
        {
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}

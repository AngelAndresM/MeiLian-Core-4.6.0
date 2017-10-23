using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MeiLian.Web.Views
{
    public abstract class MeiLianRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MeiLianRazorPage()
        {
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}

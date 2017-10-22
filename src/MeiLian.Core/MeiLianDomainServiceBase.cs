using Abp.Domain.Services;

namespace MeiLian
{
    public abstract class AbpZeroTemplateDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected AbpZeroTemplateDomainServiceBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}

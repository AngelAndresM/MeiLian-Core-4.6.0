using Abp.Domain.Services;

namespace MeiLian
{
    public abstract class MeiLianDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected MeiLianDomainServiceBase()
        {
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}

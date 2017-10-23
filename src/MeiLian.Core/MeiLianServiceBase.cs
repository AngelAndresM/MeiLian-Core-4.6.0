using Abp;

namespace MeiLian
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="MeiLianDomainServiceBase"/>.
    /// For application services inherit MeiLianAppServiceBase.
    /// </summary>
    public abstract class MeiLianServiceBase : AbpServiceBase
    {
        protected MeiLianServiceBase()
        {
            LocalizationSourceName = MeiLianConsts.LocalizationSourceName;
        }
    }
}

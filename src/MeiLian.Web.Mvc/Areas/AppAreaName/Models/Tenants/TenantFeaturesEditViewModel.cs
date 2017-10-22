using Abp.AutoMapper;
using MeiLian.MultiTenancy;
using MeiLian.MultiTenancy.Dto;
using MeiLian.Web.Areas.AppAreaName.Models.Common;

namespace MeiLian.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}

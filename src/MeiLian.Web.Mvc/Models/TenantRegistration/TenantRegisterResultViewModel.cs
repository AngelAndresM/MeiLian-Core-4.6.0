using Abp.AutoMapper;
using MeiLian.MultiTenancy.Dto;

namespace MeiLian.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}

using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MeiLian.Configuration.Tenants.Dto;

namespace MeiLian.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}

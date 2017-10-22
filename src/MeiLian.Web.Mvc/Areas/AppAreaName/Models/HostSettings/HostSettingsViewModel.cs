using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MeiLian.Configuration.Host.Dto;
using MeiLian.Editions.Dto;

namespace MeiLian.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}

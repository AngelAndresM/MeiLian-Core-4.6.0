using System.Collections.Generic;
using MeiLian.Caching.Dto;

namespace MeiLian.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}

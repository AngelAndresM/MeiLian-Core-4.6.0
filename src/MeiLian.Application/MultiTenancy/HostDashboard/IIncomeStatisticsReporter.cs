using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeiLian.MultiTenancy.HostDashboard.Dto;

namespace MeiLian.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}

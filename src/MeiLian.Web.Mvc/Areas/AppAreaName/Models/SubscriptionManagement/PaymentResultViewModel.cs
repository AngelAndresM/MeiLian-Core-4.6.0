using Abp.AutoMapper;
using MeiLian.Editions;
using MeiLian.MultiTenancy.Payments.Dto;

namespace MeiLian.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}

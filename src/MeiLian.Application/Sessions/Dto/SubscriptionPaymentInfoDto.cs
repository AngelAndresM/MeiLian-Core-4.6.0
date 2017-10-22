using Abp.AutoMapper;
using MeiLian.MultiTenancy.Payments;

namespace MeiLian.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}

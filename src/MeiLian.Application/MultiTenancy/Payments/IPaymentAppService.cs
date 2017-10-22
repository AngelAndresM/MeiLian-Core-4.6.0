using System.Threading.Tasks;
using Abp.Application.Services;
using MeiLian.MultiTenancy.Dto;
using MeiLian.MultiTenancy.Payments.Dto;
using Abp.Application.Services.Dto;

namespace MeiLian.MultiTenancy.Payments
{
    public interface IPaymentAppService : IApplicationService
    {
        Task<PaymentInfoDto> GetPaymentInfo(PaymentInfoInput input);

        Task<CreatePaymentResponse> CreatePayment(CreatePaymentDto input);

        Task<ExecutePaymentResponse> ExecutePayment(ExecutePaymentDto input);

        Task<PagedResultDto<SubscriptionPaymentListDto>> GetPaymentHistory(GetPaymentHistoryInput input);
    }
}

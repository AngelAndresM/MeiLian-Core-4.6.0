using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using MeiLian.MultiTenancy.Accounting.Dto;

namespace MeiLian.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}

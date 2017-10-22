using System.Threading.Tasks;
using Abp.Dependency;

namespace MeiLian.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}

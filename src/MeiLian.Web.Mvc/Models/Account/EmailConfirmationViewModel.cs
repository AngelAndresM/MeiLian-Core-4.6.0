using MeiLian.Authorization.Accounts.Dto;

namespace MeiLian.Web.Models.Account
{
    public class EmailConfirmationViewModel : ActivateEmailInput
    {
        /// <summary>
        /// Tenant id.
        /// </summary>
        public int? TenantId { get; set; }
    }
}

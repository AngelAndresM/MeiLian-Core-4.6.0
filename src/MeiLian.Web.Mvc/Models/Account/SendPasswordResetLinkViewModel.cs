using System.ComponentModel.DataAnnotations;

namespace MeiLian.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}

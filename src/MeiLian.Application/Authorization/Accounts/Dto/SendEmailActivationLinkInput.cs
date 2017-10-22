using System.ComponentModel.DataAnnotations;

namespace MeiLian.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using MeiLian.Authorization.Users;

namespace MeiLian.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MeiLian.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

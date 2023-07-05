using System.ComponentModel.DataAnnotations;

namespace nercoreangular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
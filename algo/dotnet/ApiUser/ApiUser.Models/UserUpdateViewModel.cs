
using System.ComponentModel.DataAnnotations;


namespace ApiUser.Models
{
    public class UserUpdateViewModel : Model
    {
        [Required]
        [StringLength(maximumLength: 16, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+(?:\-[a-zA-Z]+)?$")]
        public string? Username { get; set; }       

    }
}

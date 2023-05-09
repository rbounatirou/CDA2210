using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUser.Models
{
    [Table("Users")]
    public class User : Model
    {
        [Required]
        [StringLength(maximumLength: 16, MinimumLength =2)]
        [RegularExpression(@"^[a-zA-Z]+(?:\-[a-zA-Z]+)?$")]
        //[Column("user_name")]

        public string? Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [RegularExpression(@"^[a-zA-Z0-9]{8,}$")]
        public string? Password { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUser.Models
{
    [Table("Users")]
    public class User : Model
    {
        [Required]
        //[StringLength(16)]
        [MaxLength(16)]
        //[Column("user_name")]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}

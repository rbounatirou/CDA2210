using System.ComponentModel.DataAnnotations;

namespace ApiUser.Models
{
    public abstract class Model
    {
        [Key]
        public int? Id { get; set; }

    }
}
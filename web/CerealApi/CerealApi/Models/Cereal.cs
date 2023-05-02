using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CerealApi.Models
{
    //[Table("cereales")]
    public class Cereal
    {
        [Key]
        public int CerealId { get; set; }

        [Required]
        //[Column("nom")]
        [RegularExpression(@"^[A-Z]\p{L}*$")]
        public string Name { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }
        /*public int Sodium { get; set; }

        public int Fiber { get; set; }
        public int Carbo { get; set; }

        public int Sugar { get; set; }

        public int Potass { get; set; }

        public int Vitamins { get; set; }
        public decimal Rating { get; set;  }*/
    }
}

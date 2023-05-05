using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CerealApi.Models
{
    //[Table("cereales")]
    
    public class Cereal : Model
    {

        [Column("CerealId")]
        public new int Id { get => base.Id; set => base.Id = value; }
        
        [Required]
        //[Column("nom")]
        [RegularExpression(@"^[A-Z]\p{L}*$")]
        public string Name { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }

        public override bool UpdateFromModel(Model model)
        {
            
            if (model is Cereal cereal)
            {
                this.Name = cereal.Name ;
                this.Calories = cereal.Calories ;
                this.Protein = cereal.Protein;
                return true;
            }
            return false;
        }

    }
}

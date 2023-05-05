using System.ComponentModel.DataAnnotations;

namespace CerealApi.Models
{
    abstract public class Model
    {
        [Key]
        public int Id { get; set; }

        abstract public bool UpdateFromModel(Model model);
    }
}

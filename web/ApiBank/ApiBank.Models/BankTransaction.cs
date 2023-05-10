using System.ComponentModel.DataAnnotations;

namespace ApiBank.Models
{
    public class BankTransaction : Model
    {
        [Required]
        public DateTime? TransactionDate { get; set; }

        [Required]
        [Range(100000000000.0d,int.MaxValue, ErrorMessage = "TransactionFrom incorrect")]
        public int TransactionFrom { get; set; }

        [Required]
        [Range(100000000000.0d, int.MaxValue, ErrorMessage = "TransactionTo incorrect")]
        public int TransectionTo { get; set; }

        [Required]
        [Range(100000000000.0d, 99000, ErrorMessage = "Montant incorrect")]
        public double? TransactionAmmount { get; set; }
    }
}
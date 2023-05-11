using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBank.Models
{
    public class BankTransaction : Model
    {
        [Required]
        [DataType(DataType.DateTime)]
       
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime? TransactionDate { get; set; }

        [Required]
        [Range(100000000000.0d,long.MaxValue, ErrorMessage = "TransactionFrom incorrect")]
        public long TransactionFrom { get; set; }

        [Required]
        [Range(100000000000.0d, long.MaxValue, ErrorMessage = "TransactionTo incorrect")]
        public long TransactionTo { get; set; }

        [Required]
        [Precision(7,2)]
        [Range(0.01d, 99000.00d, ErrorMessage =  "Montant incorrect")]
        
        public decimal? TransactionAmmount { get; set; }
    }
}
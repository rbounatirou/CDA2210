using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiBank.Models
{
    public class BankTransaction : Model
    {
        [Required]
        [DataType(DataType.DateTime)]
        
        [Column("transaction_date")]
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]

        
        public DateTime? TransactionDate { get; set; }

        [Required]
        //[Range(10000000000.0d,long.MaxValue, ErrorMessage = "TransactionFrom incorrect")]
        [Column("transaction_from")]
        [RegularExpression("^[1-9][0-9]{10}$")]
        //[StringLength(11)]
        public string TransactionFrom { get; set; }

        [Required]
        //[Range(10000000000.0d, long.MaxValue, ErrorMessage = "TransactionTo incorrect")]
        [RegularExpression("^[1-9][0-9]{10}$")]
        //[StringLength(11)]
        [Column("transaction_to")]
        public string TransactionTo { get; set; }

        [Required]
        [Precision(7,2)]
        [Column("transaction_amount")]
        [Range(0.01d, 99000.00d, ErrorMessage =  "Montant incorrect")]
        
        public decimal? TransactionAmount { get; set; }
    }
}
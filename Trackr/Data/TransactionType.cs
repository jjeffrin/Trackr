using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trackr.Data
{
    public class TransactionType : TrackerBase
    {
        [Key]
        [MaxLength(3)] 
        public string Code { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<Transaction> Transactions { get; set;}
    }
}

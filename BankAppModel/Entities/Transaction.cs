using BankAppModel.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAppModel.Entities
{
    public class Transaction : BaseEntity
    {
        
        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public TransactionType Type { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public bool  IsDeleted { get; set; }

        
    }
}

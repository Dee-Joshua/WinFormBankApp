using BankAppModel.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAppModel.Entities
{
    public class Transaction : BaseEntity
    {
        
        [ForeignKey(nameof(Account))]
        public int AccountId { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public bool  IsDeleted { get; set; }

        // Navigation property
        public Account Account { get; set; }
    }
}

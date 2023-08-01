using BankAppModel.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAppModel.Entities
{
    public class Account : BaseEntity
    {
        
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public string Number { get; set; }
        public AccountType Type { get; set; }
        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        // Navigation property
        public ICollection<Transaction> Transactions { get; set; }
    }

}

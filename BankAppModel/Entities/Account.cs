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
        public decimal Balance { get; set; }

        // Navigation property
        public User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }

}

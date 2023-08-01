namespace BankAppModel.Entities
{
    public class User : BaseEntity
    {
        
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }

}

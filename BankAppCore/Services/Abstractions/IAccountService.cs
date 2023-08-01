using BankAppModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCore.Services.Abstractions
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<IEnumerable<Account>> GetAccountsByUserIdAsync(int userId);
        Task<Account> GetAccountByAccountNumberAsync(string accountNumber);
        Task CreateAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(int id);
    }
}

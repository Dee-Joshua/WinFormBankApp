using BankAppModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.Abstractions
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<Transaction> GetTransactionById(int id);
        Task<IEnumerable<Transaction>> GetAllTransactions();
        Task<IEnumerable<Transaction>> GetDailyTransactions(DateOnly date);
        Task<IEnumerable<Transaction>> GetAccountTransactions(string accountNumber);
    }
}

using BankAppModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCore.Services.Abstractions
{
    public interface ITransactionService
    {
        
        Task<IEnumerable<Transaction>> GetTransactionsByAccountNumberAsync(string accountNumber);
        Task<IEnumerable<Transaction>> GetAllDailyTransaction(string date);
        Task DeleteTransactionAsync(int id);
    }
}

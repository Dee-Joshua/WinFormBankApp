using BankAppModel.Entities;
using BankAppRepository.Data;
using BankAppRepository.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.Implementations
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly DbSet<Transaction> _dbSet;

        public TransactionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Transaction>();
        }


        public async Task<IEnumerable<Transaction>> GetByAccountNumber(string accountNumber)
        {
            return await _dbSet.Where(t => t.SourceAccountNumber == accountNumber).ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetDailyTransactions(DateOnly date)
        {
            return await _dbSet.Where(t => DateOnly.Parse(t.CreatedDate.Date.ToString()) == date).ToListAsync();
        }
    }
}

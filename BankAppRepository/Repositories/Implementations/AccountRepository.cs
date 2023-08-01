using BankAppModel.Entities;
using BankAppRepository.Data;
using BankAppRepository.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.Implementations
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly DbSet<Account> _dbSet;

        public AccountRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbSet = appDbContext.Set<Account>();
        }

        public async Task<List<Account>> GetByUserId(int userId)
        {
            return await _dbSet.Where(a => a.UserId == userId).ToListAsync();
        }
    }
}

using BankAppRepository.Data;
using BankAppRepository.Repositories.Abstractions;
using BankAppRepository.Repositories.Implementations;
using BankAppRepository.Repositories.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private IAccountRepository _accountRepository;
        private IUserRepository _userRepository;
        private ITransactionRepository _transactionRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_appDbContext);
        public IAccountRepository AccountRepository => _accountRepository ?? new AccountRepository(_appDbContext);
        public ITransactionRepository TransactionRepository => _transactionRepository?? new TransactionRepository(_appDbContext);

        public void Dispose()
        {
            _appDbContext?.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}

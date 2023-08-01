using BankAppRepository.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.UnitOfWork.Abstractions
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IAccountRepository AccountRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        Task SaveAsync();
        void Dispose();
    }
}

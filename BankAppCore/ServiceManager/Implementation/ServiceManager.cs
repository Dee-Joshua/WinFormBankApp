using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.ServiceManager.Abstraction;
using BankAppCore.Services.Abstractions;
using BankAppCore.Services.Implementations;
using BankAppRepository.Repositories.UnitOfWork.Abstractions;

namespace BankAppCore.ServiceManager.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private IUserService _userService;
        private IAccountService _accountService;
        private ITransactionService _transactionService;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IUserService UserService => _userService ?? new UserService(_unitOfWork);

        public IAccountService AccountService => _accountService ?? new AccountService(_unitOfWork);

        public ITransactionService TransactionService => _transactionService ?? new TransactionService(_unitOfWork);
    }
}

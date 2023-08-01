using BankAppCore.Services.Abstractions;

namespace BankAppCore.ServiceManager.Abstraction
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IAccountService AccountService { get; }
        ITransactionService TransactionService { get; }

    }
}
using BankAppCore.Services.Abstractions;
using BankAppModel.Entities;
using BankAppRepository.Repositories.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCore.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteTransactionAsync(int id)
        {
            Transaction transaction = await _unitOfWork.TransactionRepository.GetByIdAsync(id);
            _unitOfWork.TransactionRepository.DeleteAsync(transaction);
            await _unitOfWork.SaveAsync();
            _unitOfWork.Dispose();
        }

        public async Task<IEnumerable<Transaction>> GetAllDailyTransaction(string date)
        {
            bool isValidDate = DateOnly.TryParse(date, out DateOnly dateConverted);
            if(!isValidDate)
            {
                return null;
            }
            IEnumerable<Transaction> transactions = await _unitOfWork.TransactionRepository.GetDailyTransactions(dateConverted);
            return transactions;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByAccountNumberAsync(string accountNumber)
        {
            IEnumerable<Transaction> transactions = await _unitOfWork.TransactionRepository.GetAccountTransactions(accountNumber);
            return transactions;
        }
    }
}

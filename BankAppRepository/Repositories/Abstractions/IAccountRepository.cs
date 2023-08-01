using BankAppModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.Abstractions
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetByUserId(int userId);
    }
}

using BankAppModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.Abstractions
{
    public interface IUserRepository
    {
        Task<User> GetByEmail(string email);
    }
}

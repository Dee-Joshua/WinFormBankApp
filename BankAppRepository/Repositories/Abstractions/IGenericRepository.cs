using BankAppModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppRepository.Repositories.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task CreateAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
        void DeleteRange(IEnumerable<T> entities)
    }
}

using BloodSword.Domain.Characters;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace BloodSword.Domain.Repositories
{
    public interface IMonsterRepository
    {
        Task<Monster> GetByIdAsync(Guid id);
        Task<IEnumerable<Monster>> GetAllAsync();
        Task AddAsync(Monster monster);
        Task UpdateAsync(Monster monster);
        Task DeleteAsync(Guid id);
    }
}

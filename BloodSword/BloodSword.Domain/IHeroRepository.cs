using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodSword.Domain
{
    public interface IHeroRepository
    {
        Task<Hero> GetByIdAsync(Guid id);
        Task<IEnumerable<Hero>> GetAllAsync();
        Task AddAsync(Hero hero);
        Task UpdateAsync(Hero hero);
        Task DeleteAsync(Guid id);
    }
}
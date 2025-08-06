using BloodSword.Domain.Items;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloodSword.Domain.Repositories
{
    public interface IItemRepository
    {
        Task<Item> GetByIdAsync(Guid id);
        Task<IEnumerable<Item>> GetAllAsync();
    }
}

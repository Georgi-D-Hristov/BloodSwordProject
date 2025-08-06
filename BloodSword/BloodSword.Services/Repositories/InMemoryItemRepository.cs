using BloodSword.Domain.Items;
using BloodSword.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace BloodSword.Services.Repositories
{
    public class InMemoryItemRepository : IItemRepository
    {
        private readonly List<Item> _items = new List<Item>();

        public InMemoryItemRepository()
        {
            _items.Add(new Weapon { Name = "Меч на светлината", AttackModifier = 5, Description = "Сияен меч, който повишава силата на атака." });
            _items.Add(new Armor { Name = "Кожена ризница", DefenseModifier = 3, Description = "Лека броня, изработена от здрава кожа." });
            _items.Add(new Weapon { Name = "Бойна брадва", AttackModifier = 7, Description = "Тежка брадва, нанасяща сериозни щети." });
            _items.Add(new Armor { Name = "Щит на пазителя", DefenseModifier = 5, Description = "Голям щит, който осигурява надеждна защита." });
        }

        public Task<Item> GetByIdAsync(Guid id)
        {
            return Task.FromResult(_items.FirstOrDefault(i => i.Id == id));
        }

        public Task<IEnumerable<Item>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Item>>(_items);
        }
    }
}
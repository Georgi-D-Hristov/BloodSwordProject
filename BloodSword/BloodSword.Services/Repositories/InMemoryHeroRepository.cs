using BloodSword.Domain.Characters;
using BloodSword.Domain.Items;
using BloodSword.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodSword.Services.Repositories
{
    public class InMemoryHeroRepository : IHeroRepository
    {
        private readonly List<Hero> _heroes = new List<Hero>();

        public InMemoryHeroRepository()
        {
            // Първоначални данни за тестване
            var warrior = new Warrior
            {
                Name = "Cody the Warrior",
                Health = 120,
                MaxHealth = 120,
                AttackSkill = 15,
                DefenseSkill = 10
            };
            warrior.AddItem(new Weapon { Name = "Меч на светлината", AttackModifier = 5 });
            warrior.AddItem(new Armor { Name = "Кожена ризница", DefenseModifier = 3 });

            var enchanter = new Enchanter
            {
                Name = "Zelda the Enchanter",
                Health = 80,
                MaxHealth = 80,
                AttackSkill = 8,
                DefenseSkill = 5
            };
            enchanter.AddItem(new Weapon { Name = "Магическа пръчка", AttackModifier = 2 });
            enchanter.AddItem(new Armor { Name = "Магическа роба", DefenseModifier = 1 });
         
            _heroes.Add(warrior);
            _heroes.Add(enchanter);
        }

        public Task<Hero> GetByIdAsync(Guid id)
        {
            return Task.FromResult(_heroes.FirstOrDefault(h => h.Id == id));
        }

        public Task<IEnumerable<Hero>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Hero>>(_heroes);
        }

        public Task AddAsync(Hero hero)
        {
            _heroes.Add(hero);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Hero hero)
        {
            var existingHero = _heroes.FirstOrDefault(h => h.Id == hero.Id);
            if (existingHero != null)
            {
                // Заменяме стария герой с новия
                var index = _heroes.IndexOf(existingHero);
                _heroes[index] = hero;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var heroToRemove = _heroes.FirstOrDefault(h => h.Id == id);
            if (heroToRemove != null)
            {
                _heroes.Remove(heroToRemove);
            }
            return Task.CompletedTask;
        }
    }
}

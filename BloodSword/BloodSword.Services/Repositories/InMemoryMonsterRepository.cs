using BloodSword.Domain.Characters;
using BloodSword.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace BloodSword.Services.Repositories
{
    public class InMemoryMonsterRepository : IMonsterRepository
    {
        private readonly List<Monster> _monsters = new List<Monster>();

        public InMemoryMonsterRepository()
        {
            // Добавяме няколко различни чудовища за тестване
            _monsters.Add(new Monster { Name = "Гоблин", Health = 30, MaxHealth = 30, AttackSkill = 8, DefenseSkill = 5 });
            _monsters.Add(new Monster { Name = "Орк", Health = 50, MaxHealth = 50, AttackSkill = 12, DefenseSkill = 8 });
            _monsters.Add(new Monster { Name = "Трол", Health = 80, MaxHealth = 80, AttackSkill = 15, DefenseSkill = 10 });
        }

        public Task<Monster> GetByIdAsync(Guid id)
        {
            return Task.FromResult(_monsters.FirstOrDefault(m => m.Id == id));
        }

        public Task<IEnumerable<Monster>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Monster>>(_monsters);
        }

        public Task AddAsync(Monster monster)
        {
            _monsters.Add(monster);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Monster monster)
        {
            var existingMonster = _monsters.FirstOrDefault(m => m.Id == monster.Id);
            if (existingMonster != null)
            {
                var index = _monsters.IndexOf(existingMonster);
                _monsters[index] = monster;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var monsterToRemove = _monsters.FirstOrDefault(m => m.Id == id);
            if (monsterToRemove != null)
            {
                _monsters.Remove(monsterToRemove);
            }
            return Task.CompletedTask;
        }
    }
}

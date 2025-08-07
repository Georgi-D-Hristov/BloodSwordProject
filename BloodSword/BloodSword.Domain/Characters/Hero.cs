using BloodSword.Domain.Items;

namespace BloodSword.Domain.Characters
{
    public class Hero : Character
    {
        public int TotalAttackSkill => AttackSkill + Inventory.OfType<Weapon>().Sum(w => w.AttackModifier);
        public int TotalDefenseSkill => DefenseSkill + Inventory.OfType<Armor>().Sum(d => d.DefenseModifier);

        public int Rank { get; set; }
        public int Gold { get; set; }
        public int Experience { get; set; }

        public List<Item> Inventory { get; private set; } = new List<Item>();
        // Тук можем да добавим още свойства като магически точки, заклинания и т.н.

        public void AddItem(Item item)
        {
            Inventory.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Inventory.Remove(item);
        }
    }
}
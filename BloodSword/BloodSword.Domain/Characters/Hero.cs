using BloodSword.Domain.Items;

namespace BloodSword.Domain.Characters
{
    public class Hero : Character
    {
        public int TotalAttackSkill => AttackSkill + Inventory.OfType<Weapon>().Sum(w => w.AttackModifier);
        public int TotalDefenseSkill => DefenseSkill + Inventory.OfType<Armor>().Sum(d => d.DefenseModifier);

        public List<Item> Inventory { get; set; } = new List<Item>();
        // Тук можем да добавим още свойства като магически точки, заклинания и т.н.
    }
}
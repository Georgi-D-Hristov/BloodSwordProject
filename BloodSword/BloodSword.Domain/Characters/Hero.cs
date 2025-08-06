using BloodSword.Domain.Items;

namespace BloodSword.Domain.Characters
{
    public class Hero : Character
    {
        public List<Item> Inventory { get; set; } = new List<Item>();
        // Тук можем да добавим още свойства като магически точки, заклинания и т.н.
    }
}
namespace BloodSword.Domain.Characters
{
    public class Hero : Character
    {
        public List<string> Inventory { get; set; } = new List<string>();
        // Тук можем да добавим още свойства като магически точки, заклинания и т.н.
    }
}
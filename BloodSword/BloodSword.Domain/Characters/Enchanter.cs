namespace BloodSword.Domain.Characters
{
    public class Enchanter : Hero
    {
        public List<string> Spells { get; set; } = new List<string>
        {
            "Fireball",
            "Magic Missile",
            "Healing"
        };
    }
}

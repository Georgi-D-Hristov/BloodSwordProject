namespace BloodSword.Domain.Characters
{
    public abstract class Character
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackSkill { get; set; }
        public int DefenseSkill { get; set; }
    }
}

using System;

namespace BloodSword.Domain.Items
{
    public abstract class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}
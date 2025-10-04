using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public abstract class Monster : CharacterBase, ILootable
    {
        public string Treasure { get; set; }
        public Monster(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }
    }
}
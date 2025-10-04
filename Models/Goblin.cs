using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Goblin : Monster, ILootable
    {
        public string Treasure { get; set; }

        public Goblin(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp, treasure)
        {
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} grunts, stomps, and saunters off as if it mattered at all what his unique behavior was.  No one loves {Name} anyway, he's a {Type}");
        }
    }
}

using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Ghost : CharacterBase, IFlyable, ILootable, IDefendable
    {
        public string Treasure { get; set; }

        public Ghost(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }

        public override void Attack(ICharacter target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} attacks with an energetic ball of electric fear energy!");
            Console.ResetColor();
        }

        public override void Move() {
            Console.WriteLine($"{Name} moves gracefully because it's been around for thousands of years");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies rapidly through the air.");
        }

        public void Drop()
        {
            Console.WriteLine($"{Name} drops something idc what.");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} drops something idc what.");
        }

        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }
}

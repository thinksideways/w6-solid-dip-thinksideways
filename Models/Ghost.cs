using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Ghost : Monster, IFlyable
    {
        public string Treasure { get; set; }

        public Ghost(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp, treasure)
        {
            Treasure = treasure;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies rapidly through the air.");
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} wails eerily, passing through walls and chilling the air. Everyone's afraid of {Name} anyway, he's a {Type}");
        }
    }
}

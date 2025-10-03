using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Goblin : CharacterBase, ILootable, IDefendable
    {
        public string Treasure { get; set; }

        public Goblin(string name, string type, int level, int hp, string treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }

        public override void Attack(ICharacter target)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} attacks with a club!");
            Console.ResetColor();
        }

        public override void Move() {
            Console.WriteLine($"{Name} moves clumsily because it's club is bigger than it's brain.");
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }

        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }
}

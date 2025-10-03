using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Player : CharacterBase
    {
        public int Gold { get; set; }

        public Player(string name, string type, int level, int hp, int gold)
            : base(name, type, level, hp)
        {
            Gold = gold;
        }

        public override void Attack(ICharacter target)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} attacks {target.Name}");
            Console.ResetColor();

            if (target is ILootable target && !string.IsNullOrEmpty(target.Treasure))
            {
                Console.WriteLine($"{Name} takes {target.Treasure} from {target.Name}");
                player.Gold += 10; // Assuming each treasure is worth 10 gold
                targetWithTreasure.Treasure = null; // Treasure is taken
            }
            else if (target is Player target && target.Gold > 0)
            {
                Console.WriteLine($"{Name} takes gold from {target.Name}");
                player.Gold += target.Gold;
                target.Gold = 0; // Gold is taken
            }
        }

        public override void Move() {
            Console.WriteLine($"{Name} moves gracefully because it's been around for thousands of years");
        }

        public override void UniqueBehavior()
        {
            throw new NotImplementedException();
        }
    }
}

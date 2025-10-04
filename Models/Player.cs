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

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} adds more product to his hair.  He spritses himself with Burberry Hero and Sauvage by Christian Dior.  {Name} always gets the girl because he's a {Type}");
        }
    }
}

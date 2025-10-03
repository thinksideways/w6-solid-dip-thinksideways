using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public abstract class CharacterBase : ICharacter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        protected CharacterBase(string name, string type, int level, int hp)
        {
            Name = name;
            Type = type;
            Level = level;
            HP = hp;
        }

        protected CharacterBase() { }

        public abstract void Attack(ICharacter target);

        public abstract void Move();

        public abstract void UniqueBehavior();
    }
}

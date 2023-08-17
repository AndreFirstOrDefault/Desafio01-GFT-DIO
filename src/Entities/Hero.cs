namespace Desafio01.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public string Name { get; set; }
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return $"{Name}, {Level}, {HeroType}";
        }     
        
        public virtual string Attack()
        {
            return Name + " atacou com a sua espada";
        }
        
    }
}
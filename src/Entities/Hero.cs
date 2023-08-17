namespace Desafio01.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, int hitPoints,int magicPoints, Enum heroType)
        {
            Name = name;
            Level = level;
            HitPoints = hitPoints;
            MagicPoints = magicPoints;
            
        }
        

        public string Name { get; set; }
        public int Level;
        public int HitPoints;
        public int MagicPoints;
        public string HeroType;

        public override string ToString()
        {
            return $"{Name}, {Level}, {HeroType}";
        }     
        
        public virtual string Attack(Hero enemy)
        {
            return Name + " atacou.";
        }
        
    }
}
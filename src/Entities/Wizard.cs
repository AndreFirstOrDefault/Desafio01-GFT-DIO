namespace Desafio01.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, int hitPoints, int magicPoints, Enum heroType) : 
        base(name, level, hitPoints,magicPoints, heroType)
        {

        }
     

        public override string Attack(Hero enemy)
        {
            MagicPoints -= 10;
            enemy.HitPoints -= 20;
            return Name +" atacou " + enemy.Name + "\n\n" + 
                   "Magic Points do " +Name+ " = " + MagicPoints + "\n" +
                   "Health Points do " +enemy.Name+ " = " + enemy.HitPoints + "\n\n";
        }
        
        
    }
}
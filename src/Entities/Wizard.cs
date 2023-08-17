namespace Desafio01.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {

        }

        public override string Attack()
        {
            return Name + " lançou magia";
        }

        public string Attack(int bonus)
        {
            if(bonus>6){
                return Name + " lançou magia super efetiva com bonus de " + bonus ;
            }

            return Name + " lançou magia com força fraca com bonus de " + bonus ;
        }
        
    }
}
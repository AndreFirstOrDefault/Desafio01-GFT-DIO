using Desafio01.src.Entities;
using Desafio01.src.Entities.Entities.Enums;

Knight arus = new Knight("Arus",42,469,72,HeroType.Knight);
Ninja wedge = new Ninja("Wedge",42,292,89,HeroType.Ninja);
Wizard jenica = new Wizard("Jennica",42,325,474,HeroType.Ninja);
Wizard topapa = new Wizard("Topapa",42,106,611,HeroType.BlackWizard);


Console.WriteLine(arus.Attack(wedge));
Console.WriteLine(jenica.Attack(arus));
Console.WriteLine(wedge.Attack(topapa));
Console.WriteLine(topapa.Attack(jenica));



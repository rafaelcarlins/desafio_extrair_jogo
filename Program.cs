using Desafio.src.Entities;

    Knight aru = new Knight("Aru",23,"Knight",469, 749,72,72);
    
    Wizard wizard = new Wizard("Jennica",23,"White Wizard", 325,570, 89,89);

    Ninja wedje = new Ninja("Wedje", 42,"Ninja",292,579,89,89);
    
    Console.WriteLine(aru.ToString());
    Console.WriteLine(aru.Attack());
    Console.WriteLine(wizard.Attack());
    Console.WriteLine(wizard.ToString());
    Console.WriteLine(wizard.Attack(7));
    Console.WriteLine(wedje.Attack());
    Console.WriteLine(wedje.ToString());

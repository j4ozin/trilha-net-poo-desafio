using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Nokia c1 = new Nokia("(81)9.5555-7777", "Nokia Tijolao", "333", 120);
c1.Ligar();
c1.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------------");

Console.WriteLine("Smartphone Iphone:");
Iphone c2 = new Iphone("(81)9.7777-7777", "Iphone 4s", "777", 800);
c2.ReceberLigacao();
c2.InstalarAplicativo("DIO Mobile");

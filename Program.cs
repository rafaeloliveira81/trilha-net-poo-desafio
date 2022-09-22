using DesafioPOO.Models;

Iphone iphone = new Iphone("35999998888", "IPhone 10", "123123123", 64);
Nokia nokia = new Nokia("35988998888", "Nokia 6532", "345345345", 128);

Console.WriteLine("Smartphone Nokia:");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Trello");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone:");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");

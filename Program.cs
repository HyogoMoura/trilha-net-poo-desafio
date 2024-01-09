using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("88199327724"," G60", "001970-01-010000-0",256);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Iphone ip = new Iphone("998453377","Iphone 15", "201970-01-21045-9",128);
ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("X");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456", "modelo 1", "11111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("DevTools");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("981423", "XP", "222222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
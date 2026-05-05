using DesafioPOO.Models;

Console.WriteLine("REALIZANDO TESTE COM CLASSE NOKIA");
Nokia nokia = new Nokia("12345678900", "NO26", "1123131", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Minecraft");

Console.WriteLine("===---===---===---===---===---===---===---===---===---===---===---===");

Console.WriteLine("REALIZANDO TESTE COM CLASSE IPHONE");
Iphone iphone = new Iphone("00987654321", "13", "68763", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");
// TODO: Realizar os testes com as classes Nokia e Iphone
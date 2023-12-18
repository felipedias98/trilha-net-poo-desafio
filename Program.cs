using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n = new Nokia("170","N70","111111111",64);
n.InstalarAplicativo("Whatsapp");
n.InstalarAplicativo("whatsapp");
n.InstalarAplicativo("Instagram");
n.ListarAplicativos();
n.ReceberLigacao();
n.Ligar();
System.Console.WriteLine("-------------------------------");
Iphone iphone = new Iphone("180","Iphone 10s", "2222222222", 128);
iphone.InstalarAplicativo("Whatsapp");
iphone.InstalarAplicativo("whatsapp");
iphone.InstalarAplicativo("Instagram");
iphone.ListarAplicativos();
iphone.ReceberLigacao();
iphone.Ligar();
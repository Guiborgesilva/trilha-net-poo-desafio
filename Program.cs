using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia Lumia 520", imei: "33466541200", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero: "32153", modelo: "IPhone 15 Pro Max", imei: "351316010", memoria: 1000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
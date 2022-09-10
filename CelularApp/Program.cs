
using CelularApp.Model;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "999997755", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "888885544", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


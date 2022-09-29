using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone

Console.WriteLine("Samartphone Nokia:");
Smartphone nokia = new Nokia(numero: "912345678", modelo: "modelo1", imei: "123456", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");


Console.WriteLine("Samartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "modelo2", imei: "654321", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");
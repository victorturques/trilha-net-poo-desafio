using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "000000000001", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");



Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "000000000002", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
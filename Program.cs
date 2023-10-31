using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone Nokia = new Nokia(numero: "2323232", modelo: "D20",imei: "5555", memoria: 64);

Nokia.Ligar();
Nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Smartphone Iphone = new Iphone(numero: "4242424", modelo: "11",imei: "111", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");


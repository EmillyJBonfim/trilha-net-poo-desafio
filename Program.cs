using DesafioPOO.Models;
Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "1111111", modelo: "ABC", imei: "22222222222", memoria: 13);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("");


Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "1121111", modelo: "ABCD", imei: "23222222222", memoria: 13);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("");
// TODO: Realizar os testes com as classes Nokia e Iphone
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
var celNokia = new Nokia("+551199999-5555", "NK-AI", "56783a5b97c987", 132);
celNokia.Ligar();
celNokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();
Console.WriteLine("Smartphone Iphone:");
var celIphone = new Iphone("+551177777-7777", "IP-AI", "56783c5b97a987", 132);
celIphone.ReceberLigacao();
celIphone.InstalarAplicativo("Telegram");

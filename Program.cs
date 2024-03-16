using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("--- NOKIA ---");
Nokia smartphoneNokia = new Nokia("27998877665", "X100", "998877665544332211", 8);
smartphoneNokia.ReceberLigacao();
smartphoneNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("--- IPHONE ---");
Iphone smartphoneIphone = new Iphone("27112233445", "14 PRO MAX", "112233445566778899", 4);
smartphoneIphone.ReceberLigacao();
smartphoneIphone.InstalarAplicativo("WhatsApp");
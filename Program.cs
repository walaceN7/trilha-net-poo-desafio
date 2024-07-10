using DesafioPOO.Models;

Iphone iphone = new Iphone("21999969484", "13", "123456789", 4096);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia("21996230852", "Lumia", "987654321", 1024);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

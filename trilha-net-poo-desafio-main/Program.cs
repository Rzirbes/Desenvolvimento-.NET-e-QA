using DesafioPOO.Models;

Nokia nokia = new Nokia("51-99999999", "Nokia", "123456-78901234", 14);
Iphone iphone = new Iphone("51-88888888", "Iphone", "78901234-123456", 20);

iphone.Ligar();
iphone.InstalarAplicativo("Joguinho");

nokia.Ligar();
nokia.InstalarAplicativo("Meditação");
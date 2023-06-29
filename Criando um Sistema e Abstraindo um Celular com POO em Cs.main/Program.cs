
using SistemasParaCelulares.Models;

Console.WriteLine("===== Celular 1 ======");
Nokia cel1 = new Nokia("(11)91111-0000", "G21", "IMEI:1234567890", 64);
cel1.InstalarAplicativo("WhatsApp");
cel1.Ligar();
cel1.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("===== Celular 2 ======");
Iphone cel2 = new Iphone("(11)92222-0000", "Iphone 14 Pro", "IMEI:1239874560", 128);
cel2.InstalarAplicativo("Avenue");
cel2.Ligar();
cel2.ReceberLigacao();

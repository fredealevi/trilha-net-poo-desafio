using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia: ");
Nokia celular1 = new Nokia("911111111", "Tijolo", "123456", 12);
celular1.Ligar();
celular1.ReceberLigacao();
System.Console.WriteLine($"Ligação recebida no celular {celular1.Numero}");

System.Console.WriteLine("\n");

celular1.InstalarAplicativo("compartilhagram");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Iphone celular2 = new Iphone("922222222", "Iphone Genérico", "123456", 12);
celular2.Ligar();
celular2.ReceberLigacao();
System.Console.WriteLine($"Ligação recebida no celular {celular2.Numero}");

System.Console.WriteLine("\n");

celular2.InstalarAplicativo("facefofs");

System.Console.WriteLine("\n");


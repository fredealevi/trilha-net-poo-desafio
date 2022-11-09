namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string Imei, int memoria) 
        : base (numero, modelo, Imei, memoria)
       {

       }
            
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalado aplicativo no Smartphone {nomeApp} com sucesso.");
        }
    }
}
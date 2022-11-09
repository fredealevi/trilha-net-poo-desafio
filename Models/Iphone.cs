namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string Imei, int memoria) 
        : base (numero, modelo, Imei, memoria)
       {

       }
            
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalado aplicativo {nomeApp} no Smartphone Iphone com sucesso.");
        }
    }
}
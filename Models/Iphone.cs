using System.Reflection;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO!
    public class Iphone: Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO!
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} em Iphone {Modelo} IMEI: {Imei}");
            Thread.Sleep(3000);
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO!
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO!
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} em Nokia {Modelo} IMEI: {Imei}");
            Thread.Sleep(5000);
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}
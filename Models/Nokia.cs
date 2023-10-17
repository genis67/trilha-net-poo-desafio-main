namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string ime, int memoria) : base(numero, modelo, ime, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia.");
        }

    }
}
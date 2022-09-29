namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Repassa todas as infos do parametro para a Classe Smartphone
        public Nokia(string numero, string modelo, string imei, int memoria) :  base(numero, modelo, imei, memoria)
        {
            
        }

        // Sobrescreve o método abstract "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}
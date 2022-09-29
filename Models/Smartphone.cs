namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        public string Numero 
        { 
            get => _numero; 
            
            // Checa se o Numero possui 9 digitos
            set
            {
                if(value == "" || value.Count() != 9)
                {
                    throw new Exception("O Numero devera possuir 9 digitos.");
                }
                _numero = value;
            } 
        }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
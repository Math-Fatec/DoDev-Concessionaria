using System;
namespace ProjetoConcessionaria.Models
{
    public class Moto : Concessionaria
    {
        private int Cilindradas { get; set; }
        private string Partida { get; set; }

        public void GetCilindradas(int Cilindradas)
        {
            Cc = Cilindradas;
        }

        public int SetCilindradas()
        {
            return Cilindradas;
        }

        public void GetPartida(string Partida)
        {
            Partida = Partida;
        }

        public string SetPartida()
        {
            return Partida;
        }

        public override double CalcularValor()
        {
            switch (Veiculo)
            {
                            
                case "Moto":
                if (Partida = "Sim")
                {
                    ValorFinal = (Cilindradas * 50) + (ValorFinal * 0.10);
                } else {
                    ValorFinal = (Cilindradas * 50);
                }
                break;
            
                default:
                Console.WriteLine("Apenas vendemos carros e motos, futuramente abriremos Concessionárias especializadas em outros tipos de veículos");
                break;
            }
        }
    }
}
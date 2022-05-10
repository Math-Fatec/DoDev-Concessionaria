using System;
namespace ProjetoConcessionaria.Models
{
    public class Carro : Concessionaria
    {
        private boolean TransmissaoAutomatica { get; set; }
        private string combustivel { get; set; }

        public void GetTransmissaoAutomatica(Boolean TransmissaoAutomatica)
        {
            Transmissao = TransmissaoAutomatica;
        }

        public boolean SetTransmissaoAutomatica()
        {
            return TransmissaoAutomatica;
        }

        public void GetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }

        public string SetCombustivel()
        {
            return combustivel;
        }

        public override double CalcularValor()
        {
            switch(Veiculo)
            {
                case "Carro":
                if (TransmissaoAutomatica = "Sim")
                {
                    ValorFinal = ValorFinal + (ValorFinal * 0.20);
                } else {
                    ValorFinal;
                }
                break;
            
                default:
                Console.WriteLine("Apenas vendemos carros e motos, futuramente abriremos Concessionárias especializadas em outros tipos de veículos");
                break;
            }
        }
    }
}
using System;
namespace ProjetoConcessionaria.Models
{
    public class Veiculo : Concessionaria
    {
        private string FormaPagamento {get; set;}
        private double ValorFinal {get; set;}

        public void GetForma(string FormaPagamento)
        {
            Pagamento = FormaPagamento;
        }

        public string SetForma()
        {
            return FormaPagamento;
        }

        public void GetValor(double ValorFinal)
        {
            Valor = ValorFinal;
        }

        public double SetValor()
        {
            return ValorFinal;
        }

        public class Comprador : Cliente
        {
            Cliente();
        }

        public class Vendedor : Funcionario
        {
            Funcionario();
        }

        public class Veiculo : Veiculos
        {
            Veiculos();
        }

        public override double AplicarDesconto()
        {
            Funcionario(Vendedor);

            switch(Cargo)
            {
                case "Gerente":
                Desconto = (valorFinal * 0.95);
                valorFinalComDesconto = (valorFinal - Desconto);
                return valorFinalComDesconto;
                break;

                default:
                Console.WriteLine("Você não tem acesso como sendo Vendedor, apenas 'Gerente' tem este acesso.");
                break;
            }
        }
    }
}
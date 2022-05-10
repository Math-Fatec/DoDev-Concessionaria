using System;
namespace ProjetoConcessionaria.Models
{
    public class Veiculo : Concessionaria
    {
        private string Nome {get; set;}
        private string CPF {get; set;}
        private datetime DataNascimento {get; set;}

        public void GetNome(string Nome)
        {
            Nome = nome;
        }

        public string SetMarca()
        {
            return Nome;
        }

        public void GetCPF(string CPF)
        {
            Cpf = CPF;
        }

        public string SetModelo()
        {
            return Modelo;
        }

        public void GetAno(datetime Ano)
        {
            Anos = Ano;
        }

        public timestamp SetAno()
        {
            return Ano;
        }
    }
}
using System;
namespace ProjetoConcessionaria.Models
{
    public class Veiculo : Concessionaria
    {
        private string Marca {get; set;}
        private string Modelo {get; set;}
        private datetime Ano {get; set;}
        private int Kilometragem {get; set;}
        private string Cor {get; set;}
        private double Valor {get; set;}

        public void GetMarca(string Marca)
        {
            Marca = marca;
        }

        public string SetMarca()
        {
            return Marca;
        }

        public void GetModelo(string Modelo)
        {
            Modelo = modelo;
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

        public void GetKm(int Quilometragem)
        {
            Km = Quilometragem;
        }

        public int SetKm()
        {
            return Quilometragem;
        }

        public void GetCor(string Cor)
        {
            Cores = Cor;
        }

        public string SetCor()
        {
            return Cor;
        }

        public void GetValor(double Valor)
        {
            Valores = Valor;
        }

        public double SetValor()
        {
            return Valor;
        }

        public override double CalcularValor()
        {
            
        }
    }
}
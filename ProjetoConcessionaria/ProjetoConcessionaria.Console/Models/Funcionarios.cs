using System;
namespace ProjetoConcessionaria.Models
{
    public class Funcionario : Concessionaria
    {
        private string Cargo { get; set; }

        public void GetCargo(string Cargo)
        {
            Cargo = Cargo;
        }

        public string SetCargo()
        {
            return Cargo;
        }
    }
}
using System;
namespace ProjetoConcessionaria.Models
{
    public class Cliente : Concessionaria
    {
        private string Email { get; set; }

        public string Telefone {get; set;}

        public void GetCargo(string Email)
        {
            Email = Email;
        }

        public string SetCargo()
        {
            return Email;
        }

        public void GetCargo(string Telefone)
        {
            Telefone = Telefone;
        }

        public string SetCargo()
        {
            return Telefone;
        }
    }
}
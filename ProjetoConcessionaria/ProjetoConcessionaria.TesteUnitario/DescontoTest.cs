using Xunit;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.TesteUnitario
{
    public class DescontoTest
    {
        [Fact]
        public void NaoDeveTerDescontoNegativo(){
            //Arrange - Preparação
            var valorFinalComDesconto =! ValorFinal;
            var ValorFinal = new Vendas("teste", 0);
            //Act - Agir
            var ValorFinal = ValorFinal.GetValor();
            //Assert - Verficiar
            Assert.Equal(valorFinalComDesconto, ValorFinal);
        }
    }

}
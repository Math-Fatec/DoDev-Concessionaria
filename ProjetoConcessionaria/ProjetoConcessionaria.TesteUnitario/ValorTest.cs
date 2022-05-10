using Xunit;
using ProjetoConcessionaria.Models;

namespace ProjetoConcessionaria.TesteUnitario
{
    public class ValorTest
    {
        [Fact]
        public void NaoDeveSerNegativo(){
            //Arrange - Preparação
            var ValorFinal = ValorFinal;
            var value = new Veiculo("teste", 0);
            //Act - Agir
            var valorFinal = value.GetValor();
            //Assert - Verficiar
            Assert.Equal(ValorFinal, valorFinal);
        }
    }

}
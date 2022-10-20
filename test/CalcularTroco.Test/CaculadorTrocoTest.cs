using CalcularTrocoUtils;
using System.Drawing;

namespace CalcularTroco.Test
{
    public class CaculadorTrocoTest
    {
        [Fact]
        public void CalcularTrocoTeste()
        {
            // Arrange
            decimal troco = 23.47M;
            // Act
            var trocoCalculado = CaculadorTroco.CalculaTroco(troco);
            // Assert
            var expected = new List<string>
            {
                "1 nota de 20 reais",
                "1 nota de 2 reais",
                "1 moeda de 1 real",
                "1 moeda de 25.00 centavos",
                "2 moedas de 10.00 centavos",
                "2 moedas de 1.00 centavo"
            };
            Assert.Equal(expected.Count, trocoCalculado.Count);
            Assert.Equal(expected, trocoCalculado);
        }
    }
}
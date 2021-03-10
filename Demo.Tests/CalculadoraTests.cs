using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(expected: 4, actual: resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 6)]
        [InlineData(4, 3, 7)]
        [InlineData(9, 1, 10)]
        [InlineData(6, 3, 9)]
        [InlineData(1, 7, 8)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            // Assert
            Assert.Equal(expected: total, actual: resultado);
        }
    }
}

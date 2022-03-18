using DesafioTecnico.Core.Service;
using System.Collections.Generic;
using Xunit;

namespace DesafioTecnico.Divisores.Testes
{
    public class DivisorServiceTest
    {
        [Fact]
        public void DeveRetornarDivisiveisSucesso()
        {
            //Arrange
            DivisorService divisorService = new DivisorService();

            var listaEsperada = new List<long> { 1, 3, 5, 15 };

            //Act
            var resultado = divisorService.Calcular(15);

            //Assert
            Assert.Equal(listaEsperada, resultado);
        }

        [Fact]
        public void DeveRetornarDivisiveisPrimosSucesso()
        {
            //Arrange
            DivisorService divisorService = new DivisorService();
            var listaEsperada = new List<long> { 3, 5 };

            //Act
            var resultado = divisorService.Calcular(15, true);

            //Assert
            Assert.Equal(listaEsperada, resultado);
        }
    }
}

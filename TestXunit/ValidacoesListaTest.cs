using TesteXunit.Console.Services;

namespace TesteXunit
{
    public class ValidacoesListaTests
    {
        private ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            //TODO: Implementar m�todo de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            //TODO: Implementar m�todo de teste

            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
            var numeroParaMultiplicar = 2;

            // Act
            var resultado = _validacoes.MultiplicarNumerosLista(lista, numeroParaMultiplicar);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            //TODO: Implementar m�todo de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
            // Assert
            //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao m�todo
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            //TODO: Implementar m�todo de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao m�todo
            Assert.Equal(-8, resultado);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _texto;

        public ValidacoesStringTests()
        {
            _texto = new ValidacoesString();
        }

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            string textoDeTeste = "Matrix";

            //Act
            int resultado = _texto.RetornarQuantidadeCaracteres(textoDeTeste);

            //Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            //Arrange
            string texto = "Esse é um texto qualquer";
            string palavraBuscada = "qualquer";

            //Act
            bool resultado = _texto.ContemCaractere(texto, palavraBuscada);

            //Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            //Arrange
            string texto = "Esse é um texto qualquer";
            string palavraBuscada = "teste";

            //Act
            bool resultado = _texto.ContemCaractere(texto, palavraBuscada);

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            //Arrange
            string texto = "Começo, meio e fim do texto procurado";
            string palavraBuscada = "procurado";

            //Act
            bool resultado = _texto.TextoTerminaCom(texto, palavraBuscada);

            //Assert
            Assert.True(resultado);
        }
    }
}
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _lista;

    public ValidacoesListaTests()
    {
        _lista = new ValidacoesLista();
    }

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        //Arrange
        List<int> listaDeNumeros = new List<int>() { 1, -2, 3, -4, 5, -14 };

        List<int> listaDeNumerosPositivos = new List<int>() { 1, 3, 5 };

        //Act
        List<int> resultado = _lista.RemoverNumerosNegativos(listaDeNumeros);

        //Assert
        Assert.Equal(listaDeNumerosPositivos, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        //Arrange 
        List<int> listaDeNumeros = new List<int>() { 1, -2, 3, -4, 9, 5, -14 };
        int existeNaLista = 9;

        //Act
        bool resultado = _lista.ListaContemDeterminadoNumero(listaDeNumeros, existeNaLista);

        //Assert
        Assert.True(resultado);

    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //Arrange 
        List<int> listaDeNumeros = new List<int>() { 1, -2, 3, -4, 9, 5, -14 };
        int naoExisteNaLista = 10;

        //Act
        bool resultado = _lista.ListaContemDeterminadoNumero(listaDeNumeros, naoExisteNaLista);

        //Assert
        Assert.False(resultado);

    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //Arrange 
        List<int> listaDeNumeros = new List<int>() { 1, -2, 3, -4, 9, 5, -14 };
        int num = 2;

        List<int> listaDeNumerosDobrados = new List<int>() { 2, -4, 6, -8, 18, 10, -28 };

        //Act
        List<int> resultado = _lista.MultiplicarNumerosLista(listaDeNumeros, num);

        //Assert
        Assert.Equal(listaDeNumerosDobrados, resultado);


    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //Arrange
        List<int> listaDeNumeros = new List<int>() { 1, 2, 3, -5, -14, 7, 9 };

        //Act
        int resultado = _lista.RetornarMaiorNumeroLista(listaDeNumeros);

        //Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
    {
        //Arrange
        List<int> listaDeNumeros = new List<int>() { 1, 2, 3, -5, -8, 7, 9 };

        //Act
        int resultado = _lista.RetornarMenorNumeroLista(listaDeNumeros);

        //Assert
        Assert.Equal(-8, resultado);
    }
}
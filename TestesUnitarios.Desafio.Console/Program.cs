// using System;
using TestesUnitarios.Desafio.Console.Services;

// namespace TestesUnitarios.Desafio.Console
// {
//   class Program
//   {
//     static void Main(String[] args)
//     {
//        List<int> numerosLista = new List<int>() { 10, 20, 30 };

//        ValidacoesLista lista = new ValidacoesLista();

//        lista.RemoverNumerosNegativos(numerosLista);


//     }
//   }
// }

List<int> numerosLista = new List<int>() { 10, -20, 30, -50, 15, 98, -7 };

ValidacoesLista lista = new ValidacoesLista();

List<int> listaPositiva = lista.RemoverNumerosNegativos(numerosLista);

// foreach (int item in listaPositiva)
// {
//   Console.WriteLine(item);

// }

bool containNumber = lista.ListaContemDeterminadoNumero(numerosLista, 7);

// Console.WriteLine(containNumber);

List<int> newList = lista.MultiplicarNumerosLista(numerosLista, 2);

// foreach (int item in newList)
// {
//   Console.WriteLine(item);

// }

// Console.WriteLine(newList);

int maiorNumero = lista.RetornarMaiorNumeroLista(numerosLista);
// Console.WriteLine(maiorNumero);

string saudacao = "Olá, Boa tarde.";

ValidacoesString texto = new ValidacoesString();

int numeroDeCaracteres = texto.RetornarQuantidadeCaracteres(saudacao);

// Console.WriteLine(numeroDeCaracteres);

bool contemPalavra = texto.ContemCaractere(saudacao, "TarDe");

// Console.WriteLine(contemPalavra);

bool terminaComPalavra = texto.TextoTerminaCom(saudacao, "Boa");

Console.WriteLine(terminaComPalavra);

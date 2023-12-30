using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> numList)
        {
            List<int> numerosPositivos = numList.Where(numero => numero > 0).ToList();
            return numerosPositivos;
        }

        public bool ListaContemDeterminadoNumero(List<int> numList, int num)
        {
            return numList.Contains(num);
        }

        public List<int> MultiplicarNumerosLista(List<int> numList, int num)
        {
            List<int> novaLista = numList.Select(numero => numero * num).ToList();
            return novaLista;
        }

        public int RetornarMaiorNumeroLista(List<int> numList)
        {
            int maiorNumeroDaLista = numList.Max();
            return maiorNumeroDaLista;
        }

        public int RetornarMenorNumeroLista(List<int> numList)
        {
            int menorNumeroDaLista = numList.Min();
            return menorNumeroDaLista;
        }
    }
}
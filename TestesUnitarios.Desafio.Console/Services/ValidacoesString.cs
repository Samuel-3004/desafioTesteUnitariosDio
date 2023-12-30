using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            int quantidadeDeCaracteres = texto.Length;
            return quantidadeDeCaracteres;
        }

        public bool ContemCaractere(string texto, string palavra)
        {
            bool contemPalavra = texto.Contains(palavra, StringComparison.OrdinalIgnoreCase);

            return contemPalavra;
        }

        public bool TextoTerminaCom(string texto, string palavra)
        {
            bool contemPalavra = texto.EndsWith(palavra, StringComparison.OrdinalIgnoreCase);

            return contemPalavra;
        }
    }
}
using System;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(funcaoRetornaQuantidadePOV(0.1M, 90)); //10
            Console.WriteLine(funcaoRetornaQuantidadePOV(0.1M, 100)); //11
            Console.WriteLine(funcaoRetornaQuantidadePOV(0.2M, 70)); //17
        }

        static decimal funcaoRetornaQuantidadePOV(decimal porcentagem, int totalNegociado)
        {
            var totalComEstrategia = (int)(totalNegociado / (1 - porcentagem));

            return (int)(totalComEstrategia * porcentagem);
        }
    }
}
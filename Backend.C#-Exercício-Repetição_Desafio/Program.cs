using System;

namespace Backend.C__Exercício_Repetição_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
           int numAnterior, numAtual, valor;
           numAnterior = 0;
           numAtual = 1;
           valor = 0;         

            // for (int fibonacci = 0; fibonacci >= 500; fibonacci++)
            for (var fibonacci = 0; fibonacci >= 500; valor = numAnterior + numAnterior)
            {
                // valor = numAnterior + numAnterior;
                numAnterior = numAtual;
                numAtual = valor;
                Console.WriteLine(valor);

                // n = (n - 1) + (n - 2);
            }
        }
    }
}

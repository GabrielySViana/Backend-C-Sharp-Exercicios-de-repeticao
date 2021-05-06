using System;

namespace Backend.C__Exercício1_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notaCorreta = false;

            while (notaCorreta == false)
            {
                Console.WriteLine("Digite uma nota entre 0 e 10: ");
                int nota = int.Parse (Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    Console.WriteLine("Concluído! Muito obrigado por sua avaliação.");
                    notaCorreta = true;

                } else
                {
                    Console.WriteLine("Por favor, informe um valor válido: ");
                }
            }
        }
    }
}

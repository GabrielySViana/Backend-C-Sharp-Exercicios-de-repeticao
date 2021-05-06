using System;

namespace Backend.C__Exercício3_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
            bool acessoValido = false;
            string senha;
            
            do
            {
                Console.WriteLine("Digite seu nome de usuário: ");
                string nome = Console.ReadLine().ToLower();

                Console.WriteLine("Digite uma senha: ");
                senha = Console.ReadLine().ToLower();

                if (nome != senha)
                {
                    Console.WriteLine("Acesso concluído.");
                    acessoValido = true;

                } else {
                    Console.WriteLine("Erro! Senha inválida [A senha não pode ser igual ao nome de usuario]");                
                }

            } while (acessoValido == false); 


            // bool acessoValido = false;
            // string senha; 
            // string nome; 

            //     Console.WriteLine("Digite seu nome de usuário: ");
            //     nome = Console.ReadLine();

            //     Console.WriteLine("Digite uma senha: ");
            //     senha = Console.ReadLine();

            // while (acessoValido == false)
            // {
            //     if (nome != senha)
            //     {
            //         Console.WriteLine("Acesso concluído.");
            //         acessoValido = true;

            //     } else {
            //         Console.WriteLine("Erro, senha inválida. A senha não pode ser igual ao nome de usuario!");
            //     }
            // } 
                
        }
    }
}

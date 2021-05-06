using System;

namespace Backend.C__Exercício2_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // Nome: Diferente de vazio;
           bool nomeValido = false;

            do
            {
                Console.WriteLine("insira o seu nome: ");
                string nome = Console.ReadLine();

                if (nome != "")
                {
                    Console.WriteLine("Nome validado!");
                    nomeValido = true;

                } else
                {
                    Console.WriteLine("insira um nome válido.");
                }

            } while (nomeValido == false);



        // Idade: entre 0 e 150;
            bool idadeValida = true;

            do
            {
                Console.WriteLine("insira a sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                    // if (idade == "")
                    // {
                    //     Console.WriteLine("insira um nome válido.");
                    // }

                if (idade < 0 || idade >= 150)
                {
                    Console.WriteLine(idade + " anos");
                } 

            }  while (idadeValida == false);


              
        // Salário: maior que zero;
            bool salarioValido = false;

            do {

                Console.WriteLine("insira o seu salário: ");
                float salario = float.Parse(Console.ReadLine());
                Console.WriteLine(salario.ToString("C") + " reais");

                // if (salario == "")
                // {
                //     Console.WriteLine("É preciso prencher um valor.");

                // }

                if (salario < 0)
                {
                    Console.WriteLine(salario.ToString("C") + " reais");
                    salarioValido = true;

                }
                
            }  while (salarioValido == true);
            

    
        // Estado Civil: 's', 'c', 'v', 'd';
            bool estadoCivilCheck = true;

            do
            {
                Console.WriteLine("insira o seu estado civil (s/c/v/d): ");
                string estadoCivil = Console.ReadLine().ToLower(); 
                
                if (estadoCivil == "s")
                {
                    Console.WriteLine("Estado civil: Solteiro(a)");
                } 
                
                else if (estadoCivil == "c")
                {
                    Console.WriteLine("Estado civil: Casado(a)");
                }

                else if (estadoCivil == "v")
                {
                    Console.WriteLine("Estado civil: Viúvo(a)");
                }

                else if (estadoCivil == "d")
                {
                    Console.WriteLine("Estado civil: Divorciado(a)");
                }

            } while (estadoCivilCheck == false);



            // bool estadoCivilCheck = true;
            // string estadoCivil;
            

            // while (estadoCivilCheck == false)
            // {
                    
            //     Console.WriteLine("insira o seu estado civil (s/c/v/d): ");
            //     estadoCivil = Console.ReadLine().ToLower();  
             
            //     if (estadoCivil == "s")
            //     {
            //         Console.WriteLine("Estador civil: Solteiro(a)");
            //     } 
                
            //     else if (estadoCivil == "c")
            //     {
            //         Console.WriteLine("Estador civil: Casado(a)");
            //     }

            //     else if (estadoCivil == "v")
            //     {
            //         Console.WriteLine("Estador civil: Viúvo(a)");
            //     }

            //     else if (estadoCivil == "d")
            //     {
            //         Console.WriteLine("Estador civil: Divorciado(a)");
            //     }
                
            // } while (estadoCivilCheck == true);
                
        }
    }
}

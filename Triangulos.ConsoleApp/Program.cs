using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        /*
        • Equilátero: Todos os lados iguais
        • Isósceles: Dois lados iguais
        • Escaleno: Todos os lados diferentes

        Caso algum comprimento dos lados do triângulo for inválido, escrever a mensagem “Triângulo Inválido”

        Para construir um triângulo é necessário que a medida de qualquer um dos lados seja menor que a soma dos outros dois lados
        O usuário poderá verificar vários triângulos, ou seja, crie um menu de opções que possibilite isso.

         */
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Digite 1 para Verificar Triângulos");
                Console.WriteLine("Digite S para Sair");

                opcao = Console.ReadLine();
                if (opcao == "s")
                    break;
                else if (opcao != "1")
                    Console.WriteLine("Opção Inválida");                    
                
                if (opcao == "1")
                {
                    Console.WriteLine("Digite o primeiro valor: ");
                    var x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor: ");
                    var y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro valor: ");
                    var z = Convert.ToInt32(Console.ReadLine());

                    if (x + y < z)
                    {
                        Console.WriteLine("Triângulo Inválido");
                    }
                    else if (y + z < x)
                    {
                        Console.WriteLine("Triângulo Inválido");
                    }
                    else if (x + z < y)
                    {
                        Console.WriteLine("Triângulo Inválido");
                    }
                    else
                    {
                        if (x == y && y == z && x == z)
                        {
                            Console.WriteLine("Triângulo Equilátero");
                        }
                        else if (x == y || y == z || z == x)
                        {
                            Console.WriteLine("Triângulo Isósceles");
                        }
                        else if (x != y && y != z && x != z)
                        {
                            Console.WriteLine("Triângulo Escaleno");
                        }
                    }
                    Console.ReadLine();
                }                
            }while (opcao != "s");
            
        }
    }
}

using System;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Usuário Menor de Idade");
            }
            else
            {
                Console.WriteLine("Usuário Maior de Idade");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um Programa que realize a taboada do 0 ao 10 de um Numero digitado pelo Usuário

            Console.WriteLine("Digite um Numero e veja a Taboada: ");

            int Numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("O Numero digitado foi: " + Numero);
            Console.WriteLine("O Resultado da Taboada de " + Numero + " é:" + '\n');

            Console.WriteLine(Numero + " + 0 = " + (Numero * 0));
            Console.WriteLine(Numero + " + 1 = " + (Numero * 1));
            Console.WriteLine(Numero + " + 2 = " + (Numero * 2));
            Console.WriteLine(Numero + " + 3 = " + (Numero * 3));
            Console.WriteLine(Numero + " + 4 = " + (Numero * 4));
            Console.WriteLine(Numero + " + 5 = " + (Numero * 5));
            Console.WriteLine(Numero + " + 6 = " + (Numero * 6));
            Console.WriteLine(Numero + " + 7 = " + (Numero * 7));
            Console.WriteLine(Numero + " + 8 = " + (Numero * 8));
            Console.WriteLine(Numero + " + 9 = " + (Numero * 9));
            Console.WriteLine(Numero + " + 10 = " + (Numero * 10) + '\n');

            Console.WriteLine("Taboada Finalidada!");

            Console.ReadLine();
        }
    }
}

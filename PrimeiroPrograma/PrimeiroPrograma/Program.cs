using System;

namespace PrimeiroCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            String idadeUsuario = Console.ReadLine();

            Console.WriteLine("Olá, Seja Bem-Vindo " + nomeUsuario + " Sua Idade é: " + idadeUsuario);

            Console.ReadLine();
        }
    }
}

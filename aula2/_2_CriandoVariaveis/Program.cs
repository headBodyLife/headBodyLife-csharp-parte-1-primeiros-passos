﻿using System;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - criando variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);
            Console.WriteLine("Terminando Execução");
        }
    }
}
﻿using System;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");
            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);
        }
    }
}
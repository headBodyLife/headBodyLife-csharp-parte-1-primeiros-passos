﻿using System;

namespace _P13_ForEncadeado
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");
            // *
            // **
            // ***
            // ****

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    
                    if (contadorColuna >= contadorLinha)
                    {
                        Console.WriteLine();
                        break;
                    }

                    
                }
                
            }
        }
    }
}
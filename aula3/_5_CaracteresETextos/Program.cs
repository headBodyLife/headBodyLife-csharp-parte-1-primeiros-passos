using System;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - caracteres e textos");
            //Character
            
            //Representa um caractere, só funcionando com aspas simples, não pode ser vazia
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            
            //usando cast
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);
            
            //--------------------
            //Texto String

            string titulo = "Alura cursos de tecnologia " + 2020;
            string cursosProgramacao = @"- .NET 
- Java 
- Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            
            
        }
    }
}
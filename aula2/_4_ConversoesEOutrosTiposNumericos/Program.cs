using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            
            double salario;
            salario = 1200.50;
            Console.WriteLine(salario);
            
            //int para numeros de 32 bits
            //cast para converter
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);
            
            //long para numeros de 64 bits
            long idade= 1300000000000;
            Console.WriteLine(idade);
            
            //short para numeros de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);
            
            //float tem menor precisão
            float altura = 1.80f;
            Console.WriteLine(altura);
            
        }
    }
}
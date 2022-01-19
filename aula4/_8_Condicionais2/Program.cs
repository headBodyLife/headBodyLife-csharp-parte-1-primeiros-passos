using System;

namespace _8_Condicionais2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                
                Console.WriteLine("Executando projeto 8 - Condicionais com Booleano");
                int idadeJoao = 16;
                //int quantidadePessoa = 2;
                //bool acompanhado = quantidadePessoa >= 2;
                bool acompanhado = true;
                
                // or || and && 
                if (idadeJoao >= 18 && acompanhado == true)
                {
                    Console.WriteLine("Pode entrar");
                }
                else
                {
                    Console.WriteLine("Não pode entrar");
                }
            }
        }
    }
}
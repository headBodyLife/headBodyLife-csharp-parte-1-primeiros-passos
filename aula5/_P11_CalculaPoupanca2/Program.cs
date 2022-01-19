using System;

namespace _P11_CalculaPoupanca2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");
            double valorInvestido = 1000;
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Apos o {0} mês(es), " +
                                  "você terá {1}", contadorMes,valorInvestido);
            }
        }
    }
}
using System;

namespace _P10_CalculaPoupanca
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - calcula poupança");
            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após {0}  meses, você terá {1}",contadorMes,valorInvestido);
                contadorMes ++;
            }
            
            //0.36% = 0.0036
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 1 mês, você terá R$ "+valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.003;
            Console.WriteLine("Após 2 meses, voce terá R$ "+valorInvestido);
        }
    }
}
using System;
using System.Runtime.InteropServices;

namespace _P12_CalculaInvestimentoAoLongoPrazo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Executando o projeto 12");
            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;
            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao terminoo do investimento, você terá R$ "+ valorInvestido);
        }
        
    }
}
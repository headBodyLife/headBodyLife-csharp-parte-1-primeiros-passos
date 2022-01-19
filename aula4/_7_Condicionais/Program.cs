    using System;

    namespace _7_Condicionais
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Executando projeto 7 - Condicionais");
                int idadeJoao = 16;
                int quantidadePessoa = 2;

                if (idadeJoao >= 18)
                {
                    Console.WriteLine("João possui idade maior que 18 anos. Pode entrar");
                }
                else
                {
                    if (quantidadePessoa >= 2)
                    {
                        Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado de um " +
                                          "responsável.");
                    }else
                    {
                        Console.WriteLine("João não possui idade de 18 anos ou mais");
                    }
                }
            }
        }
    }
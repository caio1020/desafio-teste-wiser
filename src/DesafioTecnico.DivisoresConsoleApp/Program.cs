using DesafioTecnico.Core.Service;
using System;
using System.Collections.Generic;

namespace DesafioTecnico.DivisoresConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MontarTela();
        }

        public static void MontarTela()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================");
            Console.WriteLine("Escolha uma opçao:");
            Console.WriteLine("1 - Calcular divisores que compoem um número");
            Console.WriteLine("2 - Calcular divisores primos que compoem um número.");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("========================================================================================================");
            Console.Write("\r\nDigite o número da opçao desejada: ");

            DivisorService divisorService = new DivisorService();

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        int numero = ObterEntradaDoNumero();
                        List<long> resultado = divisorService.Calcular(numero, false);
                        Console.WriteLine($"O Resultado final é: {string.Join(",", resultado)}");
                    }
                    break;
                case "2":
                    {
                        int numero = ObterEntradaDoNumero();
                        List<long> resultado = divisorService.Calcular(numero, true);
                        Console.WriteLine($"O Resultado final é: {string.Join(",", resultado)}");
                    }
                    break;
                default:
                    Console.Write("Volte logo!");
                    break;
            }
        }

        public static int ObterEntradaDoNumero()
        {
            try
            {
                Console.Write("\r\nDigite o número para  realizar o calculo: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                return 0;
            }
        }
    }
}

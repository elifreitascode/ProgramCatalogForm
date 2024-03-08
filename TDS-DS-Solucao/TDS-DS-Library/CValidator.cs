using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS_DS_Library
{
    public class CValidator
    {
        CTitle cTitle = new CTitle();
        public void ExecutePositiveOrNegative() {
            
            bool continua = true;

            while (continua)
            {
                // limpa a tela
                Console.Clear();

                // exibe o titulo desta tela
                cTitle.ExecuteTitle(" Validador de numero positivo ou negativo");

                // pede um numero ao usuario
                Console.Write("\nDigite um numero: ");
                double num = Convert.ToDouble(Console.ReadLine());

                // validador de numero positivo ou negativo
                if (num > 0)
                {
                    Console.WriteLine($"O número {num}, é um número positivo !");
                }
                else if (num == 0)
                {
                    Console.WriteLine($" ZERO !");
                }
                else
                {
                    Console.WriteLine($"O número {num}, é um número negativo !");
                }

                bool repete = true;

                while (repete)
                {

                    ConsoleKeyInfo outroCalculo = cTitle.ExecuteTitleRepeat();

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    switch (outroCalculo.Key)
                    {
                        case ConsoleKey.S:
                            continua = true;
                            repete = false;
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            continua = false;
                            repete = false;
                            break;
                        default:
                            Console.WriteLine(" ");
                            cTitle.ExecuteInvalidOption();
                            break;
                    }
                }
            }
        }
        public void ExecuteValidatorPrime()
        {
            bool continua = true;

            while (continua)
            {
                // limpa a tela
                Console.Clear();

                // exibe o titulo desta tela
                cTitle.ExecuteTitle("\tValidador de numeros primos");

                // pede um numero ao usuario
                Console.Write("\nDigite um numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                // validador de numeros primos
                if (EPrimo(num))
                {
                    Console.WriteLine($"\n{num} é um número primo");
                }
                else
                {
                    Console.WriteLine($"\n{num} não é um número primo");
                }

                bool repete = true;

                while (repete)
                {
                    ConsoleKeyInfo outroCalculo = cTitle.ExecuteTitleRepeat();

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    switch (outroCalculo.Key)
                    {
                        case ConsoleKey.S:
                            continua = true;
                            repete = false;
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            continua = false;
                            repete = false;
                            break;
                        default:
                            Console.WriteLine(" ");
                            cTitle.ExecuteInvalidOption();
                            break;
                    }
                }
            }
        }
        private static bool EPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

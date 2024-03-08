using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS_DS_Library
{
    public class CComparator
    {
        CTitle cTitle = new CTitle();   
        public void ExecuteNumberComparatorSimple()
        {
            bool continua = true;

            while (continua)
            {
                // Limpa o console
                Console.Clear();

                // Titulo desta tela
                cTitle.ExecuteTitle("\tComparador simples de números\t");

                // Pede ao usuario os numeros para comparação
                Console.Write("\nDigite o primeiro numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine($"\n{num1} é maior que {num2}, portanto o primeiro numero é maior que o segundo ");
                }
                else if (num2 > num1)
                {
                    Console.WriteLine($"\n{num2} é maior que {num1},  portanto o segundo numero é maior que o primeiro");
                }
                else
                {
                    Console.WriteLine($"\nOS NÚMEROS SÃO IGUAIS !!");
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
                            cTitle.ExecuteInvalidOption(); ;
                            break;
                    }
                }
            }
        }
        public void ExecuteNumberComparator()
        {
            bool continua = true;

            while (continua)
            {
                // Limpa o console
                Console.Clear();

                // Titulo desta tela
                cTitle.ExecuteTitle("\t  Comparador de números\t");

                // Inicializa as variaveis que vão receber o maior e o menor valor;
                int maiorNum = 0;

                Console.Write("Digite 1° número: ");
                int menorNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 2; i++)
                {
                    // Pede ao usuario um numero
                    Console.Write($"Digite o {i + 1}° numero:  ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    if (num1 > maiorNum)
                    {
                        maiorNum = num1;

                    }
                    if (num1 < menorNum)
                    {
                        menorNum = num1;
                    }
                }
                Console.WriteLine($"\nMAIOR NÚMERO: {maiorNum} ");
                Console.WriteLine($"MENOR NÚMERO: {menorNum}");

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
    }
}

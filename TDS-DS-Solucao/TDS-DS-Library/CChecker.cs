using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS_DS_Library
{
    public class CChecker
    {
        CTitle cTitle = new CTitle();

        public void ExecuteOddorPair()
        {
            bool continua = true;

            while (continua)
            {
                // limpa o console 
                Console.Clear();

                // O titulo desta tela
                cTitle.ExecuteTitle("    Verificador de número impar ou par");

                // Pede ao usuario um numero para a verificacao
                Console.Write("\nDigite um numero: ");

                int num = Convert.ToInt32(Console.ReadLine());

                // condição para verificação de numero par ou impar
                if (num % 2 == 0)
                {
                    Console.WriteLine($"\nO número {num}, é um numero PAR !");
                }
                else
                {
                    Console.WriteLine($"\nO número {num}, é um numero IMPAR !");
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
        public void ExecuteAgeCheck()
        {
            bool continua = true;

            while (continua)
            {
                // limpa a tela
                Console.Clear();
                // titulo desta tela
                cTitle.ExecuteTitle("\t  Verificador de idade");

                // pede ao usuario a idade dele
                Console.Write("\nDigite sua idade: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // faz a verificação da maioridade
                if (age >= 18)
                {
                    Console.WriteLine("Você é maior de idade !");
                }
                else
                {
                    Console.WriteLine("Você é menor de idade !");
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

        public void ExecuteLeapYearChecker()
        {
            bool continua = true;

            while (continua)
            {
                // limpa a tela
                Console.Clear();

                // exibe o titulo desta tela
                cTitle.ExecuteTitle("\tVerificador de ano bissexto");

                // pede para o usuario inserir o ano
                Console.Write("\nInsira o ano: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                // Verifica se o ano é divisel por 4
                if (ano % 4 == 0)
                {
                    Console.WriteLine($"{ano} é um ano bissexto");
                }
                else
                {
                    Console.WriteLine($"{ano} não é um ano bissexto");
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
    }
}

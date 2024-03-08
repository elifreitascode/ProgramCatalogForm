using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS_DS_Library
{
    public class CCalculate
    {
        CTitle cTitle = new CTitle();

        public int a;
        public int b;
        public int c;
        public void Execute(int a,int b,int c) {
            
            this.a = a;
            this.b = b;
            this.c = c;
            
            Console.Clear();
            Console.WriteLine("---");
            Console.WriteLine("Valor de a: " + a.ToString());
            Console.WriteLine("Valor de b: " + b);
            Console.WriteLine($"Valor de c: {c}");
            Console.WriteLine("\n---");
            Console.Write("Pressione uma tecla...");
            Console.ReadKey();
        }

        public void ExecuteCalculatorSimple()
        {
            bool continua = true;

            while (continua)
            {
                // Declaração de variáveis e inicialização com zero
                double num1 = 0;
                double num2 = 0;

                // Exibir o título desta tela
                Console.Clear();
                cTitle.ExecuteTitle("\tCalculadora simplificada\t");

                // Pede ao usuário para informar o primeiro número
                Console.Write("\nDigite um número e pressione \"Enter\": ");
                num1 = Convert.ToDouble(Console.ReadLine());

                // Pede ao usuário para informar o segundo número
                Console.Write("Digite outro número e pressione \"Enter\": ");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Pede ao usuário qual operação matemática
                Console.WriteLine(" ");
                Console.WriteLine("Escolha uma operação na lista abaixo: ");
                Console.WriteLine("  a) Adição");
                Console.WriteLine("  b) Subtração");
                Console.WriteLine("  c) Multiplicação");
                Console.WriteLine("  d) Divisão");
                Console.WriteLine("  e) Resto");
                Console.WriteLine(" ");
                Console.Write("Qual é a sua opção? ");

                ConsoleKeyInfo opcao = Console.ReadKey();

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------");
                Console.WriteLine(" ");

                switch (opcao.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine(string.Format("Adição => {0} + {1} = {2}", num1, num2, num1 + num2));
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine(string.Format("Subtração => {0} - {1} = {2}", num1, num2, num1 - num2));
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine(string.Format("Multiplicação => {0} x {1} = {2}", num1, num2, num1 * num2));
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine(string.Format("Divisão => {0} : {1} = {2}", num1, num2, num1 / num2));
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine(string.Format("Resto => {0} mod {1} = {2}", num1, num2, num1 % num2));
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Nenhum cálculo foi realizado.");
                        break;
                }

                //Console.Write("Pressione uma tecla...");

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
        public void ExecuteCalculatorIMC()
        {

            bool continua = true;

            while (continua)
            {
                // limpa a teela
                Console.Clear();

                // titulo desta tela
                cTitle.ExecuteTitle("\t  Calculadora de IMC");

                // pede ao usuario o peso e a altura
                Console.Write("\nDigite seu peso: ");
                double peso = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite sua altura: ");
                double altura = Convert.ToDouble(Console.ReadLine()) / 100;

                // calculo do IMC
                double IMC = peso / Math.Pow(altura, 2);

                // exibe o resultado para o usuario
                Console.WriteLine($"\nIMC: {IMC:N2}");

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
        public void ExecuteCalculatorAverage()
        {
            bool continua = true;
            double sumNota = 0;

            while (continua)
            {
                // limpa a teela
                Console.Clear();

                // titulo desta tela
                cTitle.ExecuteTitle("\tCalculadora de média escolar");

                // pede ao usuario o numero de notas para calculo
                Console.Write("\nNúmero de notas para cálculo de média: ");
                double numNota = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");

                // pede ao usuário a nota
                for (int i = 0; i < numNota; i++)
                {

                    Console.Write($"Insira a nota {i + 1}: ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    // soma as notas
                    sumNota = sumNota + nota;

                }
                // calculo da media dass notas
                double media = sumNota / numNota;

                // exibe o resultado da média
                Console.Write($"\nMédia atual: {media}");

                // exibe o resultado da aprovação
                if (media >= 6)
                {
                    Console.WriteLine("\nAPROVADO !");
                }
                else
                {
                    Console.WriteLine("\nREPROVADO !");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS_DS_Library
{
    public class CConverter
    {
        CTitle cTitle = new CTitle();
        public void ExecuteTemperatureConverter()
        {
            bool continua = true;

            while (continua)
            {
                // O titulo desta tela
                Console.Clear();
                cTitle.ExecuteTitle("\tConversor de temperatura");

                // pede ao usuario a temperatura
                Console.Write("\nDigite a temperatura: ");
                double temp = Convert.ToDouble(Console.ReadLine());

                // opção para o usuario escolher o tipo de conversão
                Console.WriteLine("\nEscolha uma opção para conversão");
                Console.WriteLine("\nA - Fahrenheit\nB - Celsius");
                Console.Write("\nQual é a sua opção ?");

                ConsoleKeyInfo option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.A:
                        temp = (temp * 1.8) + 32;
                        Console.WriteLine(string.Format("\nTemperatura: {0}°F", temp));
                        break;
                    case ConsoleKey.B:
                        temp = (temp - 32) / 1.79999999;
                        Console.WriteLine(string.Format("\nTemperatura: {0:N2}°C", temp));
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Console.WriteLine("Nenhuma conversão foi realizada.");
                        break;
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

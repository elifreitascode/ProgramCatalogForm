using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS_DS_Library
{
    public class CTitle
    {
        string title;
        public void ExecuteTitle(string title)
        {
            this.title = title;

            Console.WriteLine("===========================================");
            Console.WriteLine(title);
            Console.WriteLine("===========================================");
        }

        static ConsoleKeyInfo ReadConsoleKeyInfo(string msg)
        {
            Console.Write(msg);

            return Console.ReadKey();
        }

        public ConsoleKeyInfo ExecuteTitleRepeat()
        {
            return ReadConsoleKeyInfo("\n" +
                        "\n------------------------------" +
                        "\n" +
                        "\nDeseja repetir ? " +
                        "\n  s) Sim" +
                        "\n  n) Não" +
                        "\n " +
                        "\nQual é a sua opção? "
                     );
        }
        public void ExecuteTitlesMenu()
        {
            Console.WriteLine("### CATÁLOGO DE PROGRAMAS ### \n");
            Console.WriteLine("Opções disponíveis");
            Console.WriteLine("  0. Sair");
            Console.WriteLine("  1. Hello World");
            Console.WriteLine("  2. Cálculo de exemplo");
            Console.WriteLine("  3. Calculadora Simples");
            Console.WriteLine("  4. Verificador de Número Par ou Ímpar");
            Console.WriteLine("  5. Conversor de Temperatura");
            Console.WriteLine("  6. Verificador de idade");
            Console.WriteLine("  7. Calculadora de IMC");
            Console.WriteLine("  8. Validador de numeros negativos/positivos");
            Console.WriteLine("  9. Comparador de números simples");
            Console.WriteLine(" 10. Comparador de números");
            Console.WriteLine(" 11. Verificador de ano bissexto");
            Console.WriteLine(" 12. Validador de Números Primos");
            Console.WriteLine(" 13. Calculadora de média escolar");
            Console.WriteLine(" 14. Validador de CPF ou CNPJ");
            Console.WriteLine(" ");
            Console.Write("Escolha uma opção: ");
        }

        public void ExecuteInvalidOption()
        {
            Console.WriteLine("\n---");
            Console.Write("Opcao Inválida, pressione uma tecla...");
            Console.ReadKey();
        }


    }
}

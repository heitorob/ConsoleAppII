using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Insira o sinal da operação (+, -, *, /): ");
            string conta = Console.ReadLine();

            double c;

            if (conta == "+")
            {
                c = a + b;
                Console.WriteLine("O resultado da operação é " + c);
            }
            else if (conta == "-")
            {
                c = a - b;
                Console.WriteLine("O resultado da operação é " + c);
            }
            else if (conta == "*")
            {
                c = a * b;
                Console.WriteLine("O resultado da operação é " + c);
            }
            else if (conta == "/") 
            {
                c = a / b;
                Console.WriteLine("O resultado da operação é " + c);
            }
            else
            {
                Console.WriteLine("NÃO CONHEÇO ESSA OPERAÇÃO");
            }

            Console.ReadKey();
        }
    }
}

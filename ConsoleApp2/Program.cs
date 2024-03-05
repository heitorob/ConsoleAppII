using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do salário bruto: ");
            double bruto = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do vale-alimentação: ");
            double aliment = double.Parse(Console.ReadLine());

            Console.Write("Insira o número de filhos: ");
            
            int filhos = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor por filho: ");
            double vfilho = double.Parse(Console.ReadLine());

            Console.Write("Insira o número de horas extras: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor por hora extra: ");
            double vhora = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do desconto do INSS: ");
            double inss = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do desconto do IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double liquido = (bruto + aliment + (filhos * vfilho) + (horas * vhora)) - (inss + irpf);

            Console.WriteLine("Salário líquido: " + liquido.ToString("C"));
            Console.ReadKey();
        }
    }
}

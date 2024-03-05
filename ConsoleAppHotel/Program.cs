using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor da diária do hotel: ");
            double dhotel = double.Parse(Console.ReadLine());

            Console.Write("Insira o número de adultos: ");
            double adultos = double.Parse(Console.ReadLine());

            Console.Write("Insira o número de crianças: ");
            double criancas = double.Parse(Console.ReadLine());

            double diaria = (adultos * dhotel) + (criancas * (dhotel / 2));

            Console.WriteLine("A diária da viagem será de: " + diaria.ToString("C"));

            Console.Write("Insira o número de dias de hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            double total = diaria * dias;

            Console.WriteLine("O total da hospedagem será de: " + total.ToString("C"));

            Console.Write("Insira o número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            double vparcela = total / parcelas;

            Console.Write("O valor de cada parcela será de: " + vparcela.ToString("C"));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public static class Conversor
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return Math.Round((temperatura - 32) / 1.8, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura em Fahrenheit?");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = Conversor.FahrenheitParaCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F é equivale a {celsius}°C.");
        }
    }
}
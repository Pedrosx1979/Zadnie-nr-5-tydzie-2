using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadnie_nr_5_tydzień_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int age;
            double height;
            char sex;
            Console.WriteLine("Podaj swoje imię...");
            firstName = Console.ReadLine();
            Console.WriteLine($"Jesteś:{firstName}");
            Console.WriteLine("Podaj swój wzrost...");
            bool equal = double.TryParse(Console.ReadLine(), out  height);
            Console.WriteLine($"Masz {height} wzrostu");
            Console.WriteLine("Podaj swój wiek...");
            bool equal1 = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine($"Masz: {age} lat");
            Console.WriteLine("Podaj swoją płeć...(M lub K)");
            bool equal2 = char.TryParse(Console.ReadLine(), out sex);
            Console.WriteLine($"Twoje płeć to: {sex}");
        }

    }
}

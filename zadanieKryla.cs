using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5__kryła_
{
    class Program
    {
        static void Main(string[] args)
        {
            int podanaLiczba, suma = 0;
            do
            {
                Console.Write("Podaj jakąkolwiek liczbę całkowitą: ");
                podanaLiczba = int.Parse(Console.ReadLine());

                if (podanaLiczba % 2 != 0)
                {
                    suma += podanaLiczba;
                }
                Console.WriteLine("Aktualna suma liczb nieparzystych: {0}", suma);

                if (suma % 100 == 0)
                {
                    Console.WriteLine("Pętla zakończyła swoje zadanie.");
                }
            }
            while (suma % 100 != 0);
        }
    }
}

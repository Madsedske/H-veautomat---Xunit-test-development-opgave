using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat___Xunit_test_development_opgave
{
    public class Program
    {
        static Konto konto = new Konto("Mads", 63000, "1234");
        static PinkodeValidering pinkodeValidering = new PinkodeValidering();

        static void Main(string[] args)
        {
            Console.WriteLine("Pinkode?");
            string getPinkode = Console.ReadLine();
            pinkodeValidering.Validering(getPinkode);
            Console.WriteLine("Du har " + konto.Saldo + " kr stående på kontoen.");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Hvad er beløbet som skal hæves?");
            int getMoney = Convert.ToInt32(Console.ReadLine());
            Overførsel.Overfør(getMoney);

            Console.ReadKey();
        }
    }
}

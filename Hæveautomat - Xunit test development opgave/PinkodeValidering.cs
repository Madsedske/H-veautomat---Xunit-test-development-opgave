using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat___Xunit_test_development_opgave
{
    public class PinkodeValidering
    {
        public void Validering(string pinkode)
        {
            if (pinkode.Length == 4)            
                Console.WriteLine("Pinkode rigtig");            
            else
                Console.WriteLine("Pinkode forkert");
        }
    }
}

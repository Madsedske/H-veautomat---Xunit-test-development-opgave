using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat___Xunit_test_development_opgave
{
    public class Overførsel
    {
        static Konto konto;

        public static double Overfør(int getMoney)
        {
            return konto.Saldo - getMoney;            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat___Xunit_test_development_opgave
{
    public class Konto
    {
        public string Name { get; private set; }

        public int Saldo { get; private set; }

        public string Pinkode { get; private set; }

        public Konto(string name, int saldo, string pinkode)
        {
            Name = name;
            Saldo = saldo;
            Pinkode = pinkode;
        }
    }
}

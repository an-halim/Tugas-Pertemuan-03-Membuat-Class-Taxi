using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Object dan Class";
            Taxi taksi = new Taxi();
            taksi.Nama = "Ahmad Nur Halim";
            taksi.Ready = true;
            taksi.Passenger = 10;

            taksi.info();
            taksi.pickUp();
            taksi.dropDown();

            Console.ReadKey();
        }
    }
}

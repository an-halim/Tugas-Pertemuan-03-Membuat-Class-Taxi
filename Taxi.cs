using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        public string Nama { get; set; }
        public int Passenger { get; set; }
        public bool Ready { get; set; }
        public void info()
        {
            Console.WriteLine("Driver Name: {0}", Nama);
            if(Ready == true)
                Console.WriteLine("On Duty: Yes");
            else
                Console.WriteLine("On Duty: No");
            Console.WriteLine("Number Of Passenger: {0}\n", Passenger);
        }

        public void pickUp()
        {
            Console.WriteLine("{0} Sedang menjemput {1} penumpang!", Nama, Passenger);
        }
        public void dropDown()
        {
            Console.WriteLine("{0} Selesai mengantarkan {1} penumpang!", Nama, Passenger);
        }
    }
}

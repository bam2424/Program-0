using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program
    {
        // Precondition: NA
        // Postcondition: small list of parcels is created and displayed
        static void Main(string[] args)
        {

            Address address1 = new Address("Oi Bruv", "2392 Lauren Drive", "Apartment 23A", "Sun River", "MT", 59483);
            Address address2 = new Address("Patrick Skateman", "80 Grant Street", "Longview", "TX", 75604);
            Address address3 = new Address("Mate what", "1247 Watson Lane", "Floresville", "TX", 78114);
            Address address4 = new Address("Cmon Bruv", "278 Bee Street", "Grand Rapids", "MI", 49508);

            Letter letter1 = new Letter(address1, address2, 3.99M);
            Letter letter2 = new Letter(address1, address3, 4.99M);
            Letter letter3 = new Letter(address3, address4, 2.99M);
            Letter letter4 = new Letter(address4, address1, 5.99M);

            List<Parcel> letterList = new List<Parcel> { letter1, letter2, letter3, letter4 };

            foreach (Parcel parcel in letterList)
            {
                Console.WriteLine(parcel);
                Console.WriteLine("--------------------");
            }


            Console.WriteLine(address1.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartFour
{
     public struct Contact
    {

        public string FullName { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }

        public Contact (string fullname, string street, int house, int flat, string mobileNumber, string homeNumber)
        {
            this.FullName = fullname;
            this.Street = street;
            this.House = house;
            this.Flat = flat;
            this.MobileNumber = mobileNumber;
            this.HomeNumber = homeNumber;
        }

    }
}

// Primary UserID:	BAMATT07
// Student ID: 5243843
// Program 0 
// Due Date: 9/10/2022
// Class section : CIS-200-75-4228
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program0
{
    class Letter : Parcel
    {

        private decimal _fixedCost; 

        protected decimal FixedCost
        {

            get
            {
                return _fixedCost;
            }

            set
            {
                if (value >= 0)
                    _fixedCost = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FixedCost)} must be >=0");
            }
        }

        public Letter(Address letterOriginAddress, Address letterDestinationAddress, decimal fixedCost) : base(letterOriginAddress, letterDestinationAddress)
        {
            FixedCost = fixedCost;
        }

        public override decimal CalcCost()
        {
            return FixedCost;
        }

        public override string ToString() => $"{base.ToString()}\n\nCost: {CalcCost():C}";

    }
}
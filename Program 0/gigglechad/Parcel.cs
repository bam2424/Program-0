using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program0
{
    abstract class Parcel
    {
        private Address _originAddress;
        private Address _destinationAddress;


        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        public Address OriginAddress
        {
            get
            {
                return _originAddress;
            }
            set
            {
                _originAddress = value;
            }
        }

        public Address DestinationAddress
        {
            get
            {
                return _destinationAddress;
            }
            set
            {
                _destinationAddress = value;
            }
        }


        public abstract decimal CalcCost();
             


        public override string ToString()
        {
            return $"Origin: {OriginAddress} \n Destination: {DestinationAddress} \n Total Cost: {CalcCost()}";
        }
    }
}


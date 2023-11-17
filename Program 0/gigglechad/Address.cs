using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Address
    {
        public const int MIN_ZIP = 00000;
        public const int MAX_ZIP = 99999;

        private string _name;
        private string _address1;
        private string _address2;
        private string _city; 
        private string _state; 
        private int _zip;

        // precnon : name, address1, city, state may no be null, empty nor whitespace
        // postcon : the address us created with the specified values for name, address1, address2, city, state, and zipcode

        public Address(string name, string _address1, string _address2, string city, string state, int zip)
        {
            Name = name;
            Address1 = _address1;
            Address2 = _address2;
            City = city;
            State = state;
            Zip = zip;
        }

        public Address(string name, string _address1, string city, 
            string state, int zip) : this(name, _address1, string.Empty, city, state, zip)
        {
           // no body call 
           // calls preview const sending empty string for address2
        }

        public string Name
        {
            // Precondition: NA
            // Postcondition: address name return
            get
            {
                return _name;
            }

            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Name)} must not be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public string Address1
        {
            get
            {
                return _address1;
            }

            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address1)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public string Address2
        {
            // Precondition: NA
            // Postcondition: AddressLine2 is set to input value
            get
            {
                return _address2;
            }

            set
            {
                if (value == null)
                    value = string.Empty;
                _address2 = value.Trim();
            }
        }

        public string City
        {
            // Precondition: NA
            // Postcondition: The address city has been returned
            get
            {
                return _city;
            }

            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(City)} cannot be empty.");
                }
                else
                {
                    _city = trimmed;
                }
            }
        }

        public string State
        {
            // Precondition: NA
            // Postcondition: address state returned
            get
            {
                return _state;
            }

            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public int Zip
        {
            // Precondition: NA
            // Postcondition: Zip is set to input value
            get
            {
                return _zip;
            }

            set
            {
                if (value < MIN_ZIP || value > MAX_ZIP)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, 
                        $"{nameof(Zip)} must be U.S. 5 digits");
                }
                else
                {
                    _zip = value;
                }
            }
        }


        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result;

            result = $"{Name} {NL}{Address1}{NL}";   

            if (!string.IsNullOrWhiteSpace(Address2))
            {
                result += $"{Address2}{NL}";
            }

            result += $"{City}, {State}, {Zip:D5}";

            return result;

        }
    }
}


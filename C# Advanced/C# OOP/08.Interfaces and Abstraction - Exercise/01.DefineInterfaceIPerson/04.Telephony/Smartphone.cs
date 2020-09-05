using System;
using System.Linq;

namespace Telephony
{
    internal class Smartphone : ICallable, IBrowseable
    {
        public Smartphone()
        {
        }

        public string Browse(string address)
        {
            if (IsInvalidAddress(address))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {address}!";
        }

        public string Call(string phoneNumber)
        {
            if (IsInvalidPhoneNumber(phoneNumber))
            {
                return $"Invalid number!";
            }

            return $"Calling... {phoneNumber}";
        }

        private bool IsInvalidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Any(x => char.IsLetter(x));
        }

        private bool IsInvalidAddress(string address)
        {
            return address.Any(x => char.IsDigit(x));
        }
    }
}
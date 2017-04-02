using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson12
{
    public class PhoneNumber
    {
        // First part of a phone number: (XXX) 000-0000
        public string AreaCode { get; set; }

        // Second part of a phone number: (000) XXX-0000
        public string Exchange { get; set; }

        // Third part of a phone number: (000) 000-XXXX
        public string SubscriberNumber { get; set; }

        public override bool Equals(object value)
        {
            // Is null?
            if (Object.ReferenceEquals(null, value))
            {
                return false;
            }

            // Is the same object?
            if (Object.ReferenceEquals(this, value))
            {
                return true;
            }

            // Is the same type?
            if (value.GetType() != this.GetType())
            {
                return false;
            }

            return IsEqual((PhoneNumber)value);
        }

        private bool IsEqual(PhoneNumber number)
        {
            // A pure implementation of value equality that avoids the routine checks above
            // We use String.Equals to really drive home our fear of an improperly overridden "=="
            return String.Equals(AreaCode, number.AreaCode)
                && String.Equals(Exchange, number.Exchange)
                && String.Equals(SubscriberNumber, number.SubscriberNumber);
        }

        public override int GetHashCode() {
            int hash = 13;
            hash = (hash * 7) + (!Object.ReferenceEquals(null, AreaCode) ? AreaCode.GetHashCode() : 0);
            hash = (hash * 7) + (!Object.ReferenceEquals(null, Exchange) ? Exchange.GetHashCode() : 0);
            hash = (hash * 7) + (!Object.ReferenceEquals(null, SubscriberNumber) ? SubscriberNumber.GetHashCode() : 0);
            return hash;
        }

    }

}

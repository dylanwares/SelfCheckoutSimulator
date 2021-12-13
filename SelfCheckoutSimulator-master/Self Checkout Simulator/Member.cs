using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    class Member
    {
        int membershipNumber;
        string firstName;
        string lastName;
        string address;
        int membershipPoints;
        int membershipBarcode;

        public Member(int membershipNumber, string firstName, string lastName, string address, int membershipPoints, int membershipBarcode)
        {
            this.membershipNumber = membershipNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.membershipPoints = membershipPoints;
            this.membershipBarcode = membershipBarcode;
        }

        public int GetMembershipBarcode()
        {
            return membershipBarcode;
        }

        public string GetMembersName()
        {
            return firstName + " " + lastName;
        }

        public int GetMembershipNumber()
        {
            return membershipNumber;
        }

        public int GetMembersPoints()
        {
            return membershipPoints;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    static class MembersDAO
    {
        // membershipNumber, first name, last name, address, membership points, membership barcode
        private static List<Member> Members = new List<Member>
        {
            new Member(1, "Hannah", "Hughs", "113 Merthyr Road", 7151, 649758),
            new Member(2, "Riley", "Chapman", "45 Roman Rd", 5301, 784770),
            new Member(3, "Amber", "Vincent", "90 Temple Way", 2570, 361671),
            new Member(4, "Harry", "Owen", "122 Mounthoolie Lane", 8807, 457280),
            new Member(5, "Joseph", "Hargreaves", "38 Sutton Wick Lane", 9158, 826759),
            new Member(6, "Freya", "Nixon", "88 Scrimshire Lane", 6452, 712254)
        };

        public static Member SearchFromMembershipNumber(int membershipNumber)
        {
            return Members.Find(m => m.GetMembershipNumber() == membershipNumber);
        }       
    }
}

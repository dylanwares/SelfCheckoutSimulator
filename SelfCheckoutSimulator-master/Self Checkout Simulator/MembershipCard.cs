using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    class MembershipCard
    {
        private int barcode;
        private int membershipNumber;

        public MembershipCard(int barcode, int membershipNumber)
        {
            this.barcode = barcode;
            this.membershipNumber = membershipNumber;
        }

        public int GetMembershipNumber()
        {
            return membershipNumber;
        }

        public int GetBarcode()
        {
            return barcode;
        }
    }
}

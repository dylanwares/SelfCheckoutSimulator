using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout_Simulator
{
    static class MembershipCardDAO
    {
        private static List<MembershipCard> MembershipCards = new List<MembershipCard>
        {
            new MembershipCard(649758 , 1),
            new MembershipCard(784770 , 2),
            new MembershipCard(361671 , 3),
            new MembershipCard(457280 , 4),
            new MembershipCard(826759 , 5),
            new MembershipCard(712254 , 6),
        };

        public static MembershipCard GetMembershipCardFromBarcode(int barcode)
        {
            return MembershipCards.Find(m => m.GetBarcode() == barcode);
        }

        public static int GetRandomMembershipCardBarcode()
        {
            return MembershipCards[new Random().Next(0, MembershipCards.Count)].GetBarcode();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_Checkout_Simulator
{
    class SelfCheckout
    {
        // Attributes
        private Product currentProduct;
        private BaggingAreaScale baggingArea;
        private ScannedProducts scannedProducts;
        private Member currentMember;

        // Constructor
        public SelfCheckout(BaggingAreaScale baggingArea, ScannedProducts scannedProducts)
        {
            this.baggingArea = baggingArea;
            this.scannedProducts = scannedProducts;
        }

        // Operations
        public void BarcodeWasScanned(int barcode)
        {
            currentProduct = ProductsDAO.SearchUsingBarcode(barcode);

            scannedProducts.Add(currentProduct);

            baggingArea.SetExpectedWeight(scannedProducts.CalculateWeight());
        }

        public void MembershipWasScanned(int barcode)
        {
            MembershipCard currentCard = MembershipCardDAO.GetMembershipCardFromBarcode(barcode);
            currentMember = MembersDAO.SearchFromMembershipNumber(currentCard.GetMembershipNumber());
        }

        public void BaggingAreaWeightChanged()
        {
            // TO DO
        }

        public void UserPaid()
        {
            scannedProducts.Reset();

            baggingArea.Reset();

            currentMember = null;
        }

        public string GetPromptForUser()
        {
            // TO DO: Use the information we have to produce the correct message
            //       e.g. "Scan an item.", "Place item on scale.", etc.

            return "ERROR: UNKNOWN STATE";
        }

        public Product GetCurrentProduct()
        {
            return currentProduct;
        }

        public Member GetCurrentMember()
        {
            return currentMember;
        }

        public int CalculateMembersPoints()
        {
            return scannedProducts.CalculatePrice() * 10;
        }
    }
}
﻿namespace Self_Checkout_Simulator
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserScansBarcodeProduct = new System.Windows.Forms.Button();
            this.lbBasket = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUserPutsProductInBaggingAreaCorrect = new System.Windows.Forms.Button();
            this.btnUserCheckout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlScanProducts = new System.Windows.Forms.Panel();
            this.btnUserPutsProductInBaggingAreaIncorrect = new System.Windows.Forms.Button();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.btnUserScansMembershipCard = new System.Windows.Forms.Button();
            this.btnUserPaysForProducts = new System.Windows.Forms.Button();
            this.lblScreen = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbBaggingArea = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaggingAreaExpectedWeight = new System.Windows.Forms.Label();
            this.lblBaggingAreaCurrentWeight = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAdminOverridesWeight = new System.Windows.Forms.Button();
            this.gbMembership = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMembershipName = new System.Windows.Forms.Label();
            this.lblMembershipPoints = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlScanProducts.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbBaggingArea.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbMembership.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserScansBarcodeProduct
            // 
            this.btnUserScansBarcodeProduct.Location = new System.Drawing.Point(3, 3);
            this.btnUserScansBarcodeProduct.Name = "btnUserScansBarcodeProduct";
            this.btnUserScansBarcodeProduct.Size = new System.Drawing.Size(320, 88);
            this.btnUserScansBarcodeProduct.TabIndex = 0;
            this.btnUserScansBarcodeProduct.Text = "Scan a barcoded product";
            this.btnUserScansBarcodeProduct.UseVisualStyleBackColor = true;
            this.btnUserScansBarcodeProduct.Click += new System.EventHandler(this.UserScansProduct);
            // 
            // lbBasket
            // 
            this.lbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBasket.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasket.FormattingEnabled = true;
            this.lbBasket.Location = new System.Drawing.Point(6, 19);
            this.lbBasket.Name = "lbBasket";
            this.lbBasket.Size = new System.Drawing.Size(220, 264);
            this.lbBasket.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBasket);
            this.groupBox1.Location = new System.Drawing.Point(532, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scanned Products";
            // 
            // btnUserPutsProductInBaggingAreaCorrect
            // 
            this.btnUserPutsProductInBaggingAreaCorrect.Location = new System.Drawing.Point(3, 97);
            this.btnUserPutsProductInBaggingAreaCorrect.Name = "btnUserPutsProductInBaggingAreaCorrect";
            this.btnUserPutsProductInBaggingAreaCorrect.Size = new System.Drawing.Size(157, 41);
            this.btnUserPutsProductInBaggingAreaCorrect.TabIndex = 0;
            this.btnUserPutsProductInBaggingAreaCorrect.Text = "Put product in bagging area (correct weight)";
            this.btnUserPutsProductInBaggingAreaCorrect.UseVisualStyleBackColor = true;
            this.btnUserPutsProductInBaggingAreaCorrect.Click += new System.EventHandler(this.UserPutsProductInBaggingAreaCorrect);
            // 
            // btnUserCheckout
            // 
            this.btnUserCheckout.Location = new System.Drawing.Point(3, 144);
            this.btnUserCheckout.Name = "btnUserCheckout";
            this.btnUserCheckout.Size = new System.Drawing.Size(321, 58);
            this.btnUserCheckout.TabIndex = 0;
            this.btnUserCheckout.Text = "Checkout";
            this.btnUserCheckout.UseVisualStyleBackColor = true;
            this.btnUserCheckout.Click += new System.EventHandler(this.UserChoosesToCheckout);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlScanProducts);
            this.groupBox2.Controls.Add(this.pnlCheckout);
            this.groupBox2.Controls.Add(this.lblScreen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 296);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulate a Customer";
            // 
            // pnlScanProducts
            // 
            this.pnlScanProducts.Controls.Add(this.btnUserScansBarcodeProduct);
            this.pnlScanProducts.Controls.Add(this.btnUserPutsProductInBaggingAreaCorrect);
            this.pnlScanProducts.Controls.Add(this.btnUserPutsProductInBaggingAreaIncorrect);
            this.pnlScanProducts.Controls.Add(this.btnUserCheckout);
            this.pnlScanProducts.Location = new System.Drawing.Point(2, 88);
            this.pnlScanProducts.Name = "pnlScanProducts";
            this.pnlScanProducts.Size = new System.Drawing.Size(331, 207);
            this.pnlScanProducts.TabIndex = 2;
            // 
            // btnUserPutsProductInBaggingAreaIncorrect
            // 
            this.btnUserPutsProductInBaggingAreaIncorrect.Location = new System.Drawing.Point(166, 97);
            this.btnUserPutsProductInBaggingAreaIncorrect.Name = "btnUserPutsProductInBaggingAreaIncorrect";
            this.btnUserPutsProductInBaggingAreaIncorrect.Size = new System.Drawing.Size(157, 41);
            this.btnUserPutsProductInBaggingAreaIncorrect.TabIndex = 1;
            this.btnUserPutsProductInBaggingAreaIncorrect.Text = "Put product in bagging area (incorrect weight)";
            this.btnUserPutsProductInBaggingAreaIncorrect.UseVisualStyleBackColor = true;
            this.btnUserPutsProductInBaggingAreaIncorrect.Click += new System.EventHandler(this.UserPutsProductInBaggingAreaIncorrect);
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Controls.Add(this.btnUserScansMembershipCard);
            this.pnlCheckout.Controls.Add(this.btnUserPaysForProducts);
            this.pnlCheckout.Location = new System.Drawing.Point(2, 88);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(331, 207);
            this.pnlCheckout.TabIndex = 3;
            // 
            // btnUserScansMembershipCard
            // 
            this.btnUserScansMembershipCard.Location = new System.Drawing.Point(3, 3);
            this.btnUserScansMembershipCard.Name = "btnUserScansMembershipCard";
            this.btnUserScansMembershipCard.Size = new System.Drawing.Size(320, 88);
            this.btnUserScansMembershipCard.TabIndex = 0;
            this.btnUserScansMembershipCard.Text = "Scan a membership card";
            this.btnUserScansMembershipCard.UseVisualStyleBackColor = true;
            this.btnUserScansMembershipCard.Click += new System.EventHandler(this.UserScansMembershipCard);
            // 
            // btnUserPaysForProducts
            // 
            this.btnUserPaysForProducts.Location = new System.Drawing.Point(3, 144);
            this.btnUserPaysForProducts.Name = "btnUserPaysForProducts";
            this.btnUserPaysForProducts.Size = new System.Drawing.Size(321, 58);
            this.btnUserPaysForProducts.TabIndex = 0;
            this.btnUserPaysForProducts.Text = "Pay for products";
            this.btnUserPaysForProducts.UseVisualStyleBackColor = true;
            this.btnUserPaysForProducts.Click += new System.EventHandler(this.UserChoosesToPay);
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreen.Location = new System.Drawing.Point(6, 19);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(321, 61);
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "[SCREEN SIMULATION]";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbBaggingArea);
            this.groupBox3.Controls.Add(this.gbMembership);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(351, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal Data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalPrice);
            this.groupBox6.Location = new System.Drawing.Point(6, 113);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(158, 35);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(6, 16);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 13);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "[TOTAL PRICE]";
            // 
            // gbBaggingArea
            // 
            this.gbBaggingArea.Controls.Add(this.label2);
            this.gbBaggingArea.Controls.Add(this.label1);
            this.gbBaggingArea.Controls.Add(this.lblBaggingAreaExpectedWeight);
            this.gbBaggingArea.Controls.Add(this.lblBaggingAreaCurrentWeight);
            this.gbBaggingArea.Location = new System.Drawing.Point(6, 19);
            this.gbBaggingArea.Name = "gbBaggingArea";
            this.gbBaggingArea.Size = new System.Drawing.Size(158, 88);
            this.gbBaggingArea.TabIndex = 1;
            this.gbBaggingArea.TabStop = false;
            this.gbBaggingArea.Text = "Bagging Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected Weight";
            // 
            // lblBaggingAreaExpectedWeight
            // 
            this.lblBaggingAreaExpectedWeight.AutoSize = true;
            this.lblBaggingAreaExpectedWeight.Location = new System.Drawing.Point(6, 29);
            this.lblBaggingAreaExpectedWeight.Name = "lblBaggingAreaExpectedWeight";
            this.lblBaggingAreaExpectedWeight.Size = new System.Drawing.Size(117, 13);
            this.lblBaggingAreaExpectedWeight.TabIndex = 0;
            this.lblBaggingAreaExpectedWeight.Text = "[EXPECTED WEIGHT]";
            // 
            // lblBaggingAreaCurrentWeight
            // 
            this.lblBaggingAreaCurrentWeight.AutoSize = true;
            this.lblBaggingAreaCurrentWeight.Location = new System.Drawing.Point(6, 61);
            this.lblBaggingAreaCurrentWeight.Name = "lblBaggingAreaCurrentWeight";
            this.lblBaggingAreaCurrentWeight.Size = new System.Drawing.Size(113, 13);
            this.lblBaggingAreaCurrentWeight.TabIndex = 0;
            this.lblBaggingAreaCurrentWeight.Text = "[CURRENT WEIGHT]";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAdminOverridesWeight);
            this.groupBox5.Location = new System.Drawing.Point(351, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(170, 136);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Admin Controls";
            // 
            // btnAdminOverridesWeight
            // 
            this.btnAdminOverridesWeight.Location = new System.Drawing.Point(6, 19);
            this.btnAdminOverridesWeight.Name = "btnAdminOverridesWeight";
            this.btnAdminOverridesWeight.Size = new System.Drawing.Size(148, 111);
            this.btnAdminOverridesWeight.TabIndex = 2;
            this.btnAdminOverridesWeight.Text = "Override weight";
            this.btnAdminOverridesWeight.UseVisualStyleBackColor = true;
            this.btnAdminOverridesWeight.Click += new System.EventHandler(this.AdminOverridesWeight);
            // 
            // gbMembership
            // 
            this.gbMembership.Controls.Add(this.label3);
            this.gbMembership.Controls.Add(this.label4);
            this.gbMembership.Controls.Add(this.lblMembershipName);
            this.gbMembership.Controls.Add(this.lblMembershipPoints);
            this.gbMembership.Location = new System.Drawing.Point(6, 19);
            this.gbMembership.Name = "gbMembership";
            this.gbMembership.Size = new System.Drawing.Size(158, 88);
            this.gbMembership.TabIndex = 2;
            this.gbMembership.TabStop = false;
            this.gbMembership.Text = "Membership";
            this.gbMembership.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Members Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Member Name";
            // 
            // lblMembershipName
            // 
            this.lblMembershipName.AutoSize = true;
            this.lblMembershipName.Location = new System.Drawing.Point(6, 29);
            this.lblMembershipName.Name = "lblMembershipName";
            this.lblMembershipName.Size = new System.Drawing.Size(101, 13);
            this.lblMembershipName.TabIndex = 0;
            this.lblMembershipName.Text = "[MEMBERS NAME]";
            // 
            // lblMembershipPoints
            // 
            this.lblMembershipPoints.AutoSize = true;
            this.lblMembershipPoints.Location = new System.Drawing.Point(6, 61);
            this.lblMembershipPoints.Name = "lblMembershipPoints";
            this.lblMembershipPoints.Size = new System.Drawing.Size(110, 13);
            this.lblMembershipPoints.TabIndex = 0;
            this.lblMembershipPoints.Text = "[MEMBERS POINTS]";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 319);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self Checkout Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlScanProducts.ResumeLayout(false);
            this.pnlCheckout.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbBaggingArea.ResumeLayout(false);
            this.gbBaggingArea.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.gbMembership.ResumeLayout(false);
            this.gbMembership.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserScansBarcodeProduct;
        private System.Windows.Forms.ListBox lbBasket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUserPutsProductInBaggingAreaCorrect;
        private System.Windows.Forms.Button btnUserCheckout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBaggingAreaExpectedWeight;
        private System.Windows.Forms.Label lblBaggingAreaCurrentWeight;
        private System.Windows.Forms.GroupBox gbBaggingArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserPutsProductInBaggingAreaIncorrect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAdminOverridesWeight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Button btnUserScansMembershipCard;
        private System.Windows.Forms.Button btnUserPaysForProducts;
        private System.Windows.Forms.Panel pnlScanProducts;
        private System.Windows.Forms.GroupBox gbMembership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMembershipName;
        private System.Windows.Forms.Label lblMembershipPoints;
    }
}


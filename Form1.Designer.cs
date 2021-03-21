
using System.Windows.Forms;
using System;
using System.IO;
using System.Linq;

namespace CMIS214Ass4A
{
    partial class Form1
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
            this.btnCreatePremiumSki = new System.Windows.Forms.Button();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnCreateStandardSki = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.btnProfit = new System.Windows.Forms.Button();
            this.txtRetailPrice = new System.Windows.Forms.Label();
            this.txtProductNumber = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreatePremiumSki
            // 
            this.btnCreatePremiumSki.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePremiumSki.Location = new System.Drawing.Point(482, 331);
            this.btnCreatePremiumSki.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePremiumSki.Name = "btnCreatePremiumSki";
            this.btnCreatePremiumSki.Size = new System.Drawing.Size(423, 53);
            this.btnCreatePremiumSki.TabIndex = 0;
            this.btnCreatePremiumSki.Text = "Create Premium Ski";
            this.btnCreatePremiumSki.UseVisualStyleBackColor = true;
            this.btnCreatePremiumSki.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailPrice.Location = new System.Drawing.Point(526, 99);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(106, 51);
            this.lblRetailPrice.TabIndex = 1;
            this.lblRetailPrice.Text = "0.00";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNumber.Location = new System.Drawing.Point(526, 150);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(158, 51);
            this.lblProductNumber.TabIndex = 2;
            this.lblProductNumber.Text = "Not set";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(526, 201);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(165, 51);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Not Set";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(526, 252);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(165, 51);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Not Set";
            // 
            // btnCreateStandardSki
            // 
            this.btnCreateStandardSki.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStandardSki.Location = new System.Drawing.Point(50, 331);
            this.btnCreateStandardSki.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateStandardSki.Name = "btnCreateStandardSki";
            this.btnCreateStandardSki.Size = new System.Drawing.Size(423, 53);
            this.btnCreateStandardSki.TabIndex = 5;
            this.btnCreateStandardSki.Text = "Create Standard Ski";
            this.btnCreateStandardSki.UseVisualStyleBackColor = true;
            this.btnCreateStandardSki.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(185, 430);
            this.btnSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(288, 63);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItem.Location = new System.Drawing.Point(482, 430);
            this.btnReturnItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(288, 63);
            this.btnReturnItem.TabIndex = 7;
            this.btnReturnItem.Text = "Return";
            this.btnReturnItem.UseVisualStyleBackColor = true;
            this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrice.Location = new System.Drawing.Point(185, 523);
            this.btnUpdatePrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(288, 63);
            this.btnUpdatePrice.TabIndex = 8;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnProfit
            // 
            this.btnProfit.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfit.Location = new System.Drawing.Point(482, 523);
            this.btnProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(288, 63);
            this.btnProfit.TabIndex = 9;
            this.btnProfit.Text = "Profit Potential";
            this.btnProfit.UseVisualStyleBackColor = true;
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.AutoSize = true;
            this.txtRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetailPrice.Location = new System.Drawing.Point(218, 99);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(266, 51);
            this.txtRetailPrice.TabIndex = 10;
            this.txtRetailPrice.Text = "Retail Price: ";
            this.txtRetailPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.AutoSize = true;
            this.txtProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNumber.Location = new System.Drawing.Point(126, 150);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(347, 51);
            this.txtProductNumber.TabIndex = 11;
            this.txtProductNumber.Text = "Product Number:";
            // 
            // txtInventory
            // 
            this.txtInventory.AutoSize = true;
            this.txtInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(248, 201);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(225, 51);
            this.txtInventory.TabIndex = 12;
            this.txtInventory.Text = "# In Stock:";
            // 
            // txtProductName
            // 
            this.txtProductName.AutoSize = true;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(164, 252);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(309, 51);
            this.txtProductName.TabIndex = 13;
            this.txtProductName.Text = "Product Name:";
            // 
            // txtShopName
            // 
            this.txtShopName.AutoSize = true;
            this.txtShopName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtShopName.Font = new System.Drawing.Font("Ravie", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtShopName.Location = new System.Drawing.Point(261, 9);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(404, 79);
            this.txtShopName.TabIndex = 15;
            this.txtShopName.Text = "Skipolers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 646);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtProductNumber);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.btnProfit);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.btnReturnItem);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnCreateStandardSki);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.btnCreatePremiumSki);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreatePremiumSki;
        private Label lblRetailPrice;
        private Label lblProductNumber;
        private Label lblInventory;
        private Label lblProductName;
        private Button btnCreateStandardSki;
        private Button btnSale;
        private Button btnReturnItem;
        private Button btnUpdatePrice;
        private Button btnProfit;
        private Label txtRetailPrice;
        private Label txtProductNumber;
        private Label txtInventory;
        private Label txtProductName;
        private Label txtShopName;
    }
   

}


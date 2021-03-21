using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SkiPolersSkiShop
{
    public partial class MainForm : Form
    {
        String strProductName;
        double dblWholesalePrice;
        int intQuantityOnHand;
    
        public MainForm()
        {
            InitializeComponent();
            SwitchButtons(false);
        }
        Product product;
        
        private void button1_Click(object sender, EventArgs e)
        {
            PremiumSki premiumSki;
            InputInventory();
            premiumSki = new PremiumSki(strProductName, intQuantityOnHand, dblWholesalePrice);
            lblRetailPrice.Text = String.Format("{0:C}", Convert.ToInt32(premiumSki.RetailPrice));
            lblProductNumber.Text = premiumSki.ProductNumber.ToString();
            lblInventory.Text = premiumSki.QuantityOnHand.ToString();
            lblProductName.Text = premiumSki.ProductNume.ToString();
            product = premiumSki;
            SwitchButtons(true);
        }

        private void InputInventory()
        {
            strProductName = Interaction.InputBox("Enter the product name.");
            dblWholesalePrice = double.Parse(Interaction.InputBox("Enter the wholesale price."));
            intQuantityOnHand = Convert.ToInt32(Interaction.InputBox("Enter the quantity on hand."));
        }

        private void SwitchButtons(bool swap)
        {
            btnReturnItem.Enabled = swap;
            btnSale.Enabled = swap;
            btnUpdatePrice.Enabled = swap;
            btnProfit.Enabled = swap;
        }

        private void btnUpdateWholeSale_click(object sender, EventArgs e)
        {
            dblWholesalePrice = double.Parse(Interaction.InputBox("Enter the wholesale price."));
            product.UpdatePrice(dblWholesalePrice);
            lblRetailPrice.Text = product.RetailPrice.ToString();
        }

        private void btnStandardSki_click(object sender, EventArgs e)
        {
            StandardSki standardSki;
            InputInventory();
            standardSki = new StandardSki(strProductName, intQuantityOnHand, dblWholesalePrice);
            lblRetailPrice.Text = String.Format("{0:C}", Convert.ToInt32(standardSki.RetailPrice));
            lblProductNumber.Text = standardSki.ProductNumber.ToString();
            lblInventory.Text = standardSki.QuantityOnHand.ToString();
            lblProductName.Text = standardSki.ProductNume.ToString();
            product = standardSki;
            SwitchButtons(true);
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            product.ProfitFunction();
            MessageBox.Show(String.Format("{0:C}", Convert.ToInt32(product.PotentialProft)));
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            
            product.ReturnItem(Convert.ToInt32(Interaction.InputBox("Enter how many items to return")));
            lblInventory.Text = product.QuantityOnHand.ToString();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            product.BuyItem(Convert.ToInt32(Interaction.InputBox("Enter how many items to buy")));
            lblInventory.Text = product.QuantityOnHand.ToString();
        }

    }
}

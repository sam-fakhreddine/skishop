using System.Windows.Forms;

namespace SkiPolersSkiShop
{
    class PremiumSki : Product
    {
        public PremiumSki(string productName, int quantityOnHand, double wholesalePrice, long productNumber) :
   base(productName, quantityOnHand, wholesalePrice, productNumber)
        {

        }
        public override double UpdatePrice(double dblNewWholeSalePrice)
        {

            if (dblNewWholeSalePrice < 0)
            {
                MessageBox.Show("Price is less than 0. Price not changed.");
                return dblWholesalePrice;
            }
            else
            {
                double dblMarkUp = 0.35;
                dblWholesalePrice = dblNewWholeSalePrice;
                dblRetailPrice = dblWholesalePrice
                                 + (dblWholesalePrice * dblMarkUp);
                return dblRetailPrice;
            }
        }
    }
}
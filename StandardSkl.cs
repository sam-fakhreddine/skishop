using System.Windows.Forms;

namespace CMIS214Ass4A
{
    class StandardSki : Product
    {
        public StandardSki(string productName, int quantityOnHand, double wholesalePrice) :
           base(productName, quantityOnHand, wholesalePrice)
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
                double dblMarkUp = 0.20;
                dblWholesalePrice = dblNewWholeSalePrice;
                dblRetailPrice = dblWholesalePrice
                                 + (dblWholesalePrice * dblMarkUp);
                return dblRetailPrice;
            }
        }
    }

}
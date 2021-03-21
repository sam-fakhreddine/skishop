using System.Windows.Forms;

namespace CMIS214Ass4A
{
    class Product
    {
        private static long longProductNumber;
        private string strProductName;
        private int intQuantityOnHand;
        protected double dblWholesalePrice;
        protected double dblRetailPrice;
        protected double dblProfit;

        static Product()
        {
            longProductNumber = 1000;

        }
        public Product(string productName, int quantityOnHand, double wholesalePrice)
        {
            strProductName = productName;
            longProductNumber++;
            intQuantityOnHand = quantityOnHand;
            dblWholesalePrice = wholesalePrice;
            dblRetailPrice = UpdatePrice(wholesalePrice);
        }



        public long ProductNumber
        {
            get
            {
                return longProductNumber;
            }
        }

        public string ProductNume
        {
            get
            {
                return strProductName;
            }
        }

        public int QuantityOnHand
        {
            get
            {
                return intQuantityOnHand;
            }
            set
            {
                intQuantityOnHand = value;
            }
        }

        public double RetailPrice
        {
            get
            {
                return dblRetailPrice;
            }
        }

        public double PotentialProft
        {
            get
            {
                return dblProfit;
            }
        }

        public virtual void BuyItem(int purchase)
        {
            if (purchase > intQuantityOnHand)
            {
                MessageBox.Show("There are not enough items on hand. Quantity on Hand not changed");
            }

            else if (purchase <= 0)
            {
                MessageBox.Show("Purchase amount is less than 0. Quantity on Hand not changed");
            }
            else intQuantityOnHand -= purchase;
        }


        public virtual void ReturnItem(int intReturnItem)
        {
            if (intReturnItem <= 0)
            {
                MessageBox.Show("Returned amount is less than 0. Quantity on Hand not changed");
            }
            else intQuantityOnHand += intReturnItem;
        }

        public virtual double UpdatePrice(double dblNewWholeSalePrice)
        {
            if (dblNewWholeSalePrice < 0)
            {
                MessageBox.Show("Price is less than 0. Price not changed.");
                return dblWholesalePrice;
            }
            else
            {
                double dblMarkUp = 0.10;
                dblWholesalePrice = dblNewWholeSalePrice;
                dblRetailPrice = dblWholesalePrice
                                 + (dblWholesalePrice * dblMarkUp);
                return dblRetailPrice;
            }
        }

        public virtual void ProfitFunction()
        {
            dblProfit = (dblRetailPrice - dblWholesalePrice) * intQuantityOnHand;
        }

    }
}

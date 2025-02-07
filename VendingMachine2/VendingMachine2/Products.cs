using System;

namespace VendingMachine2
{
    internal class Products
    {
        public CoinSlot cs = new CoinSlot();
        Dictionary<string, int> merch = new Dictionary<string, int>();

        public void AddProduct(string product, string count)
        {
            merch.Add(product, count);
        }

        public bool Buy(string product, decimal price)
        {
            return false;
        }
    }
}
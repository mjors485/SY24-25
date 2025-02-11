using System;
using System.Collections.Generic;

namespace VendingMachine2
{
    internal class Products
    {
        private Dictionary<string, (double price, int stock)> inventory;

        public Products()
        {
            inventory = new Dictionary<string, (double price, int stock)>
            {
                { "Snickers", (1.50, 10) },
                { "Pepsi", (2.00, 10) },
                { "Lays", (1.75, 10) },
                { "Doritos", (1.75, 10) },
                { "Pretzels", (1.75, 10) },
                { "Pringles", (1.25, 10) },
                { "Cheetos", (1.75, 10) },
                { "Cheez-It", (1.25, 10) },
                { "Coca-Cola", (2.00, 10) },
                { "Twix", (1.50, 10) },
                { "Sprite", (2.00, 10) },
                { "Fanta", (2.00, 10) }
            };
        }

        public (double price, int stock) GetProductInfo(string product)
        {
            return inventory.TryGetValue(product, out var info) ? info : (0, 0);
        }

        public bool Buy(string product, double insertedMoney)
        {
            if (inventory.ContainsKey(product))
            {
                var (price, stock) = inventory[product];

                if (stock > 0 && insertedMoney >= price)
                {
                    inventory[product] = (price, stock - 1);
                    return true;
                }
            }
            return false;
        }

        public int GetStock(string product)
        {
            return inventory.TryGetValue(product, out var info) ? info.stock : 0;
        }
    }
}
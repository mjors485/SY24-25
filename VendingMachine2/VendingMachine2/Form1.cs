using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine2
{
    public partial class Form1 : Form
    {
        private CoinSlot coinSlot;
        private Products products;

        public Form1()
        {
            InitializeComponent();
            coinSlot = new CoinSlot();
            products = new Products();
            UpdateStockLabels();
        }

        private void showProduct(string productName, double productPrice)
        {
            labelProductName.Text = productName;
            labelProductPrice.Text = $"${productPrice:F2}";

            int stock = products.GetStock(productName);
            UpdateStockLabel(productName, stock);
        }

        private void UpdateStockLabel(string productName, int stock)
        {
            switch (productName)
            {
                case "Snickers":
                    SnickersStock.Text = stock.ToString();
                    break;
                case "Pepsi":
                    PepsiStock.Text = stock.ToString();
                    break;
                case "Lays":
                    LaysStock.Text = stock.ToString();
                    break;
                case "Doritos":
                    DoritosStock.Text = stock.ToString();
                    break;
                case "Pretzels":
                    PretzelsStock.Text = stock.ToString();
                    break;
                case "Pringles":
                    PringlesStock.Text = stock.ToString();
                    break;
                case "Cheetos":
                    CheetosStock.Text = stock.ToString();
                    break;
                case "Cheez-It":
                    CheezitStock.Text = stock.ToString();
                    break;
                case "Coca-Cola":
                    CokeStock.Text = stock.ToString();
                    break;
                case "Twix":
                    TwixStock.Text = stock.ToString();
                    break;
                case "Sprite":
                    SpriteStock.Text = stock.ToString();
                    break;
                case "Fanta":
                    FantaStock.Text = stock.ToString();
                    break;
            }
        }

        private void UpdateStockLabels()
        {
            string[] productNames =
            {
                "Snickers", "Pepsi", "Lays", "Doritos", "Pretzels",
                "Pringles", "Cheetos", "Cheez-It", "Coca-Cola",
                "Twix", "Sprite", "Fanta"
            };

            foreach (var product in productNames)
            {
                int stock = products.GetStock(product);
                UpdateStockLabel(product, stock);
            }
        }

        private string GetProductName(int index)
        {
            switch (index)
            {
                case 0:
                    return "Snickers";
                case 1:
                    return "Pepsi";
                case 2:
                    return "Lays";
                case 3:
                    return "Doritos";
                case 4:
                    return "Pretzels";
                case 5:
                    return "Pringles";
                case 6:
                    return "Cheetos";
                case 7:
                    return "Cheez-It";
                case 8:
                    return "Coca-Cola";
                case 9:
                    return "Twix";
                case 10:
                    return "Sprite";
                case 11:
                    return "Fanta";
                default:
                    return "";
            }
        }

        private void SnickersButton_Click(object sender, EventArgs e)
        {
            showProduct("Snickers", 1.50);
        }

        private void PepsiButton_Click(object sender, EventArgs e)
        {
            showProduct("Pepsi", 2.00);
        }

        private void LaysButton_Click(object sender, EventArgs e)
        {
            showProduct("Lays", 1.75);
        }

        private void DoritosButton_Click(object sender, EventArgs e)
        {
            showProduct("Doritos", 1.75);
        }

        private void PretzelsButton_Click(object sender, EventArgs e)
        {
            showProduct("Pretzels", 1.75);
        }

        private void PringlesButton_Click(object sender, EventArgs e)
        {
            showProduct("Pringles", 1.25);
        }

        private void CheetosButton_Click(object sender, EventArgs e)
        {
            showProduct("Cheetos", 1.75);
        }

        private void CheezitButton_Click(object sender, EventArgs e)
        {
            showProduct("Cheez-It", 1.25);
        }

        private void CokeButton_Click(object sender, EventArgs e)
        {
            showProduct("Coca-Cola", 2.00);
        }

        private void TwixButton_Click(object sender, EventArgs e)
        {
            showProduct("Twix", 1.50);
        }

        private void SpriteButton_Click(object sender, EventArgs e)
        {
            showProduct("Sprite", 2.00);
        }

        private void FantaButton_Click(object sender, EventArgs e)
        {
            showProduct("Fanta", 2.00);
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("nickel");
            UpdateTotalLabel();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dime");
            UpdateTotalLabel();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("quarter");
            UpdateTotalLabel();
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            coinSlot.InsertCoin("dollar");
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            labelTotal.Text = $"${coinSlot.Total():0.00}";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            coinSlot.CoinReturn();
            UpdateTotalLabel();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string productName = labelProductName.Text;
            var productInfo = products.GetProductInfo(productName);
            double price = productInfo.price;
            int stock = productInfo.stock;

            if (products.Buy(productName, coinSlot.Total()))
            {
                coinSlot.DeductAmount(price);
                labelMessage.Text = "Purchase successful!";


                UpdateTotalLabel();
                UpdateStockLabel(productName, products.GetStock(productName));
            }
            else
            {
                labelMessage.Text = "Not enough money or product out of stock.";
            }
        }
    }
}

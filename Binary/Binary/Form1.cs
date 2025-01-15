using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] bits = new int[8];
        int[] bitsB = new int[8];
        int[] bitsC = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            if (bits[0] != 0)
                total += 1;
            if (bits[1] != 0)
                total += 2;
            if (bits[2] != 0)
                total += 4;
            if (bits[3] != 0)
                total += 8;
            if (bits[4] != 0)
                total += 16;
            if (bits[5] != 0)
                total += 32;
            if (bits[6] != 0)
                total += 64;
            if (bits[7] != 0)
                total += 128;
            TotalLabel.Text = total.ToString();
        }

        private void Calc2()
        {
            if (bitsB[0] != 0)
                total += 1;
            if (bitsB[1] != 0)
                total += 2;
            if (bitsB[2] != 0)
                total += 4;
            if (bitsB[3] != 0)
                total += 8;
            if (bitsB[4] != 0)
                total += 16;
            if (bitsB[5] != 0)
                total += 32;
            if (bitsB[6] != 0)
                total += 64;
            if (bitsB[7] != 0)
                total += 128;
            TotalLabel2.Text = total.ToString();
        }

        private void Bit7_TextChanged(object sender, EventArgs e)
        {
            total = 0;

            if (Bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;

            if (Bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;

            if (Bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;

            if (Bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;

            if (Bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;

            if (Bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;

            if (Bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;

            if (Bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;

            Calc();
        }

        private void BitB3_TextChanged(object sender, EventArgs e)
        {
            total = 0;

            if (BitB1.Text == "1")
                bitsB[0] = 1;
            else
                bitsB[0] = 0;

            if (BitB2.Text == "1")
                bitsB[1] = 1;
            else
                bitsB[1] = 0;

            if (BitB3.Text == "1")
                bitsB[2] = 1;
            else
                bitsB[2] = 0;

            if (BitB4.Text == "1")
                bitsB[3] = 1;
            else
                bitsB[3] = 0;

            if (BitB5.Text == "1")
                bitsB[4] = 1;
            else
                bitsB[4] = 0;

            if (BitB6.Text == "1")
                bitsB[5] = 1;
            else
                bitsB[5] = 0;

            if (BitB7.Text == "1")
                bitsB[6] = 1;
            else
                bitsB[6] = 0;

            if (BitB8.Text == "1")
                bitsB[7] = 1;
            else
                bitsB[7] = 0;

            Calc2();
        }

        private void Bit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void BitB1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void ClearButtonA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            update();
        }

        private void update()
        {
            Bit1.Text = (bits[0] == 1 ? "1" : "0");
            Bit2.Text = (bits[1] == 1 ? "1" : "0");
            Bit3.Text = (bits[2] == 1 ? "1" : "0");
            Bit4.Text = (bits[3] == 1 ? "1" : "0");
            Bit5.Text = (bits[4] == 1 ? "1" : "0");
            Bit6.Text = (bits[5] == 1 ? "1" : "0");
            Bit7.Text = (bits[6] == 1 ? "1" : "0");
            Bit8.Text = (bits[7] == 1 ? "1" : "0");

            BitB1.Text = (bitsB[0] == 1 ? "1" : "0");
            BitB2.Text = (bitsB[1] == 1 ? "1" : "0");
            BitB3.Text = (bitsB[2] == 1 ? "1" : "0");
            BitB4.Text = (bitsB[3] == 1 ? "1" : "0");
            BitB5.Text = (bitsB[4] == 1 ? "1" : "0");
            BitB6.Text = (bitsB[5] == 1 ? "1" : "0");
            BitB7.Text = (bitsB[6] == 1 ? "1" : "0");
            BitB8.Text = (bitsB[7] == 1 ? "1" : "0");
        }
    }
}

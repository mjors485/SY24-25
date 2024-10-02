using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private Button getButton(int r, int c)
        {
            int idx = (r - 1) * 10 + (c - 1);
            return btnGrid[idx];
        }

        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }

        private void setCounts()
        {
            // for every tile on the board
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    getButton(r, c).BackColor = Color.Honeydew;
                }
            }
            // add one for each adjacent mine
            // set the count into the tile
        }

        private int countAdjacent(int r, int c)
        {
            int count = 0;
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c - 1))].GetMine()) count ++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c))].GetMine()) count++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r - 1, c + 1))].GetMine()) count++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(getButton(r, c - 1))].GetMine()) count++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(getButton(r, c + 1))].GetMine()) count++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r + 1, c - 1))].GetMine()) count++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c))].GetMine()) count++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c + 1))].GetMine()) count++;
            }
            return count;
        }

        private int CountFlags(int r, int c)
        {
            int count = 0;

            // Check all adjacent tiles around (r, c)
            if (r > 1 && c > 1 && tileGrid[getIndex(getButton(r - 1, c - 1))].GetFlag()) count++;
            if (r > 1 && tileGrid[getIndex(getButton(r - 1, c))].GetFlag()) count++;
            if (r > 1 && c < 10 && tileGrid[getIndex(getButton(r - 1, c + 1))].GetFlag()) count++;
            if (c > 1 && tileGrid[getIndex(getButton(r, c - 1))].GetFlag()) count++;
            if (c < 10 && tileGrid[getIndex(getButton(r, c + 1))].GetFlag()) count++;
            if (r < 10 && c > 1 && tileGrid[getIndex(getButton(r + 1, c - 1))].GetFlag()) count++;
            if (r < 10 && tileGrid[getIndex(getButton(r + 1, c))].GetFlag()) count++;
            if (r < 10 && c < 10 && tileGrid[getIndex(getButton(r + 1, c + 1))].GetFlag()) count++;

            return count;
        }

        private void button81_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            int index = getIndex(b);
            int row = (index / 10) + 1; // Converts index to corresponding row (1 to 10)
            int col = (index % 10) + 1; // Converts index to corresponding column (1 to 10)
            Tile t = tileGrid[getIndex(b)];
            
            if (e.Button == MouseButtons.Right)
                t.SetFlag();
            else if (e.Button == MouseButtons.Left)
                t.SetDug();
            else if (e.Button == MouseButtons.Middle)
                digAdjacent(row, col);


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                tileGrid[i].SetFlagImage(flagPictureBox.Image);
                tileGrid[i].SetMineImage(minePictureBox.Image);
                btnGrid[i].BackgroundImage = null;
                btnGrid[i].Text = null;
            }
            CreateMines(5);
            //countAdjacent(4, 5);
            for(int r = 1; r < 11; r++)
            {
                for(int c = 1; c < 11; c++)
                {
                    tileGrid[getIndex(getButton(r, c))].SetNearby(countAdjacent(r, c));
                }
            }
        }

        private void digAdjacent(int r, int c)
        {
            int flagCount = CountFlags(r, c);
            int actualMineCount = countAdjacent(r, c);

            // If the number of flags is equal to the number of actual mines
            if (flagCount == actualMineCount)
            {
                // Dig adjacent tiles (without digging flagged tiles)
                if (r > 1 && c > 1 && !tileGrid[getIndex(getButton(r - 1, c - 1))].GetFlag())
                    tileGrid[getIndex(getButton(r - 1, c - 1))].SetDug();

                if (r > 1 && !tileGrid[getIndex(getButton(r - 1, c))].GetFlag())
                    tileGrid[getIndex(getButton(r - 1, c))].SetDug();

                if (r > 1 && c < 10 && !tileGrid[getIndex(getButton(r - 1, c + 1))].GetFlag())
                    tileGrid[getIndex(getButton(r - 1, c + 1))].SetDug();

                if (c > 1 && !tileGrid[getIndex(getButton(r, c - 1))].GetFlag())
                    tileGrid[getIndex(getButton(r, c - 1))].SetDug();

                if (c < 10 && !tileGrid[getIndex(getButton(r, c + 1))].GetFlag())
                    tileGrid[getIndex(getButton(r, c + 1))].SetDug();

                if (r < 10 && c > 1 && !tileGrid[getIndex(getButton(r + 1, c - 1))].GetFlag())
                    tileGrid[getIndex(getButton(r + 1, c - 1))].SetDug();

                if (r < 10 && !tileGrid[getIndex(getButton(r + 1, c))].GetFlag())
                    tileGrid[getIndex(getButton(r + 1, c))].SetDug();

                if (r < 10 && c < 10 && !tileGrid[getIndex(getButton(r + 1, c + 1))].GetFlag())
                    tileGrid[getIndex(getButton(r + 1, c + 1))].SetDug();
            }
            else
            {
                // If flags are incorrect, dig all adjacent tiles including mines
                if (r > 1 && c > 1) tileGrid[getIndex(getButton(r - 1, c - 1))].SetDug();
                if (r > 1) tileGrid[getIndex(getButton(r - 1, c))].SetDug();
                if (r > 1 && c < 10) tileGrid[getIndex(getButton(r - 1, c + 1))].SetDug();
                if (c > 1) tileGrid[getIndex(getButton(r, c - 1))].SetDug();
                if (c < 10) tileGrid[getIndex(getButton(r, c + 1))].SetDug();
                if (r < 10 && c > 1) tileGrid[getIndex(getButton(r + 1, c - 1))].SetDug();
                if (r < 10) tileGrid[getIndex(getButton(r + 1, c))].SetDug();
                if (r < 10 && c < 10) tileGrid[getIndex(getButton(r + 1, c + 1))].SetDug();
            }
        }

        private void CreateMines(int numMines)
        {
            int mineCount = 0;
            // until we have enough mines
            while (mineCount < numMines)
            {
                // generate number from 1-100
                int rNum = random.Next(0, 100);

                // set mine on that tile if it doesn't already have a mine
                if (tileGrid[rNum].GetMine() == false)
                {
                    mineCount++;
                    tileGrid[rNum].SetMine(true);
                }
            }


        }
    }
}

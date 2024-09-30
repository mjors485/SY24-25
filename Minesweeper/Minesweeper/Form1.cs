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

        private void button81_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
                t.SetFlag();
            else
                t.SetDug();
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

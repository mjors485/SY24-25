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

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private Button getButton(int r, int c)
        {
            return (Button)getButton(r, c);
        }

        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }

        private void button81_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            t.SetFlag();
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
        }

        private void CreateMines(int numMines)
        {
            //until we have enough mines
            //generate number from 1-100
            // set mine on that tile if it doesn't already have a mine

        }
    }
}

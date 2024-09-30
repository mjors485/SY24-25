using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Tile
    {
        Button m_b;
        private Boolean m_flag;
        private Boolean m_dug;
        private Boolean m_mine;
        private int m_nearby;
        private Image m_flagImage;
        private Image m_mineImage;

        public void SetNearby(int n)
        {
            m_nearby = n;
            m_b.Text = m_nearby.ToString();
        }

        public void SetFlagImage(Image flagImage)
        { m_flagImage = flagImage; }

        public void SetMineImage(Image mineImage)
        { m_mineImage = mineImage; }

        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Green;
        }

        public void SetMine(Boolean b)
        { m_mine = b; }

        public Boolean GetMine() { return m_mine; }

        public void SetDug()
        { 
            m_dug = true;
            if (m_mine)
                m_b.BackgroundImage = m_mineImage;
        }

        public void SetFlag()
        {
            m_flag = !m_flag;
            if (m_flag)
            { m_b.BackgroundImage = m_flagImage; }
            else
            { m_b.BackgroundImage = null; }
        }

    }
}

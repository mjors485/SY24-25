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
        private Boolean m_adjacent;
        private int m_nearby;
        private Image m_flagImage;
        private Image m_mineImage;

        public int GetNearby() { return m_nearby; }

        public Boolean GetDug() { return m_dug; }

        public void SetNearby(int n)
        {
            m_nearby = n;
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
        {
            m_mine = b;
            //m_b.BackgroundImage = m_mineImage;
        }

        public Boolean GetMine() { return m_mine; }

        public Boolean GetFlag() { return m_flag; }

        public void SetDug()
        { 
            m_dug = true;
            m_b.Text = m_nearby.ToString();
            m_b.BackColor = Color.LightYellow;
            if (m_mine)
                m_b.BackgroundImage = m_mineImage;
        }

        public void SetFlag()
        {
            m_flag = !m_flag;
            if (m_flag)
            {
                m_b.BackgroundImage = m_flagImage;
            }
            else
            { m_b.BackgroundImage = null; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        WordBook wb = new WordBook();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            wb.Add(WordTextBox.Text, DefTextBox.Text);
            comboBox1.Items.Add(WordTextBox.Text);
            WordTextBox.Clear();
            DefTextBox.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefTextBox.Text = wb.GetDef(comboBox1.Text);
        }
    }
}

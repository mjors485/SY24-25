using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNGgame
{
    public partial class Form1 : Form
    {

        private int score;
        private bool isGameActive; // Add a flag to track the game state

        public Form1()
        {
            InitializeComponent();
            score = 0;
            isGameActive = false; // Initially, the game is not active
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            secondLabel.Text = "_";
            Random random = new Random();
            int num = random.Next(1, 11);
            firstLabel.Text = num.ToString();
            isGameActive = true; // Set the flag to true when the game is activated
            notifyLabel.Text = "Game activated! Now you can make a guess.";
        }

        private void higherButton_Click(object sender, EventArgs e)
        {
            if (!isGameActive) // Check if the game is active
            {
                notifyLabel.Text = "Please restart the game before making a guess.";
                return;
            }

            if (firstLabel.Text != "_")
            {
                Random random = new Random();
                int num = random.Next(1, 11);
                secondLabel.Text = num.ToString();

                int firstNum = int.Parse(firstLabel.Text);
                int secondNum = int.Parse(secondLabel.Text);

                if (secondNum > firstNum)
                {
                    score++;
                    notifyLabel.Text = $"You scored a point! {secondNum} is greater than {firstNum}. Try again for more points!";
                }
                else
                {
                    notifyLabel.Text = $"You do not get a point... {secondNum} is not greater than {firstNum}. Try again for more points!";
                }
            }
            else
            {
                notifyLabel.Text = "Please generate the first number before making a guess.";
            }
        }
    }
}

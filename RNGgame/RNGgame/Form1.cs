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

        public Form1()
        {
            InitializeComponent();
            score = 0;
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            secondLabel.Text = "__";
            Random random = new Random();
            int num = random.Next(1, 11);
            firstLabel.Text = num.ToString();
            notifyLabel.Text = "Game activated! Now you can make a guess.";
        }

        private void higherButton_Click(object sender, EventArgs e)
        {
            if (firstLabel.Text != "__") 
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
                    scoreLabel.Text = score.ToString();
                }
                if (secondNum < firstNum)
                {
                    notifyLabel.Text = $"You do not get a point... {secondNum} is not greater than {firstNum}. Try again for more points!";
                }
                if (secondNum == firstNum)
                {
                    notifyLabel.Text = $"You do not get a point... {secondNum} is equal to {firstNum}. Try again for more points!";
                }


                activateButton.Text = "GENERATE NEW GUESS";
                firstLabel.Text = "__";
            }

            else
            {
                notifyLabel.Text = "Please generate the a new guess first.";
            }
        }

        private void lowerButton_Click(object sender, EventArgs e)
        {
            if (firstLabel.Text != "__")
            {
                Random random = new Random();
                int num = random.Next(1, 11);
                secondLabel.Text = num.ToString();

                int firstNum = int.Parse(firstLabel.Text);
                int secondNum = int.Parse(secondLabel.Text);

                if (secondNum < firstNum)
                {
                    score++;
                    notifyLabel.Text = $"You scored a point! {secondNum} is less than {firstNum}. Try again for more points!";
                    scoreLabel.Text = score.ToString();
                }
                if (secondNum > firstNum)
                {
                    notifyLabel.Text = $"You do not get a point... {secondNum} is not less than {firstNum}. Try again for more points!";
                }
                if (secondNum == firstNum)
                {
                    notifyLabel.Text = $"You do not get a point... {secondNum} is equal to {firstNum}. Try again for more points!";
                }

                activateButton.Text = "GENERATE NEW GUESS";
                firstLabel.Text = "__";
            }

            else
            {
                notifyLabel.Text = "Please generate the a new guess first.";
            }
        }
    }
}

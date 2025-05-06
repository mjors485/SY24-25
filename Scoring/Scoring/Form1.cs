using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            ScoreRace();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            ScoreRace();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            ScoreRace();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            ScoreRace();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox5.Text);
            ScoreRace();
        }

        private void ScoreRace()
        {
            int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0;
            int[] t1 = new int[7];
            int[] t2 = new int[7];
            int[] t3 = new int[7];
            int[] t4 = new int[7];
            int[] t5 = new int[7];
            int score = 0;
            foreach (var item in listBox1.Items)
            {
                score++;
                if (item.ToString() == textBox1.Text)
                    t1[f1++] = score;
                if (item.ToString() == textBox2.Text)
                    t2[f2++] = score;
                if (item.ToString() == textBox3.Text)
                    t3[f3++] = score;
                if (item.ToString() == textBox4.Text)
                    t4[f4++] = score;
                if (item.ToString() == textBox5.Text)
                    t5[f5++] = score;
            }

            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                temp += t1[i];
                Score1TB.Text = temp.ToString();
            }
            
            temp = 0;
            for (int i = 0; i < 5; i++)
            {
                temp += t2[i];
                Score2TB.Text = temp.ToString();
            }

            temp = 0;
            for (int i = 0; i < 5; i++)
            {
                temp += t3[i];
                Score3TB.Text = temp.ToString();
            }

            temp = 0;
            for (int i = 0; i < 5; i++)
            {
                temp += t4[i];
                Score4TB.Text = temp.ToString();
            }

            temp = 0;
            for (int i = 0; i < 5; i++)
            {
                temp += t5[i];
                Score5TB.Text = temp.ToString();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // *** Create an array of size 10
            int[] numbers = new int[10];
            //10 value is the amount of numbers in the array, not necessarily the ending number
            //since we start at 1, the final number is 10, but if i changed the starting number to 5, the final number would be 14

            // Fill the array with numbers 1-10
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;  // Adding 1 because i starts at 0
                // i + __ is the starting number
            }

            // Display the array elements
            // (kinda not needed, but shows all of the number)
            listOutput.Items.Add("Array elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                listOutput.Items.Add($"numbers[{i}] = {numbers[i]}");
            }

            // Calculate the sum
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // Calculate the average
            double average = (double)sum / numbers.Length;

            // Display the results
            listOutput.Items.Add("");
            listOutput.Items.Add($"Sum: {sum}");
            listOutput.Items.Add($"Average: {average}");
        }
    }
}

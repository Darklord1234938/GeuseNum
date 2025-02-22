using System;
using System.IO;
using System.Windows.Forms;

namespace RandomNum
{
    public partial class Form1 : Form
    {
        int highestNum = 10, rndNums, turns;
        float points;
        bool once = true;

        public Form1()
        {
            InitializeComponent();
            ToLable.Text = "What Is Highest Number You Want?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "".Trim())
            {
                if (once)
                {
                    if (int.TryParse(textBox1.Text, out int j))
                    {
                        highestNum = j;
                        once = false;
                        Random random = new Random();
                        rndNums = random.Next(0, highestNum + 1);
                    }
                }
                else
                {
                    if (int.TryParse(textBox1.Text, out int j))
                    {
                        if (j > rndNums)
                        {
                            ToLable.Text = $"{j} Is To High";
                        }
                        else if (j < rndNums)
                        {
                            ToLable.Text = $"{j} Is To Low";
                        }
                        else
                        {
                            ToLable.Text = "You Won. What Is Highest Number You Want?";
                            once = true;
                        }
                    }
                }
                textBox1.Text = "";
            }
        }

        private void ToLable_Click(object sender, EventArgs e)
        {

        }
    }
}

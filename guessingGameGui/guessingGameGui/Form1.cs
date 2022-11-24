using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;


namespace guessingGameGui
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        int ans;
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            ans = rand.Next(1, 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int plyAns = Convert.ToInt32(textBox1.Text);
            if (plyAns < ans)
            {
                label1.Visible=true;
                label1.Text = "Err! Guess is too low, try again.";
                label1.ForeColor = Color.MediumVioletRed;
            }
            else if (plyAns > ans)
            {
                label1.Visible = true;
                label1.Text = "Err! Guess is to high, try again.";
                label1.ForeColor = Color.MediumVioletRed;
            }
            else
            {
                label1.Visible = true;
                label1.Text="Congratulations! You got it!";
                label1.ForeColor = Color.DarkGreen;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
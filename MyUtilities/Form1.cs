using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace MyUtilities
{
    public partial class MainForm : Form
    {
        private int count = 0;
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My utils soft\nAlexander soft\n\n\tCopyright 2020", "About");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(0);
        }

        private void bGenerator_Click(object sender, EventArgs e)
        {
            int random = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)+1);
            lblRandom.Text = random.ToString();
        }
    }
}

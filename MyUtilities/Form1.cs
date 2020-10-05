using System;
using System.Windows.Forms;

namespace MyUtilities
{
    public partial class MainForm : Form
    {
        private int _count;
        private readonly Random _rnd = new Random();

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
            MessageBox.Show("My utils soft\n Alexander soft\nCopyright 2020", "About");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _count++;
            lblCount.Text = _count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _count--;
            lblCount.Text = _count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _count = 0;
            lblCount.Text = Convert.ToString(0);
        }

        private void bGenerator_Click(object sender, EventArgs e)
        {
            int random = _rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = random.ToString();
            if (cRandomUniq.Checked)
            {
                if (tbRandom.Text.IndexOf(random.ToString(), StringComparison.Ordinal) != -1)
                    return;
            }
            tbRandom.AppendText(random + "\r\n");
        }

        private void bRandomClear_Click(object sender, EventArgs e)
        {
            lblRandom.Text = @"*";
            tbRandom.Clear();
        }

        private void bRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiAddDate_Click(object sender, EventArgs e)
        {
           rtbNotepad.AppendText(DateTime.Now.ToShortDateString()+"\r\n");
        }

        private void tsmiAddTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\r\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Save Error", "Error");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Load Error", "Error");
            }
        }
    }
}

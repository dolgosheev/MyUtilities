using System;
using System.Windows.Forms;

namespace MyUtilities
{
    public partial class MainForm : Form
    {
        private int _count;
        private readonly Random _rnd = new Random();
        char[] specChars = new char[]{'!', '@', '#', '$', '%', '&', '~'};
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


        private void buttonCreatePassword_Click(object sender, EventArgs e)
        {
            if(clbPassword.CheckedItems.Count==0)
                return;
            string password = "";
            for (int i = 0; i < nudPassLength.Value; i++)
            {
                int n = _rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Cipher":
                        password += _rnd.Next(10).ToString();
                        break;
                    case "Write letters":
                        password += Convert.ToChar(_rnd.Next(65, 88));
                        break;
                    case "String letters":
                        password += Convert.ToChar(_rnd.Next(97, 122));
                        break;
                    default:
                        password += specChars[_rnd.Next(specChars.Length)];
                        break;
                }

                tbPassword.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
                clbPassword.SetItemChecked(0,true);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Load Error", "Error");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyUtilities
{
    public partial class MainForm : Form
    {
        private int _count;
        private readonly Random _rnd = new Random();
        private readonly char[] _specChars = { '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '<', '>', '?', '|', '/', '`', '=', '-' };

        private readonly Dictionary<string, double> metrica = new Dictionary<string, double>();

        private readonly Dictionary<string, double> Distance = new Dictionary<string, double>
        {
            {"mm", 1},
            {"cm", 10},
            {"dm", 100},
            {"m", 1000},
            {"km", 1000000},
            {"mile", 1609344}
        };

        private readonly Dictionary<string, double> Weight = new Dictionary<string, double>
        {
            {"g", 1},
            {"kg", 1000},
            {"t", 1000000},
            {"lb", 453.6},
            {"oz", 283}
        };

        private enum Operation
        {
            AddMetrica,
            AddAll
        }

        private void MetricaComplete(Dictionary<string, double> dictionary, Operation operation = Operation.AddMetrica)
        {
            if (operation == Operation.AddAll)
            {
                metrica.Clear();
                cbFrom.Items.Clear();
                cbTo.Items.Clear();
            }

            foreach (var value in dictionary)
            {
                metrica.Add(value.Key, value.Value);

                if (operation == Operation.AddAll)
                {
                    cbFrom.Items.Add(value.Key);
                    cbTo.Items.Add(value.Key);
                }
            }

            cbFrom.Text = cbTo.Text = dictionary.First().Key;
        }


        public MainForm()
        {
            InitializeComponent();
            MetricaComplete(Distance);
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
            var random = _rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
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
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\r\n");
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
            if (clbPassword.CheckedItems.Count == 0)
                return;
            var password = "";
            for (var i = 0; i < nudPassLength.Value; i++)
            {
                var n = _rnd.Next(0, clbPassword.CheckedItems.Count);
                var s = clbPassword.CheckedItems[n].ToString();
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
                        password += _specChars[_rnd.Next(_specChars.Length)];
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
                clbPassword.SetItemChecked(0, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Load Error", "Error");
            }
        }

        private void btnConvertMoney_Click(object sender, EventArgs e)
        {
            var m1 = metrica[cbFrom.Text];
            var m2 = metrica[cbTo.Text];
            var m3 = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (m1 * m3 / m2).ToString();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            var temp = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = temp;
        }

        private void cbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChoose.Text)
            {
                case "Distance":
                    MetricaComplete(Distance, Operation.AddAll);
                    break;
                case "Weight":
                    MetricaComplete(Weight, Operation.AddAll);
                    break;
            }
        }
    }
}

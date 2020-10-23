namespace MyUtilities
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tMenu = new System.Windows.Forms.TabControl();
            this.tConverter = new System.Windows.Forms.TabPage();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnConvertMoney = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tPassGenerator = new System.Windows.Forms.TabPage();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.buttonCreatePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tNotepad = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tGenerator = new System.Windows.Forms.TabPage();
            this.cRandomUniq = new System.Windows.Forms.CheckBox();
            this.bRandomCopy = new System.Windows.Forms.Button();
            this.bRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRandom = new System.Windows.Forms.Label();
            this.bGenerator = new System.Windows.Forms.Button();
            this.tCounter = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tMenu.SuspendLayout();
            this.tConverter.SuspendLayout();
            this.tPassGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.tNotepad.SuspendLayout();
            this.tGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tCounter.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tMenu
            // 
            this.tMenu.Controls.Add(this.tConverter);
            this.tMenu.Controls.Add(this.tPassGenerator);
            this.tMenu.Controls.Add(this.tNotepad);
            this.tMenu.Controls.Add(this.tGenerator);
            this.tMenu.Controls.Add(this.tCounter);
            this.tMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMenu.Location = new System.Drawing.Point(0, 24);
            this.tMenu.Name = "tMenu";
            this.tMenu.SelectedIndex = 0;
            this.tMenu.Size = new System.Drawing.Size(473, 292);
            this.tMenu.TabIndex = 1;
            // 
            // tConverter
            // 
            this.tConverter.Controls.Add(this.cbChoose);
            this.tConverter.Controls.Add(this.btnReverse);
            this.tConverter.Controls.Add(this.tbTo);
            this.tConverter.Controls.Add(this.tbFrom);
            this.tConverter.Controls.Add(this.btnConvertMoney);
            this.tConverter.Controls.Add(this.cbTo);
            this.tConverter.Controls.Add(this.cbFrom);
            this.tConverter.Location = new System.Drawing.Point(4, 22);
            this.tConverter.Name = "tConverter";
            this.tConverter.Size = new System.Drawing.Size(465, 266);
            this.tConverter.TabIndex = 4;
            this.tConverter.Text = "Converter";
            this.tConverter.UseVisualStyleBackColor = true;
            // 
            // cbChoose
            // 
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Items.AddRange(new object[] {
            "Distance",
            "Weight"});
            this.cbChoose.Location = new System.Drawing.Point(156, 24);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(152, 21);
            this.cbChoose.TabIndex = 6;
            this.cbChoose.Text = "Distance";
            this.cbChoose.SelectedIndexChanged += new System.EventHandler(this.cbChoose_SelectedIndexChanged);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(154, 58);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(155, 20);
            this.btnReverse.TabIndex = 5;
            this.btnReverse.Text = "<-->";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(324, 91);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(127, 20);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(8, 93);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(126, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // btnConvertMoney
            // 
            this.btnConvertMoney.Location = new System.Drawing.Point(154, 91);
            this.btnConvertMoney.Name = "btnConvertMoney";
            this.btnConvertMoney.Size = new System.Drawing.Size(155, 20);
            this.btnConvertMoney.TabIndex = 2;
            this.btnConvertMoney.Text = "Convert";
            this.btnConvertMoney.UseVisualStyleBackColor = true;
            this.btnConvertMoney.Click += new System.EventHandler(this.btnConvertMoney_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(323, 56);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(129, 21);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "mm";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(8, 57);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(129, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // tPassGenerator
            // 
            this.tPassGenerator.Controls.Add(this.tbPassword);
            this.tPassGenerator.Controls.Add(this.buttonCreatePassword);
            this.tPassGenerator.Controls.Add(this.label1);
            this.tPassGenerator.Controls.Add(this.nudPassLength);
            this.tPassGenerator.Controls.Add(this.clbPassword);
            this.tPassGenerator.Location = new System.Drawing.Point(4, 22);
            this.tPassGenerator.Name = "tPassGenerator";
            this.tPassGenerator.Size = new System.Drawing.Size(465, 266);
            this.tPassGenerator.TabIndex = 3;
            this.tPassGenerator.Text = "Pass Gen";
            this.tPassGenerator.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(17, 157);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(119, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // buttonCreatePassword
            // 
            this.buttonCreatePassword.Location = new System.Drawing.Point(17, 127);
            this.buttonCreatePassword.Name = "buttonCreatePassword";
            this.buttonCreatePassword.Size = new System.Drawing.Size(119, 23);
            this.buttonCreatePassword.TabIndex = 3;
            this.buttonCreatePassword.Text = "create password";
            this.buttonCreatePassword.UseVisualStyleBackColor = true;
            this.buttonCreatePassword.Click += new System.EventHandler(this.buttonCreatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Passw length";
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(93, 99);
            this.nudPassLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(43, 20);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // clbPassword
            // 
            this.clbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Cipher",
            "Write letters",
            "String letters",
            "Special symbols"});
            this.clbPassword.Location = new System.Drawing.Point(15, 12);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(121, 75);
            this.clbPassword.TabIndex = 0;
            // 
            // tNotepad
            // 
            this.tNotepad.Controls.Add(this.rtbNotepad);
            this.tNotepad.Location = new System.Drawing.Point(4, 22);
            this.tNotepad.Name = "tNotepad";
            this.tNotepad.Padding = new System.Windows.Forms.Padding(3);
            this.tNotepad.Size = new System.Drawing.Size(465, 266);
            this.tNotepad.TabIndex = 2;
            this.tNotepad.Text = "Notepad";
            this.tNotepad.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(459, 260);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tGenerator
            // 
            this.tGenerator.Controls.Add(this.cRandomUniq);
            this.tGenerator.Controls.Add(this.bRandomCopy);
            this.tGenerator.Controls.Add(this.bRandomClear);
            this.tGenerator.Controls.Add(this.tbRandom);
            this.tGenerator.Controls.Add(this.label3);
            this.tGenerator.Controls.Add(this.label2);
            this.tGenerator.Controls.Add(this.numericUpDown2);
            this.tGenerator.Controls.Add(this.numericUpDown1);
            this.tGenerator.Controls.Add(this.lblRandom);
            this.tGenerator.Controls.Add(this.bGenerator);
            this.tGenerator.Location = new System.Drawing.Point(4, 22);
            this.tGenerator.Name = "tGenerator";
            this.tGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tGenerator.Size = new System.Drawing.Size(465, 266);
            this.tGenerator.TabIndex = 1;
            this.tGenerator.Text = "Generator";
            this.tGenerator.UseVisualStyleBackColor = true;
            // 
            // cRandomUniq
            // 
            this.cRandomUniq.AutoSize = true;
            this.cRandomUniq.Location = new System.Drawing.Point(340, 49);
            this.cRandomUniq.Name = "cRandomUniq";
            this.cRandomUniq.Size = new System.Drawing.Size(46, 17);
            this.cRandomUniq.TabIndex = 9;
            this.cRandomUniq.Text = "uniq";
            this.cRandomUniq.UseVisualStyleBackColor = true;
            // 
            // bRandomCopy
            // 
            this.bRandomCopy.Location = new System.Drawing.Point(144, 166);
            this.bRandomCopy.Name = "bRandomCopy";
            this.bRandomCopy.Size = new System.Drawing.Size(75, 23);
            this.bRandomCopy.TabIndex = 8;
            this.bRandomCopy.Text = "Copy";
            this.bRandomCopy.UseVisualStyleBackColor = true;
            this.bRandomCopy.Click += new System.EventHandler(this.bRandomCopy_Click);
            // 
            // bRandomClear
            // 
            this.bRandomClear.Location = new System.Drawing.Point(143, 134);
            this.bRandomClear.Name = "bRandomClear";
            this.bRandomClear.Size = new System.Drawing.Size(75, 23);
            this.bRandomClear.TabIndex = 7;
            this.bRandomClear.Text = "Clear";
            this.bRandomClear.UseVisualStyleBackColor = true;
            this.bRandomClear.Click += new System.EventHandler(this.bRandomClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(240, 132);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(91, 102);
            this.tbRandom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "from";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(108, 80);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(109, 26);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(108, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 26);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRandom.Location = new System.Drawing.Point(236, 85);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(16, 20);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "*";
            // 
            // bGenerator
            // 
            this.bGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGenerator.Location = new System.Drawing.Point(234, 46);
            this.bGenerator.Name = "bGenerator";
            this.bGenerator.Size = new System.Drawing.Size(97, 36);
            this.bGenerator.TabIndex = 0;
            this.bGenerator.Text = "Generate";
            this.bGenerator.UseVisualStyleBackColor = true;
            this.bGenerator.Click += new System.EventHandler(this.bGenerator_Click);
            // 
            // tCounter
            // 
            this.tCounter.Controls.Add(this.lblCount);
            this.tCounter.Controls.Add(this.btnReset);
            this.tCounter.Controls.Add(this.btnMinus);
            this.tCounter.Controls.Add(this.btnPlus);
            this.tCounter.Location = new System.Drawing.Point(4, 22);
            this.tCounter.Name = "tCounter";
            this.tCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tCounter.Size = new System.Drawing.Size(465, 266);
            this.tCounter.TabIndex = 0;
            this.tCounter.Text = "Counter";
            this.tCounter.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(31, 106);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 20);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(112, 103);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(27, 143);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(88, 70);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(25, 26);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(88, 70);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiExit.Size = new System.Drawing.Size(136, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiNotepad
            // 
            this.tsmiNotepad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddDate,
            this.tsmiAddTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.tsmiNotepad.Name = "tsmiNotepad";
            this.tsmiNotepad.Size = new System.Drawing.Size(65, 20);
            this.tsmiNotepad.Text = "Notepad";
            // 
            // tsmiAddDate
            // 
            this.tsmiAddDate.Name = "tsmiAddDate";
            this.tsmiAddDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiAddDate.Size = new System.Drawing.Size(197, 22);
            this.tsmiAddDate.Text = "Add Date";
            this.tsmiAddDate.Click += new System.EventHandler(this.tsmiAddDate_Click);
            // 
            // tsmiAddTime
            // 
            this.tsmiAddTime.Name = "tsmiAddTime";
            this.tsmiAddTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiAddTime.Size = new System.Drawing.Size(197, 22);
            this.tsmiAddTime.Text = "Add Time";
            this.tsmiAddTime.Click += new System.EventHandler(this.tsmiAddTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(197, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(197, 22);
            this.tsmiLoad.Text = "Load";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiNotepad,
            this.tsmiHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(473, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 316);
            this.Controls.Add(this.tMenu);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "My Utilities";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tMenu.ResumeLayout(false);
            this.tConverter.ResumeLayout(false);
            this.tConverter.PerformLayout();
            this.tPassGenerator.ResumeLayout(false);
            this.tPassGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.tNotepad.ResumeLayout(false);
            this.tGenerator.ResumeLayout(false);
            this.tGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tCounter.ResumeLayout(false);
            this.tCounter.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tMenu;
        private System.Windows.Forms.TabPage tCounter;
        private System.Windows.Forms.TabPage tGenerator;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button bGenerator;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button bRandomClear;
        private System.Windows.Forms.Button bRandomCopy;
        private System.Windows.Forms.CheckBox cRandomUniq;
        private System.Windows.Forms.TabPage tNotepad;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.TabPage tPassGenerator;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button buttonCreatePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabPage tConverter;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvertMoney;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.ComboBox cbChoose;
    }
}


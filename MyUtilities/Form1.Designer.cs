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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tMenu = new System.Windows.Forms.TabControl();
            this.tCounter = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tGenerator = new System.Windows.Forms.TabPage();
            this.bRandomCopy = new System.Windows.Forms.Button();
            this.bRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRandom = new System.Windows.Forms.Label();
            this.bGenerator = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cRandomUniq = new System.Windows.Forms.CheckBox();
            this.tNotepad = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tsmiNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenu.SuspendLayout();
            this.tCounter.SuspendLayout();
            this.tGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tMenu
            // 
            this.tMenu.Controls.Add(this.tNotepad);
            this.tMenu.Controls.Add(this.tGenerator);
            this.tMenu.Controls.Add(this.tCounter);
            this.tMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMenu.Location = new System.Drawing.Point(0, 48);
            this.tMenu.Name = "tMenu";
            this.tMenu.SelectedIndex = 0;
            this.tMenu.Size = new System.Drawing.Size(473, 268);
            this.tMenu.TabIndex = 1;
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
            this.tCounter.Size = new System.Drawing.Size(465, 242);
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
            this.tGenerator.Size = new System.Drawing.Size(465, 242);
            this.tGenerator.TabIndex = 1;
            this.tGenerator.Text = "Generator";
            this.tGenerator.UseVisualStyleBackColor = true;
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
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiNotepad,
            this.tsmiHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(473, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
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
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
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
            // tNotepad
            // 
            this.tNotepad.Controls.Add(this.rtbNotepad);
            this.tNotepad.Location = new System.Drawing.Point(4, 22);
            this.tNotepad.Name = "tNotepad";
            this.tNotepad.Padding = new System.Windows.Forms.Padding(3);
            this.tNotepad.Size = new System.Drawing.Size(465, 242);
            this.tNotepad.TabIndex = 2;
            this.tNotepad.Text = "Notepad";
            this.tNotepad.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(459, 236);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 316);
            this.Controls.Add(this.tMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Utilities";
            this.tMenu.ResumeLayout(false);
            this.tCounter.ResumeLayout(false);
            this.tCounter.PerformLayout();
            this.tGenerator.ResumeLayout(false);
            this.tGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tNotepad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tMenu;
        private System.Windows.Forms.TabPage tCounter;
        private System.Windows.Forms.TabPage tGenerator;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
    }
}


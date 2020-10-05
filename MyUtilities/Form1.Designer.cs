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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.bGenerator = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tMenu.SuspendLayout();
            this.tCounter.SuspendLayout();
            this.tGenerator.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tMenu
            // 
            this.tMenu.Controls.Add(this.tCounter);
            this.tMenu.Controls.Add(this.tGenerator);
            this.tMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMenu.Location = new System.Drawing.Point(0, 48);
            this.tMenu.Name = "tMenu";
            this.tMenu.SelectedIndex = 0;
            this.tMenu.Size = new System.Drawing.Size(800, 402);
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
            this.tCounter.Size = new System.Drawing.Size(792, 376);
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
            this.tGenerator.Controls.Add(this.label3);
            this.tGenerator.Controls.Add(this.label2);
            this.tGenerator.Controls.Add(this.numericUpDown2);
            this.tGenerator.Controls.Add(this.numericUpDown1);
            this.tGenerator.Controls.Add(this.lblRandom);
            this.tGenerator.Controls.Add(this.bGenerator);
            this.tGenerator.Location = new System.Drawing.Point(4, 22);
            this.tGenerator.Name = "tGenerator";
            this.tGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tGenerator.Size = new System.Drawing.Size(792, 376);
            this.tGenerator.TabIndex = 1;
            this.tGenerator.Text = "Generator";
            this.tGenerator.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
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
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
    }
}


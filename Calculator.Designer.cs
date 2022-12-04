namespace Primary_and_Secondary_Colors
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.CalcText = new System.Windows.Forms.TextBox();
            this.DivB = new System.Windows.Forms.Button();
            this.SevenB = new System.Windows.Forms.Button();
            this.EightB = new System.Windows.Forms.Button();
            this.NineB = new System.Windows.Forms.Button();
            this.MultiB = new System.Windows.Forms.Button();
            this.SubB = new System.Windows.Forms.Button();
            this.SixB = new System.Windows.Forms.Button();
            this.FiveB = new System.Windows.Forms.Button();
            this.FourB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.ThreeB = new System.Windows.Forms.Button();
            this.TwoB = new System.Windows.Forms.Button();
            this.OneB = new System.Windows.Forms.Button();
            this.equalB = new System.Windows.Forms.Button();
            this.ClearAlt = new System.Windows.Forms.Button();
            this.DecB = new System.Windows.Forms.Button();
            this.ZeroB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.DynoCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcText
            // 
            this.CalcText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CalcText.Location = new System.Drawing.Point(34, 105);
            this.CalcText.Multiline = true;
            this.CalcText.Name = "CalcText";
            this.CalcText.ReadOnly = true;
            this.CalcText.Size = new System.Drawing.Size(572, 144);
            this.CalcText.TabIndex = 0;
            this.CalcText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DivB
            // 
            this.DivB.Location = new System.Drawing.Point(459, 246);
            this.DivB.Name = "DivB";
            this.DivB.Size = new System.Drawing.Size(147, 133);
            this.DivB.TabIndex = 4;
            this.DivB.Text = "÷";
            this.DivB.UseVisualStyleBackColor = true;
            this.DivB.Click += new System.EventHandler(this.DivB_Click);
            // 
            // SevenB
            // 
            this.SevenB.Location = new System.Drawing.Point(34, 375);
            this.SevenB.Name = "SevenB";
            this.SevenB.Size = new System.Drawing.Size(147, 133);
            this.SevenB.TabIndex = 5;
            this.SevenB.Text = "7";
            this.SevenB.UseVisualStyleBackColor = true;
            this.SevenB.Click += new System.EventHandler(this.SevenB_Click);
            // 
            // EightB
            // 
            this.EightB.Location = new System.Drawing.Point(173, 375);
            this.EightB.Name = "EightB";
            this.EightB.Size = new System.Drawing.Size(147, 133);
            this.EightB.TabIndex = 6;
            this.EightB.Text = "8";
            this.EightB.UseVisualStyleBackColor = true;
            this.EightB.Click += new System.EventHandler(this.EightB_Click);
            // 
            // NineB
            // 
            this.NineB.Location = new System.Drawing.Point(316, 375);
            this.NineB.Name = "NineB";
            this.NineB.Size = new System.Drawing.Size(147, 133);
            this.NineB.TabIndex = 7;
            this.NineB.Text = "9";
            this.NineB.UseVisualStyleBackColor = true;
            this.NineB.Click += new System.EventHandler(this.NineB_Click);
            // 
            // MultiB
            // 
            this.MultiB.Location = new System.Drawing.Point(459, 375);
            this.MultiB.Name = "MultiB";
            this.MultiB.Size = new System.Drawing.Size(147, 133);
            this.MultiB.TabIndex = 8;
            this.MultiB.Text = "X";
            this.MultiB.UseVisualStyleBackColor = true;
            this.MultiB.Click += new System.EventHandler(this.MultiB_Click);
            // 
            // SubB
            // 
            this.SubB.Location = new System.Drawing.Point(459, 499);
            this.SubB.Name = "SubB";
            this.SubB.Size = new System.Drawing.Size(147, 133);
            this.SubB.TabIndex = 12;
            this.SubB.Text = "-";
            this.SubB.UseVisualStyleBackColor = true;
            this.SubB.Click += new System.EventHandler(this.SubB_Click);
            // 
            // SixB
            // 
            this.SixB.Location = new System.Drawing.Point(316, 499);
            this.SixB.Name = "SixB";
            this.SixB.Size = new System.Drawing.Size(147, 133);
            this.SixB.TabIndex = 11;
            this.SixB.Text = "6";
            this.SixB.UseVisualStyleBackColor = true;
            this.SixB.Click += new System.EventHandler(this.SixB_Click);
            // 
            // FiveB
            // 
            this.FiveB.Location = new System.Drawing.Point(173, 499);
            this.FiveB.Name = "FiveB";
            this.FiveB.Size = new System.Drawing.Size(147, 133);
            this.FiveB.TabIndex = 10;
            this.FiveB.Text = "5";
            this.FiveB.UseVisualStyleBackColor = true;
            this.FiveB.Click += new System.EventHandler(this.FiveB_Click);
            // 
            // FourB
            // 
            this.FourB.Location = new System.Drawing.Point(34, 499);
            this.FourB.Name = "FourB";
            this.FourB.Size = new System.Drawing.Size(147, 133);
            this.FourB.TabIndex = 9;
            this.FourB.Text = "4";
            this.FourB.UseVisualStyleBackColor = true;
            this.FourB.Click += new System.EventHandler(this.FourB_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(459, 624);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(147, 133);
            this.AddB.TabIndex = 16;
            this.AddB.Text = "+";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // ThreeB
            // 
            this.ThreeB.Location = new System.Drawing.Point(316, 624);
            this.ThreeB.Name = "ThreeB";
            this.ThreeB.Size = new System.Drawing.Size(147, 133);
            this.ThreeB.TabIndex = 15;
            this.ThreeB.Text = "3";
            this.ThreeB.UseVisualStyleBackColor = true;
            this.ThreeB.Click += new System.EventHandler(this.ThreeB_Click);
            // 
            // TwoB
            // 
            this.TwoB.Location = new System.Drawing.Point(173, 624);
            this.TwoB.Name = "TwoB";
            this.TwoB.Size = new System.Drawing.Size(147, 133);
            this.TwoB.TabIndex = 14;
            this.TwoB.Text = "2";
            this.TwoB.UseVisualStyleBackColor = true;
            this.TwoB.Click += new System.EventHandler(this.TwoB_Click);
            // 
            // OneB
            // 
            this.OneB.Location = new System.Drawing.Point(34, 624);
            this.OneB.Name = "OneB";
            this.OneB.Size = new System.Drawing.Size(147, 133);
            this.OneB.TabIndex = 13;
            this.OneB.Text = "1";
            this.OneB.UseVisualStyleBackColor = true;
            this.OneB.Click += new System.EventHandler(this.OneB_Click);
            // 
            // equalB
            // 
            this.equalB.Location = new System.Drawing.Point(173, 748);
            this.equalB.Name = "equalB";
            this.equalB.Size = new System.Drawing.Size(433, 133);
            this.equalB.TabIndex = 20;
            this.equalB.Text = "=";
            this.equalB.UseVisualStyleBackColor = true;
            this.equalB.Click += new System.EventHandler(this.equalB_Click);
            // 
            // ClearAlt
            // 
            this.ClearAlt.Location = new System.Drawing.Point(34, 246);
            this.ClearAlt.Name = "ClearAlt";
            this.ClearAlt.Size = new System.Drawing.Size(286, 133);
            this.ClearAlt.TabIndex = 19;
            this.ClearAlt.Text = "C";
            this.ClearAlt.UseVisualStyleBackColor = true;
            this.ClearAlt.Click += new System.EventHandler(this.ClearAlt_Click);
            // 
            // DecB
            // 
            this.DecB.Location = new System.Drawing.Point(316, 246);
            this.DecB.Name = "DecB";
            this.DecB.Size = new System.Drawing.Size(147, 133);
            this.DecB.TabIndex = 18;
            this.DecB.Text = ".";
            this.DecB.UseVisualStyleBackColor = true;
            this.DecB.Click += new System.EventHandler(this.DecB_Click);
            // 
            // ZeroB
            // 
            this.ZeroB.Location = new System.Drawing.Point(34, 748);
            this.ZeroB.Name = "ZeroB";
            this.ZeroB.Size = new System.Drawing.Size(147, 133);
            this.ZeroB.TabIndex = 17;
            this.ZeroB.Text = "0";
            this.ZeroB.UseVisualStyleBackColor = true;
            this.ZeroB.Click += new System.EventHandler(this.ZeroB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 40);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorMenuToolStripMenuItem
            // 
            this.calculatorMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calculatorMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorCalc,
            this.DynoCalc});
            this.calculatorMenuToolStripMenuItem.Name = "calculatorMenuToolStripMenuItem";
            this.calculatorMenuToolStripMenuItem.Size = new System.Drawing.Size(210, 36);
            this.calculatorMenuToolStripMenuItem.Text = "Calculator Menu";
            // 
            // ColorCalc
            // 
            this.ColorCalc.Name = "ColorCalc";
            this.ColorCalc.Size = new System.Drawing.Size(359, 44);
            this.ColorCalc.Text = "Color";
            this.ColorCalc.Click += new System.EventHandler(this.ColorCalc_Click);
            // 
            // DynoCalc
            // 
            this.DynoCalc.Name = "DynoCalc";
            this.DynoCalc.Size = new System.Drawing.Size(359, 44);
            this.DynoCalc.Text = "Dynamite";
            this.DynoCalc.Click += new System.EventHandler(this.DynoCalc_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 915);
            this.Controls.Add(this.equalB);
            this.Controls.Add(this.ClearAlt);
            this.Controls.Add(this.DecB);
            this.Controls.Add(this.ZeroB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.ThreeB);
            this.Controls.Add(this.TwoB);
            this.Controls.Add(this.OneB);
            this.Controls.Add(this.SubB);
            this.Controls.Add(this.SixB);
            this.Controls.Add(this.FiveB);
            this.Controls.Add(this.FourB);
            this.Controls.Add(this.MultiB);
            this.Controls.Add(this.NineB);
            this.Controls.Add(this.EightB);
            this.Controls.Add(this.SevenB);
            this.Controls.Add(this.DivB);
            this.Controls.Add(this.CalcText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalcText;
        private System.Windows.Forms.Button DivB;
        private System.Windows.Forms.Button SevenB;
        private System.Windows.Forms.Button EightB;
        private System.Windows.Forms.Button NineB;
        private System.Windows.Forms.Button MultiB;
        private System.Windows.Forms.Button SubB;
        private System.Windows.Forms.Button SixB;
        private System.Windows.Forms.Button FiveB;
        private System.Windows.Forms.Button FourB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button ThreeB;
        private System.Windows.Forms.Button TwoB;
        private System.Windows.Forms.Button OneB;
        private System.Windows.Forms.Button equalB;
        private System.Windows.Forms.Button ClearAlt;
        private System.Windows.Forms.Button DecB;
        private System.Windows.Forms.Button ZeroB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatorMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorCalc;
        private System.Windows.Forms.ToolStripMenuItem DynoCalc;
    }
}
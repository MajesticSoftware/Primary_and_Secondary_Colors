namespace Primary_and_Secondary_Colors
{
    partial class Dynamite
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.Explode = new System.Windows.Forms.Timer(this.components);
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(207, 36);
            this.menuToolStripMenuItem.Text = "Dynamite Menu";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Choose a Difficulty!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Easy.Location = new System.Drawing.Point(356, 140);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(132, 114);
            this.Easy.TabIndex = 2;
            this.Easy.Text = "Easy\r\n1-10";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medium
            // 
            this.Medium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Medium.Location = new System.Drawing.Point(533, 140);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(132, 114);
            this.Medium.TabIndex = 3;
            this.Medium.Text = "Medium 1-100";
            this.Medium.UseVisualStyleBackColor = false;
            this.Medium.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Hard.Location = new System.Drawing.Point(714, 140);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(132, 114);
            this.Hard.TabIndex = 4;
            this.Hard.Text = "Hard 1-1000";
            this.Hard.UseVisualStyleBackColor = false;
            // 
            // Explode
            // 
            this.Explode.Interval = 1000;
            this.Explode.Tick += new System.EventHandler(this.Explode_Tick);
            // 
            // TimerBox
            // 
            this.TimerBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerBox.Enabled = false;
            this.TimerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBox.Location = new System.Drawing.Point(74, 159);
            this.TimerBox.Multiline = true;
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(172, 100);
            this.TimerBox.TabIndex = 5;
            this.TimerBox.Text = "\r\n";
            this.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimerBox.TextChanged += new System.EventHandler(this.TimerBox_TextChanged);
            // 
            // Dynamite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 751);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dynamite";
            this.Text = "Dynamite Countdown";
            this.Load += new System.EventHandler(this.Dynamite_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Timer Explode;
        private System.Windows.Forms.TextBox TimerBox;
    }
}
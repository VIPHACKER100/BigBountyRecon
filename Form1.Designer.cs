namespace BigBountyRecon
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.top5Button = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();

            // titlePanel
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.titlePanel.Controls.Add(this.headerLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1024, 60);
            this.titlePanel.TabIndex = 1001;

            // headerLabel
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(450, 32);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "BigBountyRecon v1.1.0 - VIPHACKER100";

            // textBox1
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "example.com";

            // clearButton
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(906, 75);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 29);
            this.clearButton.TabIndex = 1003;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // top5Button
            this.top5Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.top5Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.top5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.top5Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.top5Button.ForeColor = System.Drawing.Color.White;
            this.top5Button.Location = new System.Drawing.Point(785, 75);
            this.top5Button.Name = "top5Button";
            this.top5Button.Size = new System.Drawing.Size(115, 29);
            this.top5Button.TabIndex = 1004;
            this.top5Button.Text = "TOP 5 SCAN";
            this.top5Button.UseVisualStyleBackColor = false;
            this.top5Button.Click += new System.EventHandler(this.top5Button_Click);

            // flowLayoutPanel1
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(988, 530);
            this.flowLayoutPanel1.TabIndex = 1002;

            // Initialize all buttons
            for (int i = 1; i <= 66; i++)
            {
                System.Reflection.FieldInfo field = this.GetType().GetField($"button{i}", 
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (field != null)
                {
                    var btn = new System.Windows.Forms.Button();
                    field.SetValue(this, btn);
                    btn.Name = $"button{i}";
                    btn.Text = "Query " + i;
                    btn.Size = new System.Drawing.Size(185, 45);
                    btn.TabIndex = i;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.flowLayoutPanel1.Controls.Add(btn);
                }
            }

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1000;
            this.label1.Text = "@ManiarViral";
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // Wire up all button click handlers
            if (this.button1 != null) this.button1.Click += new System.EventHandler(this.button1_Click);
            if (this.button2 != null) this.button2.Click += new System.EventHandler(this.button2_Click);
            if (this.button3 != null) this.button3.Click += new System.EventHandler(this.button3_Click);
            if (this.button4 != null) this.button4.Click += new System.EventHandler(this.button4_Click);
            if (this.button5 != null) this.button5.Click += new System.EventHandler(this.button5_Click);
            if (this.button6 != null) this.button6.Click += new System.EventHandler(this.button6_Click);
            if (this.button7 != null) this.button7.Click += new System.EventHandler(this.button7_Click);
            if (this.button8 != null) this.button8.Click += new System.EventHandler(this.button8_Click);
            if (this.button9 != null) this.button9.Click += new System.EventHandler(this.button9_Click);
            if (this.button10 != null) this.button10.Click += new System.EventHandler(this.button10_Click);
            if (this.button11 != null) this.button11.Click += new System.EventHandler(this.button11_Click);
            if (this.button12 != null) this.button12.Click += new System.EventHandler(this.button12_Click);
            if (this.button13 != null) this.button13.Click += new System.EventHandler(this.button13_Click);
            if (this.button14 != null) this.button14.Click += new System.EventHandler(this.button14_Click);
            if (this.button15 != null) this.button15.Click += new System.EventHandler(this.button15_Click);
            if (this.button16 != null) this.button16.Click += new System.EventHandler(this.button16_Click);
            if (this.button17 != null) this.button17.Click += new System.EventHandler(this.button17_Click);
            if (this.button18 != null) this.button18.Click += new System.EventHandler(this.button18_Click);
            if (this.button19 != null) this.button19.Click += new System.EventHandler(this.button19_Click);
            if (this.button20 != null) this.button20.Click += new System.EventHandler(this.button20_Click);
            if (this.button21 != null) this.button21.Click += new System.EventHandler(this.button21_Click);
            if (this.button22 != null) this.button22.Click += new System.EventHandler(this.button22_Click);
            if (this.button23 != null) this.button23.Click += new System.EventHandler(this.button23_Click);
            if (this.button24 != null) this.button24.Click += new System.EventHandler(this.button24_Click);
            if (this.button25 != null) this.button25.Click += new System.EventHandler(this.button25_Click);
            if (this.button26 != null) this.button26.Click += new System.EventHandler(this.button26_Click);
            if (this.button27 != null) this.button27.Click += new System.EventHandler(this.button27_Click);
            if (this.button28 != null) this.button28.Click += new System.EventHandler(this.button28_Click);
            if (this.button29 != null) this.button29.Click += new System.EventHandler(this.button29_Click);
            if (this.button30 != null) this.button30.Click += new System.EventHandler(this.button30_Click);
            if (this.button31 != null) this.button31.Click += new System.EventHandler(this.button31_Click);
            if (this.button32 != null) this.button32.Click += new System.EventHandler(this.button32_Click);
            if (this.button33 != null) this.button33.Click += new System.EventHandler(this.button33_Click);
            if (this.button34 != null) this.button34.Click += new System.EventHandler(this.button34_Click);
            if (this.button35 != null) this.button35.Click += new System.EventHandler(this.button35_Click);
            if (this.button36 != null) this.button36.Click += new System.EventHandler(this.button36_Click);
            if (this.button37 != null) this.button37.Click += new System.EventHandler(this.button37_Click);
            if (this.button38 != null) this.button38.Click += new System.EventHandler(this.button38_Click);
            if (this.button39 != null) this.button39.Click += new System.EventHandler(this.button39_Click);
            if (this.button40 != null) this.button40.Click += new System.EventHandler(this.button40_Click);
            if (this.button41 != null) this.button41.Click += new System.EventHandler(this.button41_Click);
            if (this.button42 != null) this.button42.Click += new System.EventHandler(this.button42_Click);
            if (this.button43 != null) this.button43.Click += new System.EventHandler(this.button43_Click);
            if (this.button44 != null) this.button44.Click += new System.EventHandler(this.button44_Click);
            if (this.button45 != null) this.button45.Click += new System.EventHandler(this.button45_Click);
            if (this.button46 != null) this.button46.Click += new System.EventHandler(this.button46_Click);
            if (this.button47 != null) this.button47.Click += new System.EventHandler(this.button47_Click);
            if (this.button48 != null) this.button48.Click += new System.EventHandler(this.button48_Click);
            if (this.button49 != null) this.button49.Click += new System.EventHandler(this.button49_Click);
            if (this.button50 != null) this.button50.Click += new System.EventHandler(this.button50_Click);
            if (this.button51 != null) this.button51.Click += new System.EventHandler(this.button51_Click);
            if (this.button52 != null) this.button52.Click += new System.EventHandler(this.button52_Click);
            if (this.button53 != null) this.button53.Click += new System.EventHandler(this.button53_Click);
            if (this.button54 != null) this.button54.Click += new System.EventHandler(this.button54_Click);
            if (this.button55 != null) this.button55.Click += new System.EventHandler(this.button55_Click);
            if (this.button56 != null) this.button56.Click += new System.EventHandler(this.button56_Click);
            if (this.button57 != null) this.button57.Click += new System.EventHandler(this.button57_Click);
            if (this.button58 != null) this.button58.Click += new System.EventHandler(this.button58_Click);
            if (this.button59 != null) this.button59.Click += new System.EventHandler(this.button59_Click);
            if (this.button60 != null) this.button60.Click += new System.EventHandler(this.button60_Click);
            if (this.button61 != null) this.button61.Click += new System.EventHandler(this.button61_Click);
            if (this.button62 != null) this.button62.Click += new System.EventHandler(this.button62_Click);
            if (this.button63 != null) this.button63.Click += new System.EventHandler(this.button63_Click);
            if (this.button64 != null) this.button64.Click += new System.EventHandler(this.button64_Click);
            if (this.button65 != null) this.button65.Click += new System.EventHandler(this.button65_Click);
            if (this.button66 != null) this.button66.Click += new System.EventHandler(this.button66_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.top5Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlePanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BigBountyRecon - Reconnaissance Tool [Powered by VIPHACKER100]";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button top5Button;
        
        // Declare all buttons
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button57;
        private System.Windows.Forms.Button button58;
        private System.Windows.Forms.Button button59;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button button61;
        private System.Windows.Forms.Button button62;
        private System.Windows.Forms.Button button63;
        private System.Windows.Forms.Button button64;
        private System.Windows.Forms.Button button65;
        private System.Windows.Forms.Button button66;
    }
}


namespace Q1_Calculator
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.bin = new System.Windows.Forms.Button();
            this.oct = new System.Windows.Forms.Button();
            this.hex = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.C_button = new System.Windows.Forms.Button();
            this.m_button = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(196, 115);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(342, 61);
            this.textBox.TabIndex = 1;
            // 
            // bin
            // 
            this.bin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin.ForeColor = System.Drawing.SystemColors.Window;
            this.bin.Location = new System.Drawing.Point(196, 182);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(110, 67);
            this.bin.TabIndex = 2;
            this.bin.Text = "BIN";
            this.bin.UseVisualStyleBackColor = false;
            this.bin.Click += new System.EventHandler(this.bin_Click);
            // 
            // oct
            // 
            this.oct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct.ForeColor = System.Drawing.SystemColors.Window;
            this.oct.Location = new System.Drawing.Point(312, 182);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(110, 67);
            this.oct.TabIndex = 6;
            this.oct.Text = "OCT";
            this.oct.UseVisualStyleBackColor = false;
            this.oct.Click += new System.EventHandler(this.oct_Click);
            // 
            // hex
            // 
            this.hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex.ForeColor = System.Drawing.SystemColors.Window;
            this.hex.Location = new System.Drawing.Point(428, 182);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(110, 67);
            this.hex.TabIndex = 7;
            this.hex.Text = "HEX";
            this.hex.UseVisualStyleBackColor = false;
            this.hex.Click += new System.EventHandler(this.hex_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.GrayText;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.Window;
            this.seven.Location = new System.Drawing.Point(196, 252);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(81, 55);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.GrayText;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.Window;
            this.eight.Location = new System.Drawing.Point(283, 252);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(81, 55);
            this.eight.TabIndex = 12;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.GrayText;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.Window;
            this.nine.Location = new System.Drawing.Point(370, 252);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(81, 55);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.GrayText;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.Window;
            this.six.Location = new System.Drawing.Point(370, 312);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(81, 55);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.GrayText;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.Window;
            this.five.Location = new System.Drawing.Point(283, 312);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(81, 55);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.GrayText;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.Window;
            this.four.Location = new System.Drawing.Point(196, 312);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(81, 55);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.GrayText;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.Window;
            this.three.Location = new System.Drawing.Point(370, 373);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(81, 55);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.GrayText;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.Window;
            this.two.Location = new System.Drawing.Point(283, 373);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(81, 55);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.GrayText;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.SystemColors.Window;
            this.one.Location = new System.Drawing.Point(196, 373);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(81, 55);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GrayText;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Window;
            this.button11.Location = new System.Drawing.Point(370, 434);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 55);
            this.button11.TabIndex = 22;
            this.button11.Text = "←";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.GrayText;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.Window;
            this.zero.Location = new System.Drawing.Point(283, 434);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(81, 55);
            this.zero.TabIndex = 21;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // C_button
            // 
            this.C_button.BackColor = System.Drawing.SystemColors.GrayText;
            this.C_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_button.ForeColor = System.Drawing.SystemColors.Window;
            this.C_button.Location = new System.Drawing.Point(196, 434);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(81, 55);
            this.C_button.TabIndex = 20;
            this.C_button.Text = "C";
            this.C_button.UseVisualStyleBackColor = false;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // m_button
            // 
            this.m_button.BackColor = System.Drawing.SystemColors.GrayText;
            this.m_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_button.ForeColor = System.Drawing.SystemColors.Window;
            this.m_button.Location = new System.Drawing.Point(196, 495);
            this.m_button.Name = "m_button";
            this.m_button.Size = new System.Drawing.Size(81, 55);
            this.m_button.TabIndex = 23;
            this.m_button.Text = "M";
            this.m_button.UseVisualStyleBackColor = false;
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.GrayText;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.SystemColors.Window;
            this.dot.Location = new System.Drawing.Point(283, 495);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(81, 55);
            this.dot.TabIndex = 24;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.RoyalBlue;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.Window;
            this.plus.Location = new System.Drawing.Point(457, 252);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(81, 55);
            this.plus.TabIndex = 25;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.RoyalBlue;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.Window;
            this.minus.Location = new System.Drawing.Point(457, 312);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(81, 55);
            this.minus.TabIndex = 26;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.Color.RoyalBlue;
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiple.ForeColor = System.Drawing.SystemColors.Window;
            this.multiple.Location = new System.Drawing.Point(457, 373);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(81, 55);
            this.multiple.TabIndex = 27;
            this.multiple.Text = "x";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.RoyalBlue;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.Window;
            this.divide.Location = new System.Drawing.Point(457, 434);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(81, 55);
            this.divide.TabIndex = 28;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.button18_Click);
            // 
            // equa
            // 
            this.equa.BackColor = System.Drawing.Color.RoyalBlue;
            this.equa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equa.ForeColor = System.Drawing.SystemColors.Window;
            this.equa.Location = new System.Drawing.Point(370, 495);
            this.equa.Name = "equa";
            this.equa.Size = new System.Drawing.Size(168, 55);
            this.equa.TabIndex = 29;
            this.equa.Text = "=";
            this.equa.UseVisualStyleBackColor = false;
            this.equa.Click += new System.EventHandler(this.equa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Programmer Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(768, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equa);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.m_button);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.C_button);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.textBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button bin;
        private System.Windows.Forms.Button oct;
        private System.Windows.Forms.Button hex;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.Button m_button;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equa;
        private System.Windows.Forms.Label label1;
    }
}


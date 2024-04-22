using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}



        private void seven_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void one_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox.Text += button.Text;
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void bin_Click(object sender, EventArgs e)
        {
            textBox.Text = ConvertToBase(2);
        }

        private void oct_Click(object sender, EventArgs e)
        {
            textBox.Text = ConvertToBase(8);
        }

        private void hex_Click(object sender, EventArgs e)
        {
            textBox.Text = ConvertToBase(16);
        }

        private string ConvertToBase(int baseValue)
        {
            try
            {
                int decimalNumber = int.Parse(textBox.Text);
                return Convert.ToString(decimalNumber, baseValue);
            }
            catch (FormatException)
            {
                return "Invalid input";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void equa_Click(object sender, EventArgs e)
        {
            try
            {
                string result = new DataTable().Compute(textBox.Text, null).ToString();
                textBox.Text = result;
            }
            catch (Exception)
            {  
                textBox.Text = "Error";
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }
    }
}

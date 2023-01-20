using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int num1, num2, num3, num4, num5, num6;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = int.Parse(textBox3.Text);
            num4 = int.Parse(textBox4.Text);
            num5 = int.Parse(textBox5.Text);
            num6 = int.Parse(textBox6.Text);
            Random generator = new Random();
            int RandomValue1 = generator.Next(1, 49);
            int RandomValue2 = generator.Next(1, 49);
            int RandomValue3 = generator.Next(1, 49);
            int RandomValue4 = generator.Next(1, 49);
            int RandomValue5 = generator.Next(1, 49);
            int RandomValue6 = generator.Next(1, 49);
            
            this.textBox7.Text = RandomValue1.ToString();
            this.textBox8.Text = RandomValue2.ToString();
            this.textBox9.Text = RandomValue3.ToString();
            this.textBox10.Text = RandomValue4.ToString();
            this.textBox11.Text = RandomValue5.ToString();
            this.textBox12.Text = RandomValue6.ToString();
            int counter = 0;
            if (RandomValue1 == num1 || RandomValue1 == num2 || RandomValue1 == num3
                || RandomValue1 == num4 || RandomValue1 == num5|| RandomValue1 == num6) counter++;
            if (RandomValue2 == num1 || RandomValue2 == num2 || RandomValue2 == num3
                || RandomValue2 == num4 || RandomValue2 == num5 || RandomValue2 == num6) counter++;
            if (RandomValue3 == num1 || RandomValue3 == num2 || RandomValue3 == num3
                || RandomValue3 == num4 || RandomValue3 == num5 || RandomValue3 == num6) counter++;
            if (RandomValue4 == num1 || RandomValue4 == num2 || RandomValue4 == num3
                || RandomValue4 == num4 || RandomValue4 == num5 || RandomValue4 == num6) counter++;
            if (RandomValue5 == num1 || RandomValue5 == num2 || RandomValue5 == num3
                || RandomValue5 == num4 || RandomValue5 == num5 || RandomValue5 == num6) counter++;
            if (RandomValue6 == num1 || RandomValue6 == num2 || RandomValue6 == num3
                || RandomValue6 == num4 || RandomValue6 == num5 || RandomValue6 == num6) counter++;
            textBox13.Text = counter.ToString();
            
            if (counter == 1) label6.Text = "10 лв";
            if (counter == 2) label6.Text = "50 лв";
            if (counter == 3) label6.Text = "100 лв";
            if (counter == 4) label6.Text = "1 000 лв";
            if (counter == 5) label6.Text = "5 000 лв";
            if (counter == 6) label6.Text = "10 000 лв";





        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace durjavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBox1.Items.Add("България");
            comboBox1.Items.Add("САЩ");
            comboBox1.Items.Add("Франция");
            comboBox1.Items.Add("Китай");
            comboBox1.Items.Add("Русия");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("София");
                textBox1.Text = "Европа";
                textBox2.Text = "лев";
                pictureBox1.Image = Properties.Resources.България;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Вашингтон");
                textBox1.Text = "Северна Америка";
                textBox2.Text = "долар";
                pictureBox1.Image = Properties.Resources.Сащ;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Париж");
                textBox1.Text = "Европа";
                textBox2.Text = "евро";
                pictureBox1.Image = Properties.Resources.Франция;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Пекин");
                textBox1.Text = "Азия";
                textBox2.Text = "юан";
                pictureBox1.Image = Properties.Resources.Китай;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Москва");
                textBox1.Text = "Азия";
                textBox2.Text = "рубла";
                pictureBox1.Image = Properties.Resources.Русия;
            }
        }
    }
}

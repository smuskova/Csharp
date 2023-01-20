using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List_Combo_Programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
       private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)

            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Математика");
                listBox1.Items.Add("Математика");
                listBox1.Items.Add("Информатика");
                listBox1.Items.Add("БЕЛ");
                listBox1.Items.Add("География");
                listBox1.Items.Add("ФВС");
                listBox1.Items.Add("Час на класа");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("История");
                listBox1.Items.Add("Математика");
                listBox1.Items.Add("ИТ");
                listBox1.Items.Add("БЕЛ");
                listBox1.Items.Add("География");
                listBox1.Items.Add("ФВС");
                listBox1.Items.Add("Физика");
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (listBox1.Text == "Математика")
            { textBox1.Text = "Иванов"; }
            if (listBox1.Text == "БЕЛ")
            { textBox1.Text = "Маринова"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Понеделник");
            comboBox1.Items.Add("Вторник");
            comboBox1.Items.Add("Сряда");
            comboBox1.Items.Add("Четвъртък");
            comboBox1.Items.Add("Петък");
            comboBox1.Items.Add("Събота");
            comboBox1.Items.Add("Неделя");

        }
    }
    
}


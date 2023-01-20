using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace broi_uchenici_v_klasovete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bd, bm, bda, bdb, bdv, bma, bmb, bmv, odm;
            bd = 0;
            bm = 0;
            bda = int.Parse(textBox1.Text);
            bdb = int.Parse(textBox3.Text);
            bdv = int.Parse(textBox5.Text);
            bma = int.Parse(textBox2.Text);
            bmb = int.Parse(textBox4.Text);
            bmv = int.Parse(textBox6.Text);
             if(radioButton1.Checked==true && checkBox1.Checked==true)
            {
                bd = bd + bda;
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked==true && checkBox1.Checked == true)
            {
                   bm = bm + bma;
                   label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox1.Checked == true)
            {
                bd = bd + bda; bm = bm + bma;
                odm = bd + bm;
                label3.Text = odm.ToString();
            }
            if (radioButton1.Checked == true && checkBox2.Checked == true)
            {
                bd= bd + bdb;
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked == true && checkBox2.Checked == true)
            {
                bm = bm + bmb;
                label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox2.Checked == true)
            {
                bd = bd + bdb; bm = bm + bmb;
                odm = bd + bm;
                label3.Text = odm.ToString();
            }
            if (radioButton1.Checked == true && checkBox3.Checked == true)
            {
                bd = bd + bdv;
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked == true && checkBox3.Checked == true)
            {
                bm = bm + bmv;
                label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox3.Checked == true)
            {
                bd = bd + bdv; bm = bm + bmv;
                odm = bd + bm;
                label3.Text = odm.ToString();
            }
            if (radioButton1.Checked == true && checkBox1.Checked == true && checkBox2.Checked==true )
            {
                bd = bda + bdb; 
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked == true && checkBox1.Checked == true && checkBox2.Checked == true)
            {
                bm = bma + bmb;
                label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox1.Checked == true && checkBox2.Checked == true)
            {
                odm = bda + bdb + bma + bmb;
                label3.Text = odm.ToString();
            }


            if (radioButton1.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true)
            {
                bd = bda + bdv;
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true)
            {
                bm = bma + bmv;
                label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true)
            {
                odm = bda + bdv + bma + bmv;
                label3.Text = odm.ToString();
            }


            if (radioButton1.Checked == true && checkBox3.Checked == true && checkBox2.Checked == true)
            {
                bd = bdv + bdb;
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked == true && checkBox3.Checked == true && checkBox2.Checked == true)
            {
                bm = bmv + bmb;
                label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox3.Checked == true && checkBox2.Checked == true)
            {
                odm = bdv + bdb + bmv + bmb;
                label3.Text = odm.ToString();
            }


            if (radioButton1.Checked == true && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked==true)
            {
                bd = bda + bdb + bdv;
                label3.Text = bd.ToString();
            }
            if (radioButton2.Checked == true && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                bm = bma + bmb + bmv;
                label3.Text = bm.ToString();
            }
            if (radioButton3.Checked == true && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                odm = bda + bdb + bdv + bma + bmb +bmv;
                label3.Text = odm.ToString();
            }
        }
        

    private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

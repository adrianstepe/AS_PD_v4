using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_PD_v4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ienākumi = Convert.ToDouble(textBox1.Text);
            double izdevumi = Convert.ToDouble(textBox2.Text);
            double kop = ienākumi + izdevumi;
            textBox3.Text = kop + " EUR";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double viens = Convert.ToDouble(textBox4.Text);
            double divi = Convert.ToDouble(textBox5.Text);
            double trīs = Convert.ToDouble(textBox6.Text);
            double Četri = Convert.ToDouble(textBox7.Text);
            double izdevumi1 = viens + divi + trīs + Četri;
            textBox9.Text = izdevumi1 + " EUR";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ienākumi = Convert.ToDouble(textBox1.Text);
            double izdevumi = Convert.ToDouble(textBox2.Text);

            double viens = Convert.ToDouble(textBox4.Text);
            double divi = Convert.ToDouble(textBox5.Text);
            double trīs = Convert.ToDouble(textBox6.Text);
            double Četri = Convert.ToDouble(textBox7.Text);

            double izdevumi1 = viens + divi + trīs + Četri;
            double kop = ienākumi + izdevumi;

            double budžeta_atlikums = kop - izdevumi1;
            textBox8.Text = budžeta_atlikums + " EUR";
        }
    }
}

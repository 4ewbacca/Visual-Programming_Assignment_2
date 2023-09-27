using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = textBox1.Text;
            string B = textBox2.Text;
            string C = textBox3.Text;
            int a_1 = Convert.ToInt32(A);
            int b_1 = Convert.ToInt32(B);
            int c_1 = Convert.ToInt32(C);
            decimal a_t = a_1 * 15.00m;
            decimal b_t = b_1 * 12.00m;
            decimal c_t = c_1 * 9.00m;
            decimal t_t = a_t + b_t + c_t;
            textBox4.Text = a_t.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));
            textBox5.Text = b_t.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));
            textBox6.Text = c_t.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));
            textBox7.Text = a_t.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

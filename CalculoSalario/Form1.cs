using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hora, vh, pdesc, salB, salL, tdesc;
            hora = double.Parse(textBox1.Text);
            vh = double.Parse(textBox2.Text);
            pdesc = double.Parse(textBox3.Text);

            salB = hora * vh;
            tdesc = (pdesc / 100) * salB;

            salL = salB - tdesc;

            salB = Math.Round(salB, 2);
            tdesc = Math.Round(tdesc, 2);
            salL = Math.Round(salL, 2);

            label6.Text = "R$" + salB.ToString();
            label7.Text = "R$" + salL.ToString();
            label9.Text = "R$" + tdesc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label6.Text = "";
            label7.Text = "";
            label9.Text = "";

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

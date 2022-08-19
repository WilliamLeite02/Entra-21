using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caixa1.Text = "Josnel Osvaldo";
            caixa1.ForeColor = Color.RoyalBlue;
            caixa2.Text = "+558 (69)99966-3388";
            caixa2.ForeColor = Color.Red;
            caixa3.Text = "Josnel Osvaldo@garanhao.com";
            caixa3.ForeColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            caixa1.Text = " ";
            caixa2.Text = " ";
            caixa3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl.Text = "Caiu na Pegadinha!!";
            lbl.ForeColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

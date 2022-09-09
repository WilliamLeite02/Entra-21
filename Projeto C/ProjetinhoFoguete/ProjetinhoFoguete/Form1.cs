using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetinhoFoguete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 clieForm = new Form2();
            clieForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cliForm = new Form2();
            cliForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 proForm = new Form3();
            proForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 compForm = new Form4();
            compForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 notfForm = new Form5();
            notfForm.ShowDialog();
        }
    }
}

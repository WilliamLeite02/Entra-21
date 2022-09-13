using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarketing
{
    public partial class frmentrada : Form
    {
        public frmentrada()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groaviso_Enter(object sender, EventArgs e)
        {

        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            Form2 formcomprar = new Form2();
            formcomprar.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pROYE
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form forma1 = new Problema_2();
            forma1.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form forma2 = new Problema_1();
            forma2.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Form forma3 = new Prueba_1();
            forma3.Show();
            this.Hide();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

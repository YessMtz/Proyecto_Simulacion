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
    public partial class Problema_2 : Form
    {
        public Problema_2()
        {
            InitializeComponent();
        }

        private void Problema2_Click(object sender, EventArgs e)
        {
            Form forma1 = new Problema_2();
            forma1.Show();
            this.Hide();
        }

        private void Problema1_Click(object sender, EventArgs e)
        {
            Form forma2 = new Problema_1();
            forma2.Show();
            this.Hide();
        }

        private void test1_Click(object sender, EventArgs e)
        {
            Form forma3 = new Prueba_1();
            forma3.Show();
            this.Hide();
        }

        private void test2_Click(object sender, EventArgs e)
        {
           
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Form forma5 = new Inicio();
            forma5.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

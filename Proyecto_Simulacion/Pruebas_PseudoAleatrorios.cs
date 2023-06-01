using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Simulacion
{
    public partial class Respuesta : Form
    {
        public Respuesta()
        {
            InitializeComponent();
        }

        private void Pruebas_PseudoAleatrorios_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarF1_Click(object sender, EventArgs e)
        {
            variableA.Clear();
            variableC.Clear();
            variableM.Clear();
            variableXN.Clear();
            numeros.Clear();
            alfa.Clear();
            promedio.Clear();
            Za_z.Clear();
            valorDistribucion.Clear();
            Lim_inf.Clear();
            Lim_Sup.Clear();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form Form1 = new Proyecto_Simulacion();
            Form1.ShowDialog();
            this.Hide();
        }
    }
}

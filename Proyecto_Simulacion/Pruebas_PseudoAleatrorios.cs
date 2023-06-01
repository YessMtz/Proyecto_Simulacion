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

        //numeros pseudo
        double numPseudo;





        private void Pruebas_PseudoAleatrorios_Load(object sender, EventArgs e)
        {
            int cantNum = Convert.ToInt32(numeros.Text);

           // int valoresPseudo = new int [cantNum];
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

        private void Generador_Click(object sender, EventArgs e)
        {


        }

        //FORMULA PARA BUSCAR SI UN NUMERO PSEUDO ALEATORIO ESTA DENTRO DE LA TABLA DE DISTRIBUCION NORMAL
        public void VerificarNum()
        {
           // for(int i =0; )
        }

        //FORMULA DE DISTRIBUCION NORMAL
        static double Gauss(double x)
        {
            return(1/Math.Sqrt(2*Math.PI)) * Math.Exp(-0.5 * Math.Pow(x, 2));

        }

        //TABLA DE DISTRIBUCION NORMAL
        public void TablaDistribucion()
        {
            double suma = 0.5;
            double gAnt = 0;
            for (int i = 0; i < 370; i++)
            {
                double x = (double)i / 100;
                double g = Gauss(x);
                if (i != 0)
                {
                    suma += (g + gAnt) / 2 / 100;
                }
                gAnt = g;
            }
        }
    }
}

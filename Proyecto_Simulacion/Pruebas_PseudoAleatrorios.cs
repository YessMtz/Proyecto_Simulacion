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
        double numPseudo, a1, c1, m1, Xo1, Xn1, promedioX, varAUX;





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

        //arreglo
        int vlN;
        public static double[] numerosX;

        //BOTON PARA GENERAR
        private void Generador_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(variableA.Text);
            c1 = double.Parse(variableC.Text);
            m1 = double.Parse(variableM.Text);
            Xo1 = double.Parse(variableXN.Text);
            vlN = int.Parse(cantidadNumeros.Text);

            numerosX = new double[vlN];

            double numsAle = double.Parse(cantidadNumeros.Text);
            double Xr;
            //ciclo para repetir las operaciones
            for (int i = 0; i < numsAle; i++)
            {

                //se agregan a la tabla
                int n1 = tablaValores.Rows.Add();
                tablaValores.Rows[n1].Cells[0].Value = i + 1;

                //calculo de numero pseudoaleatrorios
                Xn1 = (((a1 * Xo1) + c1) % m1);
                Xr = (Xn1 / m1);

                //redondeo de decimales
                Xr = Math.Round(Xr, 4);
                double dec = Xr;
                Xo1 = Convert.ToInt32(Xr * m1);

                //acumula los numeros
                numerosX[i] = Xr;
                varAUX= promedioX + Xr;

                //datos para la tabla
                tablaValores.Rows[n1].Cells[1].Value = Xr.ToString();

            }

            promedioX = varAUX / vlN;




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

        private void tablaValores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        //numeros pseudo
        double a1, c1, m1, Xo1, Xn1, varAUX, deStd, promedioX, Zcero, ZCal;

        private void Pruebas_PseudoAleatrorios_Load(object sender, EventArgs e)
        {
            int cantNum = Convert.ToInt32(TotalNum.Text);

           // int valoresPseudo = new int [cantNum];
        }

        private void LimpiarF1_Click(object sender, EventArgs e)
        {
            varA.Clear();
            varC.Clear();
            varM.Clear();
            varXn.Clear();
            TotalNum.Clear();
            alfa.Clear();
            promedio.Clear();
            desSTD.Clear();
            valorDistribucion.Clear();
            Lim_inf.Clear();
            Lim_Sup.Clear();
            gradoConfianza.Clear();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form Forma3 = new Proyecto_Simulacion();
            Forma3.Show();
            this.Hide();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
        }
        
        // BOTON PARA PRUEBA 2
        private void Prueba1_Click(object sender, EventArgs e)
        {
            double alfa1 = double.Parse(gradoConfianza.Text)/100;
            alfa.Text = Convert.ToString(alfa1);

            promedioX = varAUX / valoresN;
            promedio.Text = Convert.ToString(promedioX);

            Zcero = ((0.5 - promedioX) * Math.Sqrt(valoresN)) / Math.Sqrt(1 / 12);
            Lim_inf.Text = Convert.ToString(Zcero);

            double desviacion = double.Parse(gradoConfianza.Text) / 100;
            desSTD.Text = Convert.ToString(desviacion);

            ZCal = desviacion / 2;
            Lim_Sup.Text = Convert.ToString(ZCal);

            double GradoConfiaza = busGRado;
            if (Zcero >= GradoConfiaza)
            {
                respuesta.Text = "Si estan distribuidos uniformemente";
            }
            else
            {
                respuesta.Text = "No estan distribuidos uniformemente";
            }

        }

        private void Generador2_Click(object sender, EventArgs e)
        {
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Prueba2_Click(object sender, EventArgs e)
        {
            Form Forma2 = new Pruebas();
            Forma2.Show();
            this.Hide();
        }

        //arreglo
        int valoresN;
        public double[] numX;

        //BOTON PARA GENERAR VALORES PSEUDO
        private void Generador_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(varA.Text);
            c1 = double.Parse(varC.Text);
            m1 = double.Parse(varM.Text);
            Xo1 = double.Parse(varXn.Text);
            valoresN = int.Parse(TotalNum.Text);

            numX = new double[valoresN];
            double numAle = double.Parse(TotalNum.Text);
            double Xr1;

            //ciclo para repetir las operaciones
            for (int i = 0; i < numAle; i++)
            {
                //se agregan a la tabla
                int n1 = dataGridView1.Rows.Add();
                dataGridView1.Rows[n1].Cells[0].Value = i + 1;

                //calculo de numero pseudoaleatrorios
                Xn1 = (((a1 * Xo1) + c1) % m1);
                Xr1 = (Xn1 / m1);

                //redondeo de decimales
                Xr1 = Math.Round(Xr1, 4);
                double dec = Xr1;
                Xo1 = Convert.ToInt32(Xr1 * m1);

                //acumula los numeros
                numX[i] = Xr1;
                varAUX = varAUX + Xr1;

                //datos para la tabla
                dataGridView1.Rows[n1].Cells[1].Value = Xr1.ToString();

            }

            
        }
        double busGRado;


        //FORMULA DE DISTRIBUCION NORMAL
        static double Gauss(double x)
        {
            return(1/Math.Sqrt(2*Math.PI)) * Math.Exp(-0.5 * Math.Pow(x, 2));

        }

        //TABLA DE DISTRIBUCION NORMAL
        public double TablaDistribucion(double valor)
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
            
                if(gAnt == valor)
                {
                   busGRado = gAnt;
                }
            }
            return busGRado;

        }

        private void tablaValores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

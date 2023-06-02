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
    public partial class Pruebas_Pseudo2 : Form
    {
        public Pruebas_Pseudo2()
        {
            InitializeComponent();
        }
        double a, c, m, Xo, Xr, Xn, acumulador, promedioX;
        double Xalfa, Zk1, condicionCHi, Zcero;

        //corrida de la prueba
        private void Prueba1_Click(object sender, EventArgs e)
        {
            double alfa1 = double.Parse(gradoConfianza.Text) / 100;
            alfa.Text = Convert.ToString(alfa1);

            
            promedio.Text = Convert.ToString(promedioX);

            Zcero = ((0.5 - promedioX) * Math.Sqrt(valoresnumericos)) / Math.Sqrt(1 / 12);
            Lim_inf.Text = Convert.ToString(Zcero);

            double desviacion = double.Parse(gradoConfianza.Text) / 100;
            desSTD.Text = Convert.ToString(desviacion);

            Zk1 = desviacion / 2;
            Lim_Sup.Text = Convert.ToString(Zk1);

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

        private void Pruebas_Pseudo2_Load(object sender, EventArgs e)
        {

        }

        int valoresnumericos;
        public double[] numeros;

        private void Generador_Click(object sender, EventArgs e)
        {
            a = double.Parse(varA.Text);
            c = double.Parse(varC.Text);
            m = double.Parse(varM.Text);
            Xo = double.Parse(varXn.Text);

            int numerVal = int.Parse(TotalNum.Text);
            numeros = new double[numerVal];
            double aleatorios = double.Parse(TotalNum.Text);

            for(int i =0; i < aleatorios; i++)
            {
                int num = dataGridView3.Rows.Add();
                dataGridView3.Rows[num].Cells[0].Value = i + 1;

                Xn = (((a * Xo) + c) % m);
                Xr = (Xn / m);
                Xr = Math.Round(Xr, 4);
                double deci = Xr;
                Xo = Convert.ToInt32(Xr * m);
                
                numeros[i] = Xr;
                acumulador = acumulador + Xr;
                dataGridView3.Rows[num].Cells[1].Value = Xr.ToString();
            }

            promedioX = acumulador / valoresnumericos; 


        }
        double busGRado;


        //FORMULA DE DISTRIBUCION NORMAL
        static double Gauss(double x)
        {
            return (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp(-0.5 * Math.Pow(x, 2));

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

                if (gAnt == valor)
                {
                    busGRado = gAnt;
                }
            }
            return busGRado;

        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
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
            respuesta.Clear();

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form Forma2 = new Proyecto_Simulacion();
            Forma2.Show();
            this.Hide();
        }
    }
}

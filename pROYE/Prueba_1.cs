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
    public partial class Prueba_1 : Form
    {
        //declaracion de variables
        double varA1, varC1, varM1, varXr1, Xo, Xn, acumulador, promedio, Z_Cero, ZCal, promedio2, BuscarGrado;

        private void inicio_Click(object sender, EventArgs e)
        {
            Form forma4 = new Inicio();
            forma4.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            varA.Clear();
            varC.Clear();
            varM.Clear();
            varXr.Clear();
            canNum.Clear();
            alpha.Clear();
            promedio1.Clear();
            Zcero.Clear();
            desviacionSTD.Clear();
            Z_1.Clear();
        }

        private void Generar1_Click_1(object sender, EventArgs e)
        {
            varA1 = double.Parse(varA.Text);
            varC1 = double.Parse(varC.Text);
            varM1 = double.Parse(varM.Text);
            Xo = double.Parse(varXr.Text);
            num = int.Parse(canNum.Text);

            numAle = new double[num];
            //ciclo generador de numerosPseudo
            for (int i = 0; i < num; i++)
            {
                //INTEGRA EN LA TABLA
                int guardar = tablaPseudo1.Rows.Add();
                tablaPseudo1.Rows[guardar].Cells[0].Value = i + 1;

                //calculos
                Xn = (((varA1 * Xo) + varC1) % varM1);
                varXr1 = (Xn / varM1);
                varXr1 = Math.Round(varXr1, 5);
                double deci = varXr1;
                Xo = Convert.ToInt32(varXr1 * varM1);

                //asignacion de valores al array
                numAle[i] = varXr1;

                //ACUMULADOR
                acumulador = acumulador + varXr1;

                //mostrar en la tabla
                tablaPseudo1.Rows[guardar].Cells[1].Value = varXr1.ToString();
            }

            //promedio 
            promedio = acumulador / num;
        }

        private void test1_Click(object sender, EventArgs e)
        {
            Form forma3 = new Prueba_1();
            forma3.Show();
            this.Hide();
        }

        private void Problema2_Click(object sender, EventArgs e)
        {
            Form forma2 = new Problema_2();
            forma2.Show();
            this.Hide();
        }

        private void Problema1_Click(object sender, EventArgs e)
        {
            Form forma1 = new Problema_1();
            forma1.Show();
            this.Hide();
        }

        //inicializar prueba
        private void button1_Click(object sender, EventArgs e)
        {
            double alpha1 = double.Parse(alpha.Text) / 100;
            promedio2 = acumulador / num;
            promedio1.Text = Convert.ToString(promedio2);
            Z_Cero = ((0.5 - promedio2) * Math.Sqrt(num)) / Math.Sqrt(1 / 12);
            Zcero.Text = Convert.ToString(Z_Cero);

            double desviacion1 = Math.Sqrt(alpha1);
            desviacionSTD.Text = Convert.ToString(desviacion1);
            ZCal = desviacion1 / 2;
            Z_1.Text = Convert.ToString(ZCal);

            double gradoConfianza = BuscarGrado;
            if(Z_Cero >= gradoConfianza)
            {
                ResAnalisis.Text = "Si estan distribuidos uniformemente";
            }
            else 
            {
                ResAnalisis.Text = "No estan distribuidos uniformemente";
            }

        }

        private void Limpiar1_Click(object sender, EventArgs e)
        {
            varA.Clear();
            varC.Clear();
            varM.Clear();
            varXr.Clear();
            canNum.Clear();
        }

        int num;

        //arreglo de los numeros pseudoaleatorios
        public static double[] numAle;

        //boton para generar numeros pseudoaleatorios
        private void Generar1_Click(object sender, EventArgs e)
        {
           
        }
        public Prueba_1()
        {
            InitializeComponent();
        }

        //FORMULA DE DISTRIBUCION NORMAL
        static double Gauss(double X)
        {
            return (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp(-0.5 * Math.Pow(X, 2));
        }

        //tabla de distribucion normal
        public double TablaDisribucion(double valor)
        {
            double suma = 0.5;
            double gAnt = 0;

            for(int i= 0; i < 370; i++)
            {
                double x = (double)i / 100;
                double g = Gauss(x);
                if(i != 0)
                {
                    suma += (g + gAnt) / 2 / 100;
                }
                gAnt = g; 
                if(gAnt ==valor)
                {
                    BuscarGrado = gAnt;
                }
            }

            return BuscarGrado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_PseudoA
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        //declaracion de variables
        double varA1, varC1, varM1, varXr1, Xo, Xn, acumulador, promedio;

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

        private void Generar1_Click(object sender, EventArgs e)
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
    }
}

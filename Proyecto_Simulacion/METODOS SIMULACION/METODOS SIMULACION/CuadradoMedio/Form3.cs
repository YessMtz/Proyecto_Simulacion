using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadradoMedio
{
    public partial class medioproducto : Form
    {

        int N,N2;
        double sem1, sem2;
        int digitos;
        double produc;
        int num2 = 0;
        string num;
        double valor,valor1,valor2;
        int[] arreglo;
        public medioproducto()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void productomedio_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            menu recreso = new menu();
            recreso.Show();
            this.Hide();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            val1.Clear();
            val2.Clear();
            numero.Clear();
            tablita.Rows.Clear();
        }
        public void q()
        {





            try
            {
                num2 = Convert.ToInt32(numero.Text);

                valor1 = Convert.ToInt32(val1.Text);
                N = val1.Text.Count();
                valor2 = Convert.ToInt32(val2.Text);
                N2 = val2.Text.Count();





            }
            catch (FormatException)
            {

                MessageBox.Show("valores en el recuadro invalido");
                val1.Clear();
                val2.Clear();
                numero.Clear();
                tablita.Rows.Clear();

            }



            arreglo = new int[num2];
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            try
            {
                q();
               if (N == 4&&N2==4)
                    {
                for (int i = 0; i < num2; i++)
                {


                    
                        sem1 = Convert.ToDouble(valor1);
                        sem2 = Convert.ToDouble(valor2);
                        produc = Convert.ToDouble(valor1)* Convert.ToDouble(valor2);
                        num = Convert.ToString(produc);

                        digitos = num.Count();
                        if (digitos == 8)
                        {
                            num = num.Remove(0, 2);
                            num = num.Remove(4);
                            valor = Convert.ToInt32(num);


                        }

                        if (digitos == 7)
                        {
                            num = num.Remove(0, 1);
                            num = num.Remove(4);
                            valor = Convert.ToInt32(num);

                        }
                        if (digitos == 6)
                        {
                            num = num.Remove(4);
                            valor = Convert.ToInt32(num);


                        }
                        if (digitos == 5)
                        {
                            num = num.Remove(3);
                            valor = Convert.ToInt32(num);


                        }
                        int powEscribir = tablita.Rows.Count;

                       
                        tablita.Rows.Add();

                        tablita.Rows[powEscribir].Cells[0].Value = Convert.ToString(sem1);
                        tablita.Rows[powEscribir].Cells[1].Value = Convert.ToString(sem2);
                        tablita.Rows[powEscribir].Cells[2].Value = Convert.ToString(produc);
                        tablita.Rows[powEscribir].Cells[3].Value = Convert.ToString(valor);
                        tablita.Rows[powEscribir].Cells[4].Value = Convert.ToString((valor)/10000);
                        valor1 = valor2;
                        valor2 = valor;
                    }
                    


                }
               else
                    {
                        MessageBox.Show("ingrese un samilla de 4 digitos");
                        tablita.Rows.Clear();
                        val1.Clear();
                        numero.Clear();

                    }



                int rowNumber = 1;
                foreach (DataGridViewRow row in tablita.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.HeaderCell.Value = "" + rowNumber;
                    rowNumber = rowNumber + 1;
                }
                tablita.AutoResizeRowHeadersWidth(
                    DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);




            }
            catch (FormatException)
            {

                MessageBox.Show("valores en el recuadro invalido");
                tablita.Rows.Clear();
                val1.Clear();
                numero.Clear();


            }
        }
    }
}

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
    public partial class Problema_1 : Form
    {
        //declaracion de variables
        double varA1, varC1, varM1, varXr1, Xo, Xn, acumulador, promedio;

        private void Problema2_Click(object sender, EventArgs e)
        {
            Form forma1 = new Problema_2();
            forma1.Show();
            this.Hide();
        }

        private void Problema3_Click(object sender, EventArgs e)
        {
           
        }

        private void test1_Click(object sender, EventArgs e)
        {
            Form forma3 = new Prueba_1();
            forma3.Show();
            this.Hide();
        }

        private void test2_Click(object sender, EventArgs e)
        {
            /*Form forma4 = new Prueba_2();
            forma4.Show();
            this.Hide();
            */
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

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView1.ClearSelection();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();

        }

        //PRESENTACION DEL PROBLEMA
        private void Problema1_Click(object sender, EventArgs e)
        {
            Form FormaProblema = new Problema_2();
            FormaProblema.Show();
            this.Hide();

        }

        int num;
        
        //arreglo de los numeros pseudoaleatorios
        public static double [] numAle;
        
        //boton para generar numeros pseudoaleatorios
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
                Xo = Convert.ToInt32(varXr1*varM1);

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

        public string EvaluacionCamisas(double numPseudo1)
        {
                if (numPseudo1 >= 0 && numPseudo1 <= 0.30)
                {
                    return "Minimo 7 min";
                }
                else if(numPseudo1 > 0.30 && numPseudo1 <= 0.80)
                {
                    return "Moda 10 min";
                }
                else if(num >0.80 && numPseudo1<1.0)
                {
                    return "Maximo 12 min";
                }
            return "No aplica";
        }

        private void ValoresText_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int totalFilas = dataGridView1.Rows.Count;

                if (totalFilas <= 15)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        string valor = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        System.Windows.Forms.TextBox textBox = Controls.Find("txtNumero" + (i + 1), true).FirstOrDefault() as System.Windows.Forms.TextBox;

                        if (textBox != null)
                        {
                            textBox.Text = valor;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficientes números seudoaleatorios generados para copiar en los TextBox.");
                }
            }
            else
            {
                MessageBox.Show("No hay números seudoaleatorios generados.");
            }
        }

        private void GenerarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            System.Windows.Forms.TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5 };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                double valor = Convert.ToDouble(textBoxes[i].Text);
                string camisas = EvaluacionCamisas(valor);

                dataGridView1.Rows.Add(i + 1, camisas);
            }

                 dataGridView2.Rows.Clear();

                     double[] valores = 
                {
                        Convert.ToDouble(textBox6.Text),
                        Convert.ToDouble(textBox7.Text),
                        Convert.ToDouble(textBox8.Text),
                        Convert.ToDouble(textBox9.Text),
                        Convert.ToDouble(textBox10.Text)
                };

            for (int i = 0; i < valores.Length; i++)
            {
                double valor = valores[i];
                string pantalones = EvaluarPantalones(valor);

                dataGridView3.Rows.Add(i + 1, pantalones);
            }

            //datagrid 4
            dataGridView3.Rows.Clear();

            double[] valores2 = 
                {
                Convert.ToDouble(textBox11.Text),
                Convert.ToDouble(textBox12.Text),
                Convert.ToDouble(textBox13.Text),
                Convert.ToDouble(textBox14.Text),
                Convert.ToDouble(textBox15.Text)
            };

            for (int i = 0; i < valores2.Length; i++)
            {
                double valor = valores2[i];
                string sacos = EvaluarSacos(valor);
                dataGridView3.Rows.Add(i + 1, sacos);
            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Form forma4 = new Inicio();
            forma4.Show();
            this.Hide();
        }

        private string EvaluarPantalones(double numPseudo1)
        {
            if (numPseudo1 >= 0 && numPseudo1 <= 0.25)
            {
                return "Minimo 10 min";
            }
            else if (numPseudo1 > 0.25 && numPseudo1 <= 0.65)
            {
                return "Moda 14 min";
            }
            else if (num > 0.65 && numPseudo1 < 1.0)
            {
                return "Maximo 16 min";
            }
            return "No aplica";

        }

        private string EvaluarSacos(double numPseudo1)
        {
            if (numPseudo1 >= 0 && numPseudo1 <= 0.36)
            {
                return "Minimo 20 min";
            }
            else if (numPseudo1 > 0.36 && numPseudo1 <= 0.84)
            {
                return "Moda 23 min";
            }
            else if (num > 0.84 && numPseudo1 < 1.0)
            {
                return "Maximo 28 min";
            }
            return "No aplica";

        }

        public Problema_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<double> GetValoresTextBox()
        {
            List<double> numPseudo1 = new List<double>();

            numPseudo1.Add(Convert.ToDouble(textBox1.Text));
            numPseudo1.Add(Convert.ToDouble(textBox2.Text));
            numPseudo1.Add(Convert.ToDouble(textBox3.Text));
            numPseudo1.Add(Convert.ToDouble(textBox4.Text));
            numPseudo1.Add(Convert.ToDouble(textBox5.Text));
            numPseudo1.Add(Convert.ToDouble(textBox6.Text));
            numPseudo1.Add(Convert.ToDouble(textBox7.Text));
            numPseudo1.Add(Convert.ToDouble(textBox8.Text));
            numPseudo1.Add(Convert.ToDouble(textBox9.Text));
            numPseudo1.Add(Convert.ToDouble(textBox10.Text));
            numPseudo1.Add(Convert.ToDouble(textBox11.Text));
            numPseudo1.Add(Convert.ToDouble(textBox12.Text));
            numPseudo1.Add(Convert.ToDouble(textBox13.Text));
            numPseudo1.Add(Convert.ToDouble(textBox14.Text));
            numPseudo1.Add(Convert.ToDouble(textBox15.Text));

            return numPseudo1;
        }
        public bool EsNumeroRepetido(double numero, List<double> valores)
        {
            return valores.Contains(numero);
        }

        //boton para limpiar cuadros de texto
        private void Limpiar1_Click(object sender, EventArgs e)
        {
            varA.Clear();
            varC.Clear();
            varM.Clear();
            varXr.Clear();
            canNum.Clear();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView1.ClearSelection();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView1.ClearSelection();

        }
    }
}

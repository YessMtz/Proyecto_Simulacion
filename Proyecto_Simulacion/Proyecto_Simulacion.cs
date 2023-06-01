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
    public partial class Proyecto_Simulacion : Form
    {
        public Proyecto_Simulacion()
        {
            InitializeComponent();
        }
        double a, c, m, Xn, Xo;
        int cantNum;

        double SC, EM, RP, Sulf, AC, Fos, Ox;



        //tabla para agregar los datos
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        //limpiar cajas de texto
        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox31.Clear();
        }

        private void Proyecto_Simulacion_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //boton para generar y agregarlos a la tabla
        private void button1_Click(object sender, EventArgs e)
        {
            PseudoAle();

            //agregar nuevo renglon
            int n = dataGridView2.Rows.Add();




        }


        public void PseudoAle()
        {
            a = Convert.ToDouble(variableA.Text);
            c = Convert.ToDouble(variableC.Text);
            m = Convert.ToDouble(variableM.Text);
            Xo = Convert.ToDouble(variableXo.Text);
            Xn = Convert.ToDouble(variableXN.Text);
            double numsAle = Convert.ToDouble(cantidadNumeros.Text);

            //ciclo para repetir las operaciones
            for (int i = 0; i < numsAle; i++)
            {
                int n1= dataGridView1.Rows.Add();
                dataGridView1.Rows[n1].Cells[0].Value = i + 1;

                //calculo de numero pseudoaleatrorios
                Xn = (((a * Xo) + c) % m);
            
            }

        }

        //analisis de concentracion de contaminantes
        public void Contaminantes()
        {
            //Substacias coloidales = SC        0 a 0.05
            //Exceso Mercurio = EM              0.05 a 0.15
            //Residuos Pretroquimicos = RP      0.26 a 0.40
            //Sulfatos = Sulf                   0.40 a 0.55
            //Acido Clorhidrico =AC             0.55 a 0.67
            //Fosfatos = Fos                    0.67 a 0.83
            //Oxidos =Ox;                       0.83 a 1.0


            if (SC < 0.05f)
            { 
                
            }
        }


    }

   

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using execciones;
using chikolmogorov;

namespace CuadradoMedio
{
    public partial class cuadradomedio : Form
    {
        pruebachikolmogorov ob = new pruebachikolmogorov();

        int N;
        double Valor1;
        int digitos;
        double potencia;
        int num2 = 0, contador = 0;
        string num;
        double cuadrado, valor;
        double uno, dos;
        double[] arreglo = new double[1000];
        double[] iIn = new double[1000];
        double[] ri = new double[1000];
        double[] i1n = new double[1000];
        decimal[] inri = new decimal[1000];
        decimal[] ri1n2 = new decimal[1000];
        double sum = 0;
        decimal P  , superN=0;
        string[] nombres =new string[5] {"todo diferente","Un Par","Dos Pares","Tercia","Poker" };
        double[] pokernumero = new double[5] {0.3024,    .5040,     .1080,      0.0720,  .0045 };
        int unpar=0 ,dospares=0, tercia=0,td=0,poquer=0;
            

        public cuadradomedio()
        {
            InitializeComponent();
        }

        private void semilla_TextChanged(object sender, EventArgs e)
        {
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void calcular_Click(object sender, EventArgs e)
        {



            try {
                q();
                if (N == 4)
                {
                    for (int i = 0; i < num2; i++) {



                        Valor1 = Convert.ToDouble(valor);
                        potencia = Math.Pow(valor, 2);
                        num = Convert.ToString(potencia);

                        digitos = num.Count();
                        if (digitos == 8)
                        {
                            num = num.Remove(0, 2);//  12345678
                            num = num.Remove(4);
                            valor = Convert.ToInt32(num);


                        }

                        if (digitos == 7)
                        {
                            num = num.Remove(0, 1);//1234567
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
                        if (digitos == 4)//1234
                        {
                            num = num.Remove(2);
                            valor = Convert.ToInt32(num);


                        }
                        if (digitos == 3)
                        {
                            num = num.Remove(1);
                            valor = Convert.ToInt32(num);
                        }
                        if (digitos == 2)
                        {
                            i = num2;
                        }

                        arreglo[i] = (valor/10000);
                        int powEscribir = Tablas.Rows.Count;


                        Tablas.Rows.Add();

                        Tablas.Rows[powEscribir].Cells[0].Value = Convert.ToString(Valor1);
                        Tablas.Rows[powEscribir].Cells[1].Value = Convert.ToString(potencia);
                        Tablas.Rows[powEscribir].Cells[2].Value = Convert.ToString(valor);
                        Tablas.Rows[powEscribir].Cells[3].Value = Convert.ToString((valor) / 10000);
                    }

                    botonchi.Visible = true;
                    botonkol.Visible = true;

                }
                else {
                    MessageBox.Show("ingrese un samilla de 4 digitos");
                    Tablas.Rows.Clear();
                    varA.Clear();
                    numero.Clear();

                }



                int rowNumber = 1;
                foreach (DataGridViewRow row in Tablas.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.HeaderCell.Value = "" + rowNumber;
                    rowNumber = rowNumber + 1;
                }
                Tablas.AutoResizeRowHeadersWidth(
                    DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);



            }
            catch (FormatException)
            {

                MessageBox.Show("valores en el recuadro invalido");
                Tablas.Rows.Clear();
                varA.Clear();
                numero.Clear();


            }

        }




        private void scroll_Load(object sender, EventArgs e)
        {
            bucakol.Visible = false;
            botonkol.Visible = false;
            botonchi.Visible = false;
            tablachi.Visible = false;
            confianza.Visible = false;

            busquedaconfianza.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void q() {

            try
            {
                num2 = Convert.ToInt32(numero.Text);

                valor = Convert.ToInt32(varA.Text);
                N = varA.Text.Count();

            }
            catch (FormatException) {

                MessageBox.Show("valores en el recuadro invalido");
                varA.Clear();
                numero.Clear();
                Tablas.Rows.Clear();
            }
        }

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            botonkol.Visible = false;
            label1.Visible = false;
            numero.Visible = false;
            calcular.Visible = false;
            letrero1.Visible = true;
            respuesta.Visible = true;
            confianza.Visible = true;
            sem.Visible = false;
            botonchi.Visible = false;
            tablachi.Visible = true;
            busquedaconfianza.Visible = true;


            Tablas.Rows.Clear();
            double N;
            
            cuadrado = Math.Sqrt(num2);
            double cuadrado2 = 1 / cuadrado;
            uno = 0.00;
            dos = cuadrado2;

            for (int b = 0; b <Math.Sqrt(num2); b++)
            {
                
                contador = 0;
                for (int a = 0; a <= num2; a++)
                {

                    if (uno < arreglo[a] && arreglo[a] < dos) { 
                        contador++;}

                    

                }
                N = cuadrado - contador;
                N =Math.Pow( N,2);
                N = N / cuadrado;
                sum = sum + N;
                int powEscribir = Tablas.Rows.Count;
                Tablas.Rows.Add();
                Tablas.Rows[powEscribir].Cells[0].Value = Convert.ToString(uno + "-" + dos);
                Tablas.Rows[powEscribir].Cells[1].Value = Convert.ToString(contador);
                Tablas.Rows[powEscribir].Cells[2].Value = Convert.ToString(cuadrado);
                Tablas.Rows[powEscribir].Cells[3].Value = Convert.ToString(N);

               
                uno = dos;
                dos = dos + cuadrado2;
                Tsemilla.HeaderText = "intervalos";
                elevado.HeaderText = "Oi";
                newsemilla.HeaderText = "Ei";
                Resultado.HeaderText = "(Ei-Oi)^2/Ei";

            }
            int rowNumber = 1;
           
            int powEscribir1 = Tablas.Rows.Count;
            Tablas.Rows.Add();
            Tablas.Rows[powEscribir1].Cells[2].Value = Convert.ToString("Suma=");
            Tablas.Rows[powEscribir1].Cells[3].Value = Convert.ToString(sum);
          foreach (DataGridViewRow row in Tablas.Rows)
            {
                if (row.IsNewRow) continue;
                row.HeaderCell.Value = "" + rowNumber;
                rowNumber = rowNumber + 1;
            }
            Tablas.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void tablachi_Click(object sender, EventArgs e)
        {

            if (busquedaconfianza.Text == "")
            {
                MessageBox.Show("no debe estar vacio la casilla rellenela");

            }
            else {

                int m = Convert.ToInt32(busquedaconfianza.Text);
                double chip = ob.chi(num2, m);

                letrero1.Text = Convert.ToString(chip+"-"+sum);
                if (chip>sum)
                {
                    respuesta.Text = "es uniforme";

                }
                else respuesta.Text = "no es uniforme";
            }
        }

        private void respuesta_Click(object sender, EventArgs e)
        {

        }

        private void botonpoker_Click(object sender, EventArgs e)
        {
            Tablas.Rows.Clear();
            for (int i = 0; i < num2; i++)
            {
                string identificador = Convert.ToString(((arreglo[i]*10000)*10));

                int[] digitos = new int[4];
                //dijitos[0] = 1;
                //dijitos[1] = 2;
                //dijitos[2] = 1;
                //dijitos[3] = 1;
             
                
                
                
               

                string identificador2 = identificador.Remove(1);// 12340 = 1
                digitos[0] = Convert.ToInt32(identificador2);
           

                string identificador3 = identificador.Remove(2); //12340=12
                identificador3 = identificador3.Remove(0,1);//12=2
                digitos[1] = Convert.ToInt32(identificador3);
               


                string identificador4 = identificador.Remove(3);//12340=123
                identificador4 = identificador4.Remove(0,2);//123=3
                digitos[2] = Convert.ToInt32(identificador4);
               


                string identificador5 = identificador.Remove(0, 3);//12340=40
                digitos[3] = (Convert.ToInt32(identificador5))/10;//40=4





                if (digitos[0] == digitos[1] && digitos[0] == digitos[2] && digitos[0] == digitos[3])
                {

                    poquer++;
                }
                else
                {
                    //tercia
                    if ((digitos[0] == digitos[1] && digitos[0] == digitos[2]) || (digitos[0] == digitos[1] && digitos[0] == digitos[3]) || (digitos[0] == digitos[2] && digitos[0] == digitos[3]) || (digitos[1] == digitos[2] && digitos[1] == digitos[3]))
                    {
                        tercia++;
                    }
                    else
                    {
                        // dos pares
                        if ((digitos[0] == digitos[1] && digitos[2] == digitos[3]) || (digitos[0] == digitos[2] && digitos[1] == digitos[3]) || (digitos[0] == digitos[3] && digitos[1] == digitos[2]))
                        {
                            dospares++;

                        }
                        else
                        {
                            //un par
                            if (digitos[0] == digitos[1] || digitos[0] == digitos[2] || digitos[0] == digitos[3] || digitos[1] == digitos[2] || digitos[1] == digitos[3] || digitos[2] == digitos[3])
                            {

                                unpar++;

                            }
                            else
                            {
                                // todo diferente
                                td++;

                            }
                        }


                    }



                }

            }

            int[] oi = new int[5] { td,unpar,dospares,tercia,poquer };

            for (int i = 0; i < 5; i++)
            {
                int powEscribir = Tablas.Rows.Count;


                Tablas.Rows.Add();
                decimal ei =Convert.ToDecimal( pokernumero[i] * num2);
                decimal eioiei = ei - oi[i];
                eioiei = eioiei*eioiei;
                eioiei = eioiei / ei;

                
                Tablas.Rows[powEscribir].Cells[0].Value = Convert.ToString(nombres[i]);
                Tablas.Rows[powEscribir].Cells[1].Value = Convert.ToString(oi[i]);
                Tablas.Rows[powEscribir].Cells[2].Value = Convert.ToString(ei);
                Tablas.Rows[powEscribir].Cells[3].Value = Convert.ToString(eioiei);
                superN = superN + eioiei;

            }


            double raiz=num2;
            for (int i =0; i<100;i++) {
                if (raiz == 4 || raiz == 9 || raiz == 16 || raiz == 25 || raiz == 36 || raiz == 49 || raiz == 64 || raiz == 81 || raiz == 100) {

                    i = 100;

                }
                else {raiz++; }
                
            }

            string  emosmas;
                int m =95;
                double chip = ob.chi(raiz, m);
            string respuesta1;
            if (chip > Convert.ToDouble(superN))
            {
                respuesta1 = "es independiente";
                emosmas = "             <";

            }
            else { respuesta1= "no es independiente";
                emosmas = "             <";
            }
        



        int powEscribir2 = Tablas.Rows.Count;


            Tablas.Rows.Add();

            Tablas.Rows[powEscribir2].Cells[0].Value = Convert.ToString(respuesta1);
            Tablas.Rows[powEscribir2].Cells[1].Value = Convert.ToString(superN);
            Tablas.Rows[powEscribir2].Cells[2].Value = emosmas;
            Tablas.Rows[powEscribir2].Cells[3].Value = Convert.ToString(chip);

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonkol_Click(object sender, EventArgs e)
        {
            botonkol.Visible = false;
            botonchi.Visible = false;
            busquedaconfianza.Visible = true;
            bucakol.Visible = true;
            calcular.Visible = false;
            sem.Visible = false;
            confianza.Visible = true;
            label1.Visible = false;
            numero.Visible = false;
            for (int i = 0; i < num2 - 1; i++)
            {
                
                int minimo = i;
                double tem;
                for (int j = i + 1; j < num2; j++)
                {
                    if (arreglo[minimo] > arreglo[j]) { minimo = j; }
                }

                tem = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = tem;






            }
            Tablas.Rows.Clear();
            contador = 1;
            int repetidor = num2;

       
            Tablas.Columns.Add("0", " ");
            Tablas.Columns.Add("0", " ");
            for (int i = 0; i < repetidor; i++)
            {


               decimal iIn = decimal.Divide(contador,repetidor);
                double ri = arreglo[i];
                decimal i1n = decimal.Divide((contador - 1) , repetidor);
                decimal inr = iIn - Convert.ToDecimal (arreglo[i]);
                decimal ri1n = Convert.ToDecimal(arreglo[i]) - i1n;

                inri[i] = inr;
                ri1n2[i] = ri1n;

                int powEscribir = Tablas.Rows.Count;
                Tablas.Rows.Add();
                Tablas.Rows[powEscribir].Cells[0].Value = Convert.ToString(i + 1);
                Tablas.Rows[powEscribir].Cells[1].Value = Convert.ToString(iIn);
                Tablas.Rows[powEscribir].Cells[2].Value = Convert.ToString(arreglo[i]);
                Tablas.Rows[powEscribir].Cells[3].Value = Convert.ToString(i1n);
                Tablas.Rows[powEscribir].Cells[4].Value = Convert.ToString(inr);
                Tablas.Rows[powEscribir].Cells[5].Value = Convert.ToString(ri1n);
                contador++;
            }
            for (int i = 0; i < num2 - 1; i++)
            {

                int minimo = i;
                decimal tem;
                for (int j = i + 1; j < num2; j++)
                {
                    if (inri[minimo] > inri[j]) { minimo = j; }
                }

                tem = inri[minimo];
                inri[minimo] = inri[i];
                inri[i] = tem;
            }
            for (int i = 0; i < num2 - 1; i++)
            {

                int minimo = i;
                decimal tem;
                for (int j = i + 1; j < num2; j++)
                {
                    if (ri1n2[minimo] > ri1n2[j]) { minimo = j; }
                }

                tem = ri1n2[minimo];
                ri1n2[minimo] = ri1n2[i];
                ri1n2[i] = tem;
            }
            
            if (inri[repetidor - 1] > ri1n2[repetidor - 1])
            {
                P = inri[repetidor - 1];
            }
            else {
                 P = ri1n2[repetidor - 1];
            }
            int powEscribir1 = Tablas.Rows.Count;
            Tablas.Rows.Add();
            Tablas.Rows[powEscribir1].Cells[0].Value = Convert.ToString("N="+repetidor);
            Tablas.Rows[powEscribir1].Cells[1].Value = Convert.ToString("D+=" + inri[repetidor-1]);
            Tablas.Rows[powEscribir1].Cells[2].Value = Convert.ToString("D-=" + ri1n2[repetidor-1]);
            Tablas.Rows[powEscribir1].Cells[3].Value = Convert.ToString("D=" + P);

        }

        private void tablita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void poker_Click(object sender, EventArgs e)
        {
           
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            bucakol.Visible = false;
            label1.Visible = true;
            numero.Visible = true;
            calcular.Visible = true;
            botonchi.Visible = false;
            tablachi.Visible = false;
            busquedaconfianza.Visible = false;
            confianza.Visible = false;
            sem.Visible = true;
            letrero1.Visible = false;
            respuesta.Visible = false;
            Tsemilla.HeaderText = "Semilla";
            elevado.HeaderText = "Elevado";
            newsemilla.HeaderText = "Nueva semilla";
            Resultado.HeaderText = "Resultado";
            varA.Clear();
            numero.Clear();
            Tablas.Rows.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            menu recreso= new menu();
            recreso.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (busquedaconfianza.Text == "")
            {
                MessageBox.Show("no debe estar vacio la casilla rellenela");

            }
            else
            {

                int m = Convert.ToInt32(busquedaconfianza.Text);
          
                decimal chip = Convert.ToDecimal( ob.kolmogoro (num2,m ));

                letrero1.Text = Convert.ToString(chip + "-" + P);
                if (chip > P)
                {
                    respuesta.Text = "es uniforme";

                }
                else respuesta.Text = "no es uniforme";
            }


        }

        private void busquedaconfianza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

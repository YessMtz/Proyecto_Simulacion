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
    public partial class menu : Form
    {
        
        
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
          cuadradomedio cuadrado = new cuadradomedio();
            cuadrado.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void medioproducto_Click(object sender, EventArgs e)
        {
            medioproducto producto = new medioproducto();
            producto.Show();
            this.Hide();
        }

        private void multiplicador_Click(object sender, EventArgs e)
        {
            Contantemul multi = new Contantemul();
            multi.Show();
            this.Hide();
        }
    }
}

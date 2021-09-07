using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPans
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBoxUsuario.Clear();
            TxtBoxContraseña.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtBoxUsuario.Text == "Admin" && TxtBoxContraseña.Text == "A1234")
            {
                MessageBox.Show("BIENVENIDA ADMINISTRADORA");
                Form formulario = new Registro();
                formulario.Show();
            }
            if (TxtBoxUsuario.Text == "Erika" && TxtBoxContraseña.Text == "E569")
            {
                MessageBox.Show("BIENVENIDA ERIKA");
                Form formulario = new Ventas();
                formulario.Show();
            }
            if (TxtBoxUsuario.Text == "Nathalia" && TxtBoxContraseña.Text == "N458")
            {
                MessageBox.Show("BIENVENIDA NATHALIA");
                Form formulario = new Ventas();
                formulario.Show();
            }
            if (TxtBoxUsuario.Text == "Daniela" && TxtBoxContraseña.Text == "D187")
            {
                MessageBox.Show("BIENVENIDA DANIELA");
                Form formulario = new Ventas();
                formulario.Show();
            }
            if (TxtBoxUsuario.Text == "Persefone" && TxtBoxContraseña.Text == "P0510")
            {
                MessageBox.Show("BIENVENIDA DIOSA PERSEFONE, HADES LE MADA SALUDOS");
                Form formulario = new Ventas();
                formulario.Show();
            }
        }
    }
}

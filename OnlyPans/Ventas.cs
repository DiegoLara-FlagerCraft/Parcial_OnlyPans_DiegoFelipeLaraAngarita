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
    public partial class Ventas : Form
    {
        decimal TotalVentas = 0;
        public Ventas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxtHoraR.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxPanes.Text == "ALIÑADO")
            {
                decimal total = 1000 * NumericCantidad.Value;
                string totalcadena = "  $" + total + "";
                TextBoxTotal.Text = totalcadena;
                TotalVentas += total;
            }
            if (comboBoxPanes.Text == "NO ALIÑADO")
            {
                decimal total = 500 * NumericCantidad.Value;
                string totalcadena = "  $" + total + "";
                TextBoxTotal.Text = totalcadena;
                TotalVentas += total;
            }
            if (comboBoxPanes.Text == "ESPECIAL")
            {
                decimal total = 2000 * NumericCantidad.Value;
                string totalcadena = "  $" + total + "";
                TextBoxTotal.Text = totalcadena;
                TotalVentas += total;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextRegistro.Text += "REGISTRO \n" + "FECHA: " + DateTimeFecha.Text + "\n" + "HORA: " + TxtHoraR.Text + "\n" + "NOMBRE CLIENTE: " + TxtBoxNombreCliente.Text + "\n" + "CEDULA: " + TxtBoxCedula.Text + "\n"
                + "TIPO DE PAN: " + comboBoxPanes.Text + "\n" + "CANTIDAD: " + NumericCantidad.Value + "\n" + "TOTAL: " + TextBoxTotal.Text + "\n" + "---------------------------------------------" + "\n";

            String texto = richTextRegistro.Text;
            Form formulario = new Registro(texto);
            

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtBoxNombreCliente.Clear();
            TxtBoxCedula.Clear();
            NumericCantidad.Value = 0;
            TextBoxTotal.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("EL TOTAL DE LAS VENTAS FUE: $" + TotalVentas);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TxtHoraR.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}

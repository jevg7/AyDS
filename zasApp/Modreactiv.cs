using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zas_Sistema_Administrativo_y_Inventario
{
    public partial class Modreactiv : Form
    {
        public Modreactiv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDreactivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDreactivo.Text != "" && txtNombre.Text != "" && txtFormula.Text != "" && txtStock.Text != "" && txtPrecio.Text != "")
            {
                int idReactivo = 0;
                string nombreReactivo = "";
                string formulaReactivo = "";
                int stockReactivo = 0;
                decimal priceReactivo = 0;

                if (File.Exists("reactivos.txt"))
                {
                    StreamReader miLectura = new StreamReader("reactivos.txt");

                    idReactivo = Convert.ToInt32(txtIDreactivo.Text);
                    nombreReactivo = txtNombre.Text;
                    formulaReactivo = txtFormula.Text;
                    stockReactivo = Convert.ToInt32(txtStock.Text);
                    priceReactivo = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("reactivos.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    int i = 0;
                    for (i = 0; i<lineas.Length; i++)
                    {
                        string[] datos = lineas[i].Split(',');
                        if (Convert.ToInt32(datos[0]) == idReactivo)
                        {
                            encontrado = true;
                            lineas[i] = idReactivo + "," + nombreReactivo + "," + formulaReactivo + "," + stockReactivo + "," + priceReactivo;
                            break;
                        }
                    }
                    if (encontrado)
                    {

                        
                        File.WriteAllLines("reactivos.txt", lineas);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un reactivo con este ID");
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("reactivos.txt");


                    idReactivo = Convert.ToInt32(txtIDreactivo.Text);
                    nombreReactivo = txtNombre.Text;
                    formulaReactivo = txtFormula.Text;
                    stockReactivo = Convert.ToInt32(txtStock.Text);
                    priceReactivo = Convert.ToDecimal(txtPrecio.Text);
                    miEscritura.WriteLine(idReactivo + "," + nombreReactivo + "," + formulaReactivo + "," + stockReactivo + "," + priceReactivo);
                    miEscritura.Close();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }
        }

        private void Modreactiv_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

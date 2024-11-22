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
    public partial class ModHerramienta : Form
    {
        public ModHerramienta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarHerramienta_Click(object sender, EventArgs e)
        {
            if (txtIDHerramienta.Text != "" && txtNombreHerramient.Text != "" && txtStockHerramienta.Text != "" && txtPrecioHerramienta.Text != "")
            {
                int idHerramienta = 0;
                string nombreHerramienta = "";
                int stockHerramienta = 0;
                decimal priceHerramienta = 0;

                if (File.Exists("herramienta.txt"))
                {
                    StreamReader miLectura = new StreamReader("herramienta.txt");

                    idHerramienta = Convert.ToInt32(txtIDHerramienta.Text);
                    nombreHerramienta = txtNombreHerramient.Text;
                    stockHerramienta = Convert.ToInt32(txtStockHerramienta.Text);
                    priceHerramienta = Convert.ToDecimal(txtPrecioHerramienta.Text);

                    string[] lineas = File.ReadAllLines("herramienta.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    int i = 0;


                    for (i = 0; i < lineas.Length; i++)
                    {

                        string[] datos = lineas[i].Split(',');
                        if (Convert.ToInt32(datos[0]) == idHerramienta)
                        {
                            encontrado = true;
                            lineas[i] = idHerramienta + "," + nombreHerramienta + "," + stockHerramienta + "," + priceHerramienta;
                            break;
                        }
                    }
                    if (encontrado)
                    {


                        File.WriteAllLines("herramienta.txt", lineas);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un reactivo con este ID");
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("herramienta.txt");


                    idHerramienta = Convert.ToInt32(txtIDHerramienta.Text);
                    nombreHerramienta = txtNombreHerramient.Text;
                    stockHerramienta = Convert.ToInt32(txtStockHerramienta.Text);
                    priceHerramienta = Convert.ToDecimal(txtPrecioHerramienta.Text);
                    miEscritura.WriteLine(idHerramienta + "," + nombreHerramienta + "," + stockHerramienta + "," + priceHerramienta);
                    miEscritura.Close();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }
        }

        private void ModHerramienta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioHerramienta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStockHerramienta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreHerramient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDHerramienta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
    }
}

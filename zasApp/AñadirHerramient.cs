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
    public partial class AñadirHerramient : Form
    {
        public AñadirHerramient()
        {
            InitializeComponent();
        }

        private void AñadirHerramient_Load(object sender, EventArgs e)
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
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == idHerramienta)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    if (encontrado)
                    {
                        MessageBox.Show("Este ID ya esta ocupado");
                    }
                    else
                    {
                        StreamWriter miEscritura = new StreamWriter("herramienta.txt", append: true);
                        miEscritura.WriteLine(idHerramienta + "," + nombreHerramienta + "," + stockHerramienta + "," + priceHerramienta);
                        miEscritura.Close();
                        this.Close();
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
    }
}

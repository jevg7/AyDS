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
    public partial class AñadirOrden : Form
    {
        public AñadirOrden()
        {
            InitializeComponent();
        }

        private void AñadirOrden_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarHerramienta_Click(object sender, EventArgs e)
        {
            if (txtIDOrden.Text != "" &&  txtCantOrden.Text != "" && txtProdOrden.Text != "" && txtProveeOrden.Text != "")
            {
                int idOrden = 0;
                string dateOrden = "";
                int cantOrden = 0;
                string prodOrden = "";
                string provOrden = "";

                if (File.Exists("orden.txt"))
                {
                    StreamReader miLectura = new StreamReader("orden.txt");

                    idOrden = Convert.ToInt32(txtIDOrden.Text);
                    dateOrden = dtpOrden.ToString();
                    cantOrden = Convert.ToInt32(txtCantOrden.Text);
                    prodOrden = txtProdOrden.Text;
                    provOrden = txtProveeOrden.Text;

                    string[] lineas = File.ReadAllLines("orden.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == idOrden)
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
                        StreamWriter miEscritura = new StreamWriter("orden.txt", append: true);
                        miEscritura.WriteLine(idOrden + "," + dateOrden + ","  + cantOrden + "," + prodOrden + "," + provOrden);
                        miEscritura.Close();
                        this.Close();
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("orden.txt");


                    idOrden = Convert.ToInt32(txtIDOrden.Text);
                    cantOrden = Convert.ToInt32(txtCantOrden.Text);
                    prodOrden = txtProdOrden.Text;
                    provOrden = txtProveeOrden.Text;
                    miEscritura.WriteLine(idOrden + "," + dateOrden + "," + cantOrden + "," + prodOrden + "," + provOrden);
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

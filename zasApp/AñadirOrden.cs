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
using Zas_Sistema_Administrativo_y_Inventario.Inventario;



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
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            if (txtIDOrden.Text != "" &&  txtCantOrden.Text != "" && txtProdOrden.Text != "" && txtProveeOrden.Text != "")
            {

                Orden orden = new Orden();

                if (File.Exists("orden.txt"))
                {
                    StreamReader miLectura = new StreamReader("orden.txt");

                    orden.ID = Convert.ToInt32(txtIDOrden.Text);
                    orden.Date = Convert.ToDateTime(dtpOrden.Text);
                    orden.Quantity = Convert.ToInt32(txtCantOrden.Text);
                    orden.Product = txtProdOrden.Text;
                    orden.Provider = txtProveeOrden.Text;


                    string[] lineas = File.ReadAllLines("orden.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == orden.ID)
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
                        miEscritura.WriteLine(orden.ID + "," + orden.Date + ","  + orden.Quantity + "," + orden.Product + "," + orden.Provider);
                        miEscritura.Close();
                        this.Close();
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("orden.txt");


                    orden.ID = Convert.ToInt32(txtIDOrden.Text);
                    orden.Date = Convert.ToDateTime(dtpOrden.Text);
                    orden.Quantity = Convert.ToInt32(txtCantOrden.Text);
                    orden.Product = txtProdOrden.Text;
                    orden.Provider = txtProveeOrden.Text;
                    miEscritura.WriteLine(orden.ID + "," + orden.Date + "," + orden.Quantity + "," + orden.Product + "," + orden.Provider);
                    miEscritura.Close();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }
        }

        private void dtpOrden_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

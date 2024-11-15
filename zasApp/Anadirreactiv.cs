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
    public partial class Anadirreactiv : Form
    {
        public Anadirreactiv()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIDreactivo_TextChanged(object sender, EventArgs e)
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
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == idReactivo)
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
                        StreamWriter miEscritura = new StreamWriter("reactivos.txt",append : true);
                        miEscritura.WriteLine(idReactivo + "," + nombreReactivo + "," + formulaReactivo + "," + stockReactivo + "," + priceReactivo);
                        miEscritura.Close();
                        this.Close();
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

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Anadirreactiv_Load(object sender, EventArgs e)
        {

        }
    }
}

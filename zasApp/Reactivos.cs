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
    public partial class Reactivos : Form
    {
        public Reactivos()
        {
            InitializeComponent();
        }

        private void btnMostrarreact_Click(object sender, EventArgs e)
        {
            if (File.Exists("reactivos.txt"))
            {
                string[] lineas = File.ReadAllLines("reactivos.txt");
                
                if (lineas.Length > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Formula");
                    dt.Columns.Add("Stock");
                    dt.Columns.Add("Precio");
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dt.Rows.Add(datos);
                        
                    }
                    dtgvReactivos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay reactivos registrados");
                }

            }


            else
            {
                StreamWriter miEscritura = File.CreateText("reactivos.txt");              
                miEscritura.Close();

            }
        }

        private void btnAnadirNewReact_Click(object sender, EventArgs e)
        {
            Anadirreactiv frm = new Anadirreactiv();
            frm.ShowDialog();
        }

        private void btnModificarReactivo_Click(object sender, EventArgs e)
        {
            Modreactiv frm = new Modreactiv();
            frm.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reactivos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

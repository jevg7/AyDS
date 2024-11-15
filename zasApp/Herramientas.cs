using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zas_Sistema_Administrativo_y_Inventario
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirHerramientas_Click(object sender, EventArgs e)
        {
            AñadirHerramient frm = new AñadirHerramient();
            frm.ShowDialog();
        }

        private void btnModificarHerramientas_Click(object sender, EventArgs e)
        {
            ModHerramienta frm = new ModHerramienta();
            frm.ShowDialog();
        }

        private void Herramientas_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarHerra_Click(object sender, EventArgs e)
        {
            if (File.Exists("herramienta.txt"))
            {
                string[] lineas = File.ReadAllLines("herramienta.txt");

                if (lineas.Length > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Stock");
                    dt.Columns.Add("Precio");
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dt.Rows.Add(datos);

                    }
                    dtgvHerramientas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay herramientas registradas");
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

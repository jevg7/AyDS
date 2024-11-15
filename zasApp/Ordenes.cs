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
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarOrdenes_Click(object sender, EventArgs e)
        {
            if (File.Exists("orden.txt"))
            {
                string[] lineas = File.ReadAllLines("orden.txt");

                if (lineas.Length > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Proovedor");
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dt.Rows.Add(datos);

                    }
                    dtgvOrdenes.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay ordenes registradas");
                }
            }
        }

        private void btnAñadirOrdenes_Click(object sender, EventArgs e)
        {
            AñadirOrden frm = new AñadirOrden();
            frm.ShowDialog();
        }

        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            ModOrden frm = new ModOrden();
            frm.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

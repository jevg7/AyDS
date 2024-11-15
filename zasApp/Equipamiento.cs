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
    public partial class Equipamiento : Form
    {
        public Equipamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirequipamiento_Click(object sender, EventArgs e)
        {
            Añadirequipa frm = new Añadirequipa();
            frm.ShowDialog();
        }

        private void btnMostrarEquip_Click(object sender, EventArgs e)
        {
            if (File.Exists("equipamiento.txt"))
            {
                string[] lineas = File.ReadAllLines("equipamiento.txt");

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
                    dtgvEquipamiento.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay equipamiento registrado");
                }

            }


            else
            {
                StreamWriter miEscritura = File.CreateText("equipamiento.txt");
                miEscritura.Close();

            }
        }

        private void btnModificarEquip_Click(object sender, EventArgs e)
        {
            ModificarEquipa frm = new ModificarEquipa();
            frm.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Equipamiento_Load(object sender, EventArgs e)
        {

        }
    }
}

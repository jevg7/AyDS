using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zas_Sistema_Administrativo_y_Inventario
{
    public partial class Pantallaprinci : Form
    {
        public Pantallaprinci()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnreactivos_Click(object sender, EventArgs e)
        {
            Reactivos frm = new Reactivos();
            frm.ShowDialog();
            
        }

        private void btnEquipamiento_Click(object sender, EventArgs e)
        {
            Equipamiento frm = new Equipamiento();
            frm.ShowDialog();
        }

        private void btnherramientas_Click(object sender, EventArgs e)
        {
            Herramientas frm = new Herramientas();
            frm.ShowDialog();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            Ordenes frm = new Ordenes();
            frm.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion frm = new InicioSesion();
            frm.Show();
            this.Hide();
        }
    }
}

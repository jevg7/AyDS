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
    public partial class message_input : Form
    {
        public int value {get; set; }

        public message_input()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(txtValue.Text);
                DialogResult = DialogResult.Yes;
                value = cantidad;
            }
            catch (Exception)
            {
                MessageBox.Show("La cantidad tiene que ser entera");
                return;
            }   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}

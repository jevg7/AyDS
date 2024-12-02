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
    public partial class reporteHerramientas : Form
    {
        public reporteHerramientas()
        {
            InitializeComponent();
        }

        private void reporteHerramientas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

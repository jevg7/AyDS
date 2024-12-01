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
        private Button currentBtn;
        //private session ussession = new session();

        public Pantallaprinci()
        {
            InitializeComponent();
            test.Text = "Bienvenido "+session.usuario;
        }

        #region BotonesConfig
        //Colores
        private struct Colores
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
        }
        private void actButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                dsbButton();
                //Btn
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(40, 40, 40);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void dsbButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(27, 27, 27);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        #endregion


        private void Pantallaprinci_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void btnreactivos_Click(object sender, EventArgs e)
        {
            /*Reactivos frm = new Reactivos();
            frm.ShowDialog();*/
            actButton(sender, Colores.color1);
            Abrir_Form(new vReactivo());
        }

        private void btnEquipamiento_Click(object sender, EventArgs e)
        {
            /*Equipamiento frm = new Equipamiento();
            frm.ShowDialog();*/
            actButton(sender, Colores.color1);
            Abrir_Form(new vEquipamiento());
        }

        private void btnherramientas_Click(object sender, EventArgs e)
        {
            /*Herramientas frm = new Herramientas();
            frm.ShowDialog();*/
            actButton(sender, Colores.color1);
            Abrir_Form(new vHerramienta());
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            /*Ordenes frm = new Ordenes();
            frm.ShowDialog();*/
            actButton(sender, Colores.color1);
            Abrir_Form(new vOrden());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            /*Usuario frm = new Usuario();
            frm.ShowDialog();*/
            actButton(sender, Colores.color1);
            //Abrir_Form(new Reactivos());
        }


        private void Abrir_Form(object formhijo)
        {

            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion frm = new InicioSesion();
            frm.Show();
            this.Hide();
        }

        private void Pantallaprinci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
            test.Text = "Bienvenido " + session.usuario; // Establece el texto del control 'test' para mostrar un mensaje de bienvenida con el nombre de usuario de la clase 'session'.
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
                dsbButton(); // Desactiva el botón actualmente activo.
                             //Btn
                currentBtn = (Button)senderBtn; // Establece el botón actualmente clicado como el botón activo.
                currentBtn.BackColor = Color.FromArgb(40, 40, 40); // Establece el color de fondo del botón activo.
                currentBtn.ForeColor = color; // Establece el color del texto del botón activo.
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; // Establece la alineación del texto en el botón activo.
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; // Establece la relación entre el texto y la imagen en el botón activo.
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; // Establece la alineación de la imagen en el botón activo.
            }
        }

        private void dsbButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(27, 27, 27); // Establece el color de fondo del botón inactivo.
                currentBtn.ForeColor = Color.White; // Establece el color del texto del botón inactivo.
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; // Establece la alineación del texto en el botón inactivo.
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; // Establece la relación entre el texto y la imagen en el botón inactivo.
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; // Establece la alineación de la imagen en el botón inactivo.
            }

        }
        #endregion


        private void Pantallaprinci_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Establece el estado inicial de la ventana del formulario como maximizado.
        }


        private void btnreactivos_Click(object sender, EventArgs e)
        {

            actButton(sender, Colores.color1); // Llama al método 'actButton' para activar el botón clicado.
            Abrir_Form(new vReactivo()); // Abre el formulario 'vReactivo' dentro del panel contenedor.
        }

        private void btnEquipamiento_Click(object sender, EventArgs e)
        {

            actButton(sender, Colores.color1); // Llama al método 'actButton' para activar el botón clicado.
            Abrir_Form(new vEquipamiento()); // Abre el formulario 'vEquipamiento' dentro del panel contenedor.
        }

        private void btnherramientas_Click(object sender, EventArgs e)
        {

            actButton(sender, Colores.color1); // Llama al método 'actButton' para activar el botón clicado.
            Abrir_Form(new vHerramienta()); // Abre el formulario 'vHerramienta' dentro del panel contenedor.
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {

            actButton(sender, Colores.color1); // Llama al método 'actButton' para activar el botón clicado.
            Abrir_Form(new vOrden()); // Abre el formulario 'vOrden' dentro del panel contenedor.
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            /*Usuario frm = new Usuario();
            frm.ShowDialog();*/
            actButton(sender, Colores.color1); // Llama al método 'actButton' para activar el botón clicado.
            Abrir_Form(new vUsuario()); // Abre el formulario 'vUsuario' dentro del panel contenedor.
        }


        private void Abrir_Form(object formhijo)
        {

            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0); // Elimina cualquier control existente del panel contenedor.

            Form fh = formhijo as Form; // Convierte el objeto de entrada en un formulario.
            fh.TopLevel = false; // Establece la propiedad TopLevel del formulario como false.
            fh.Dock = DockStyle.Fill; // Establece la propiedad Dock del formulario para que ocupe todo el espacio del panel contenedor.
            this.pnlContenedor.Controls.Add(fh); // Agrega el formulario al panel contenedor.
            this.pnlContenedor.Tag = fh; // Establece la propiedad Tag del panel contenedor como el formulario.
            fh.Show(); // Muestra el formulario.
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion frm = new InicioSesion(); // Crea una nueva instancia del formulario 'InicioSesion'.
            frm.Show(); // Muestra el formulario 'InicioSesion'.
            this.Hide(); // Oculta el formulario actual.
        }

        private void Pantallaprinci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cierra la aplicación cuando se cierra el formulario.
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

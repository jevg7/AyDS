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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Método que se ejecuta al hacer clic en el botón "Ingresar"
        private void btningresar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y la contraseña ingresados en los campos de texto
            string user = txtUsuarioLogin.Text.Trim();
            string password = txtContraLogin.Text.Trim();

            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.");
                return;
            }

            // Verificar si el archivo de usuarios existe
            if (File.Exists("usuario.txt"))
            {
                // Leer todas las líneas del archivo de usuarios
                string[] lineas = File.ReadAllLines("usuario.txt");
                bool encontrado = false;

                // Procesar cada línea del archivo
                foreach (string linea in lineas)
                {
                    // Dividir la línea en sus campos separados por comas
                    string[] datos = linea.Split(',');

                    // Validar que la línea tenga exactamente 4 columnas
                    if (datos.Length != 4)
                    {
                        continue; // Ignorar líneas mal formateadas
                    }

                    // Comparar el usuario y la contraseña con los datos de cada línea
                    if (datos[1] == user && datos[2] == password)
                    {
                        encontrado = true;
                        session.usuario = datos[0]; // Nombre del usuario
                        session.rol = "Usuario";    // Aquí puedes asignar un rol según corresponda
                        break;
                    }
                }

                if (encontrado)
                {
                    // Mostrar la pantalla principal si el usuario y contraseña son correctos
                    Pantallaprinci frm = new Pantallaprinci();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    // Mostrar mensaje de error si no se encuentra el usuario
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            else
            {
                // Crear el archivo de usuarios por defecto si no existe
                using (StreamWriter miEscritura = File.CreateText("usuario.txt"))
                {
                    miEscritura.WriteLine("Administrador,Admin,123456,5551234567");
                }

                MessageBox.Show("Archivo de usuarios creado. Usuario: Admin, Contraseña: 123456");
            }
        }

        // Método que se ejecuta al cambiar el estado del checkbox "Mostrar contraseña"
        private void mostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar o ocultar la contraseña según el estado del checkbox
            if (mostrarContra.Checked)
            {
                txtContraLogin.PasswordChar = '\0'; // Mostrar caracteres
                hidden.Image = Properties.Resources.hidden; // Cambiar la imagen del botón
            }
            else
            {
                txtContraLogin.PasswordChar = '*'; // Ocultar caracteres
                hidden.Image = Properties.Resources.eye; // Cambiar la imagen del botón
            }
        }

        // Método que se ejecuta al cambiar el texto en el campo de contraseña
        private void txtContraLogin_TextChanged(object sender, EventArgs e)
        {
            // Ocultar caracteres en el campo de contraseña
            txtContraLogin.PasswordChar = '*';
        }

        // Método que se ejecuta al cargar el formulario de inicio de sesión
        private void InicioSesion_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        // Método que se ejecuta al hacer clic en el botón de ocultar/mostrar contraseña
        private void hidden_Click(object sender, EventArgs e)
        {
            // Cambiar el estado del checkbox "Mostrar contraseña"
            mostrarContra.Checked = !mostrarContra.Checked;
        }

        // Método que se ejecuta al cerrar el formulario de inicio de sesión
        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}

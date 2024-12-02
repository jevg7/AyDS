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

        /*private void btningresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuarioLogin.Text;
            string password = txtContraLogin.Text;
            if (File.Exists("usuario.txt"))
            {
                string[] lineas = File.ReadAllLines("usuario.txt");
                bool encontrado = false;
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    if (datos[1] == user && datos[2] == password)
                    {
                        encontrado = true;
                        session.usuario = datos[0];
                        session.rol = datos[2];
                        break;
                    }
                }
                if (encontrado)
                {
                    Pantallaprinci frm = new Pantallaprinci();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }


            else
            {
                StreamWriter miEscritura = File.CreateText("usuario.txt");
                miEscritura.WriteLine("Admin,123,1");
                miEscritura.Close();

            }

           
        }*/
        private void btningresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuarioLogin.Text.Trim();
            string password = txtContraLogin.Text.Trim();

            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.");
                return;
            }

            // Verificar si el archivo existe
            if (File.Exists("usuario.txt"))
            {
                string[] lineas = File.ReadAllLines("usuario.txt");
                bool encontrado = false;

                // Procesar cada línea del archivo
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    // Validar que la línea tenga exactamente 4 columnas
                    if (datos.Length != 4)
                    {
                        continue; // Ignorar líneas mal formateadas
                    }

                    // Comparar usuario y contraseña
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
                // Crear el archivo por defecto si no existe
                using (StreamWriter miEscritura = File.CreateText("usuario.txt"))
                {
                    miEscritura.WriteLine("Administrador,Admin,123456,5551234567");
                }

                MessageBox.Show("Archivo de usuarios creado. Usuario: Admin, Contraseña: 123456");
            }
        }


        private void mostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarContra.Checked)
            {
                txtContraLogin.PasswordChar = '\0';
                hidden.Image = Properties.Resources.hidden;
            }
            else
            {
                txtContraLogin.PasswordChar = '*';
                
                hidden.Image = Properties.Resources.eye;
            }
        }

        private void txtContraLogin_TextChanged(object sender, EventArgs e)
        {
            txtContraLogin.PasswordChar = '*';
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void hidden_Click(object sender, EventArgs e)
        {
            mostrarContra.Checked = !mostrarContra.Checked;
        }

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

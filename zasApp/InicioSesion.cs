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

        private void btningresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuarioLogin.Text;
            string password = txtContraLogin.Text;
            if (File.Exists("usuarios.txt"))
            {
                string[] lineas = File.ReadAllLines("usuarios.txt");
                bool encontrado = false;
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    if (datos[0] == user && datos[1] == password)
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
                StreamWriter miEscritura = File.CreateText("usuarios.txt");
                miEscritura.WriteLine("Admin,123,1");
                miEscritura.Close();

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

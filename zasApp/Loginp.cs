﻿using System;
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

    public partial class Loginp : Form
    {


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraLogin_TextChanged(object sender, EventArgs e)
        {

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

            /*Pantallaprinci frm = new Pantallaprinci();
            frm.Show();*/
        }

        private void olvideContraLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
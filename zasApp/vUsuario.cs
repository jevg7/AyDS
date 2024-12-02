using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Zas_Sistema_Administrativo_y_Inventario.Inventario;
using Zas_Sistema_Administrativo_y_Inventario.Usuarios;

namespace Zas_Sistema_Administrativo_y_Inventario
{
    public partial class vUsuario : Form
    {
    
        public vUsuario()
        {
            InitializeComponent();

            dgvUsuario.ColumnCount = 4;

            dgvUsuario.Columns[0].Name = "ID";
            dgvUsuario.Columns[1].Name = "NOMBRE";
            dgvUsuario.Columns[2].Name = "STOCK";
            dgvUsuario.Columns[3].Name = "PRECIO";

            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            mostrarDtgvUsuario();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "EDITAR";
            btnEdit.Text = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvUsuario.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            btnDel.HeaderText = "ELIMINAR";
            btnDel.Text = "ELIMINAR";
            btnDel.Name = "btnDel";
            btnDel.UseColumnTextForButtonValue = true;
            dgvUsuario.Columns.Add(btnDel);
        }
        private void mostrarDtgvUsuario()
        {
            if (File.Exists("usuario.txt"))
            {
                dgvUsuario.Rows.Clear();
                string[] lineas = File.ReadAllLines("usuario.txt");

                if (lineas.Length > 0)
                {
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dgvUsuario.Rows.Add(datos);
                    }
                }
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtTelefono.Text = "";
            btnGuardar.Enabled = false;
            btnAgrgr.Enabled = true;
        }

        private void btnAgrgr_Click(object sender, EventArgs e)
        {
            bool valido = false;

            if (txtNombre.Text != "" && txtUsuario.Text != "" && txtContraseña.Text != "" && txtTelefono.Text != "")
            {
               

                Admin user = new Admin();

                if (File.Exists("usuario.txt"))
                {
                    StreamReader miLectura = new StreamReader("usuario.txt");

                    user.Name = txtNombre.Text;
                    user.User = txtUsuario.Text;
                    user.Password = txtContraseña.Text;
                    user.Phone = txtTelefono.Text;

                    string[] lineas = File.ReadAllLines("usuario.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (datos[0] == txtUsuario.Text)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    if (encontrado)
                    {
                        MessageBox.Show("Este usuario ya esta existe");
                    }
                    else
                    {
                        StreamWriter miEscritura = new StreamWriter("usuario.txt", append: true);
                        miEscritura.WriteLine(equipo.ID + "," + equipo.Name + "," + equipo.Stock + "," + equipo.Price + "2");
                        miEscritura.Close();
                        idMax = idMax + 1;
                        txtID.Text = idMax.ToString();
                        MessageBox.Show("Equipamiento agregado correctamente");
                        Limpiar();
                        mostrarDtgvEquipa();
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("equipamiento.txt");

                    equipo.ID = Convert.ToInt32(txtID.Text);
                    equipo.Name = txtNombre.Text;
                    equipo.Stock = Convert.ToInt32(txtStock.Text);
                    equipo.Price = Convert.ToDecimal(txtPrecio.Text);
                    miEscritura.WriteLine(equipo.ID + "," + equipo.Name + "," + equipo.Stock + "," + equipo.Price + "2");
                    miEscritura.Close();
                    idMax = idMax + 1;
                    txtID.Text = idMax.ToString();
                    MessageBox.Show("Equipamiento agregado correctamente");
                    Limpiar();
                    mostrarDtgvEquipa();


                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }
        }
    }
}

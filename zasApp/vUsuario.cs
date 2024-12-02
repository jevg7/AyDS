using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zas_Sistema_Administrativo_y_Inventario
{
    public partial class vUsuario : Form
    {
        private string usuarioOriginal;
        public vUsuario()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            mostrarDtgvUsuario();
        }

        private void ConfigurarDataGridView()
        {
            dgvUsuario.ColumnCount = 4;
            dgvUsuario.Columns[0].Name = "NOMBRE";
            dgvUsuario.Columns[1].Name = "USUARIO";
            dgvUsuario.Columns[2].Name = "CONTRASEÑA";
            dgvUsuario.Columns[3].Name = "TELEFONO";
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "EDITAR",
                Text = "Editar",
                Name = "btnEdit",
                UseColumnTextForButtonValue = true
            };
            dgvUsuario.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn
            {
                HeaderText = "ELIMINAR",
                Text = "Eliminar",
                Name = "btnDel",
                UseColumnTextForButtonValue = true
            };
            dgvUsuario.Columns.Add(btnDel);
        }

        private void mostrarDtgvUsuario()
        {
            try
            {
                if (File.Exists("usuario.txt"))
                {
                    dgvUsuario.Rows.Clear();
                    string[] lineas = File.ReadAllLines("usuario.txt");

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 4) // Validación de columnas
                        {
                            dgvUsuario.Rows.Add(datos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("No puede dejar ningún campo vacío.");
                return;
            }

            try
            {
                var userLine = $"{txtNombre.Text},{txtUsuario.Text},{txtContraseña.Text},{txtTelefono.Text}";

                if (File.Exists("usuario.txt"))
                {
                    string[] lineas = File.ReadAllLines("usuario.txt");
                    if (lineas.Any(linea => linea.Split(',')[1] == txtUsuario.Text)) // Validar usuario único
                    {
                        MessageBox.Show("Este usuario ya existe.");
                        return;
                    }

                    File.AppendAllLines("usuario.txt", new[] { userLine });
                }
                else
                {
                    File.WriteAllText("usuario.txt", userLine + Environment.NewLine);
                }

                MessageBox.Show("Usuario agregado correctamente.");
                Limpiar();
                mostrarDtgvUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario: {ex.Message}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("No puede dejar ningún campo vacío.");
                    return;
                }

                // Verificar si el archivo de usuarios existe
                if (!File.Exists("usuario.txt"))
                {
                    MessageBox.Show("El archivo de usuarios no existe.");
                    return;
                }

                // Leer el archivo y procesar las líneas
                string[] lineas = File.ReadAllLines("usuario.txt");
                bool encontrado = false;

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');

                    // Validar que la línea tenga el formato correcto
                    if (datos.Length != 4)
                    {
                        continue; // Ignorar líneas mal formateadas
                    }

                    // Comparar el usuario original con el usuario en el archivo
                    if (datos[1] == usuarioOriginal) // Usar la variable temporal
                    {
                        encontrado = true;

                        // Actualizar los datos en el archivo con los valores del formulario
                        lineas[i] = $"{txtNombre.Text.Trim()},{txtUsuario.Text.Trim()},{txtContraseña.Text.Trim()},{txtTelefono.Text.Trim()}";
                        break;
                    }
                }

                if (encontrado)
                {
                    // Escribir las líneas actualizadas en el archivo
                    File.WriteAllLines("usuario.txt", lineas);
                    MessageBox.Show("Usuario actualizado correctamente.");
                    Limpiar();
                    mostrarDtgvUsuario();
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con el nombre de usuario original.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el usuario: {ex.Message}");
            }
        }





        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminar(string usuario)
        {
            try
            {
                if (!File.Exists("usuario.txt"))
                {
                    MessageBox.Show("No hay usuarios registrados.");
                    return;
                }

                string[] lineas = File.ReadAllLines("usuario.txt");
                string[] nuevasLineas = lineas.Where(linea => linea.Split(',')[1] != usuario).ToArray();

                File.WriteAllLines("usuario.txt", nuevasLineas);

                MessageBox.Show("Usuario eliminado correctamente.");
                mostrarDtgvUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}");
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                // Llenar los campos de texto con los valores de la fila seleccionada
                txtNombre.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
                txtUsuario.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                txtContraseña.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();

                // Guardar el usuario original en la variable temporal
                usuarioOriginal = dgvUsuario.CurrentRow.Cells[1].Value.ToString();

                btnGuardar.Enabled = true;
                btnAgrgr.Enabled = false;
            }

            if (dgvUsuario.Columns[e.ColumnIndex].Name == "btnDel")
            {
                Eliminar(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
            }
        }

    }
}


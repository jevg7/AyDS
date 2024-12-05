using Microsoft.Reporting.WinForms;
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
using Zas_Sistema_Administrativo_y_Inventario.Inventario;

namespace Zas_Sistema_Administrativo_y_Inventario
{

    public partial class vEquipamiento : Form
    {
        private List<Equipo> listaEquipos = new List<Equipo>();

        private int idMax = 0;

        //Inicializa la ventana
        public vEquipamiento()
        {
            InitializeComponent();
            dgvEquipamiento.ColumnCount = 4;

            dgvEquipamiento.Columns[0].Name = "ID";
            dgvEquipamiento.Columns[1].Name = "NOMBRE";
            dgvEquipamiento.Columns[2].Name = "STOCK";
            dgvEquipamiento.Columns[3].Name = "PRECIO";
            
            dgvEquipamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            getMaxID();
            mostrarDtgvEquipa();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "EDITAR";
            btnEdit.Text = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvEquipamiento.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            btnDel.HeaderText = "ELIMINAR";
            btnDel.Text = "ELIMINAR";
            btnDel.Name = "btnDel";
            btnDel.UseColumnTextForButtonValue = true;
            dgvEquipamiento.Columns.Add(btnDel);
        }

        //Obtiene el ID máximo
        private void getMaxID()
        {

            if (File.Exists("equipamiento.txt"))
            {
                string[] lineas = File.ReadAllLines("equipamiento.txt");

                if (lineas.Length > 0)
                {

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        Console.WriteLine(datos);
                        int temp = Convert.ToInt32(datos[0]);

                        if (idMax < temp)
                        {
                            idMax = temp;
                        }
                    }
                    idMax = idMax + 1;
                    txtID.Text = idMax.ToString();
                }
                else
                {
                    idMax = 1;
                    txtID.Text = idMax.ToString();
                }

            }


            else
            {
                StreamWriter miEscritura = File.CreateText("equipamiento.txt");
                miEscritura.Close();
                idMax = 1;

            }
        }

        //Muestra el DataGridView

        private void mostrarDtgvEquipa()
        {
            if (File.Exists("equipamiento.txt"))
            {
                dgvEquipamiento.Rows.Clear();
                string[] lineas = File.ReadAllLines("equipamiento.txt");

                if (lineas.Length > 0)
                {
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dgvEquipamiento.Rows.Add(datos);
                    }
                }
            }
        }

        //Limpia los campos
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            btnGuardar.Enabled = false;
            btnAgrgr.Enabled = true;
        }


        
        private void btnAgrgr_Click(object sender, EventArgs e)
        {
            //Valida que los campos no esten vacios
            bool valido = false;

            if (txtID.Text != "" && txtNombre.Text != "" && txtStock.Text != "" && txtPrecio.Text != "")
            {
                try
                {
                    Convert.ToDecimal(txtPrecio.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El precio debe ser un numero entero");
                    return;
                }

                try
                {
                    Convert.ToInt32(txtStock.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El stock debe ser un numero entero");
                    return;
                }

                Equipo equipo = new Equipo();
                //Valida si el archivo existe

                if (File.Exists("equipamiento.txt"))
                {
                    StreamReader miLectura = new StreamReader("equipamiento.txt");

                    equipo.ID = Convert.ToInt32(txtID.Text);
                    equipo.Name = txtNombre.Text;
                    equipo.Stock = Convert.ToInt32(txtStock.Text);
                    equipo.Price = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("equipamiento.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    //Recorre el archivo para validar si el ID ya existe
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == equipo.ID)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    //Si el ID ya existe muestra un mensaje
                    if (encontrado)
                    {
                        MessageBox.Show("Este ID ya esta ocupado");
                    }
                    else
                    //Si no existe el ID agrega el equipamiento
                    {
                        StreamWriter miEscritura = new StreamWriter("equipamiento.txt", append: true);
                        miEscritura.WriteLine(equipo.ID + "," + equipo.Name + "," + equipo.Stock + "," + equipo.Price + "2");
                        miEscritura.Close();
                        idMax = idMax + 1;
                        txtID.Text = idMax.ToString();
                        MessageBox.Show("Equipamiento agregado correctamente");
                        Limpiar();
                        mostrarDtgvEquipa();
                        CargarLista();
                    }

                }

                //Si no existe el archivo crea uno nuevo
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
                    CargarLista();


                }
            }
            //Si hay campos vacios muestra un mensaje
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }

        }

        //Carga la lista de equipamiento
        private void CargarLista()
        {
            if (File.Exists("equipamiento.txt"))
            {
                string[] lineas = File.ReadAllLines("equipamiento.txt");
                listaEquipos.Clear(); // Limpiar la lista para evitar duplicados

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length >= 4) // Validar que la línea contenga los campos necesarios
                    {
                        Equipo equipo = new Equipo
                        {
                            ID = Convert.ToInt32(datos[0]),
                            Name = datos[1],
                            Stock = Convert.ToInt32(datos[2]),
                            Price = Convert.ToDecimal(datos[3])
                        };

                        listaEquipos.Add(equipo); // Agregar a la lista
                    }
                }
            }
        }

        //Guarda los cambios en el archivo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNombre.Text != "" && txtStock.Text != "" && txtPrecio.Text != "")
            {
                try
                {
                    Convert.ToDecimal(txtPrecio.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El precio debe ser un numero entero");
                    return;
                }

                try
                {
                    Convert.ToInt32(txtStock.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El stock debe ser un numero entero");
                    return;
                }

                Equipo equipo = new Equipo();

                if (File.Exists("equipamiento.txt"))
                {
                    StreamReader miLectura = new StreamReader("equipamiento.txt");

                    equipo.ID = Convert.ToInt32(txtID.Text);
                    equipo.Name = txtNombre.Text;
                    equipo.Stock = Convert.ToInt32(txtStock.Text);
                    equipo.Price = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("equipamiento.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    int i = 0;
                    for (i = 0; i < lineas.Length; i++)
                    {
                        string[] datos = lineas[i].Split(',');
                        if (Convert.ToInt32(datos[0]) == equipo.ID)
                        {
                            encontrado = true;
                            lineas[i] = equipo.ID + "," + equipo.Name + "," + equipo.Stock + "," + equipo.Price + "2";
                            break;
                        }
                    }
                    if (encontrado)
                    {


                        File.WriteAllLines("equipamiento.txt", lineas);
                        MessageBox.Show("Equipamiento actualizado correctamente");
                        Limpiar();
                        mostrarDtgvEquipa();
                        CargarLista();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un equipamiento con este ID");
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

                    MessageBox.Show("Equipamiento actualizado correctamente");
                    Limpiar();
                    mostrarDtgvEquipa();
                    CargarLista();


                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }

        }

        //Cancela la operación
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            if (File.Exists("equipamiento.txt"))
            {
                string[] lineas = File.ReadAllLines("equipamiento.txt");

                if (lineas.Length > 0)
                {

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        Console.WriteLine(datos);
                        int temp = Convert.ToInt32(datos[0]);

                        if (idMax < temp)
                        {
                            idMax = temp;
                        }
                    }
                    txtID.Text = idMax.ToString();
                }

            }
        }

        //Elimina un equipamiento
        private void Eliminar(string id)
        {
            Equipo equipo = new Equipo();

            if (File.Exists("equipamiento.txt"))
            {
                StreamReader miLectura = new StreamReader("equipamiento.txt");


                string[] lineas = File.ReadAllLines("equipamiento.txt");
                miLectura.Close();
                bool encontrado = false;
                int i = 0;
                for (i = 0; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    if (Convert.ToInt32(datos[0]) == Convert.ToInt32(id))
                    {
                        encontrado = true;
                        lineas[i] = "";
                        break;
                    }
                }
                if (encontrado)
                {


                    File.WriteAllLines("equipamiento.txt", lineas);
                    var lines = File.ReadAllLines("equipamiento.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                    File.WriteAllLines("equipamiento.txt", lines);
                    MessageBox.Show("Equipamiento actualizado correctamente");
                    Limpiar();
                    mostrarDtgvEquipa();
                    CargarLista();
                }
                else
                {
                    MessageBox.Show("No se encontro un equipamiento con este ID");
                }

            }

        }

        //Muestra los datos en los campos
        private void dgvEquipamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquipamiento.Columns[e.ColumnIndex].Name == "btnEdit")
            {

                txtID.Text = "" + dgvEquipamiento.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = "" + dgvEquipamiento.CurrentRow.Cells[1].Value.ToString();
                txtStock.Text = "" + dgvEquipamiento.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = "" + dgvEquipamiento.CurrentRow.Cells[3].Value.ToString();
                btnGuardar.Enabled = true;
                btnAgrgr.Enabled = false;

            }

            if (dgvEquipamiento.Columns[e.ColumnIndex].Name == "btnDel")
            {
                Eliminar(dgvEquipamiento.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void vEquipamiento_Load(object sender, EventArgs e)
        {

        }

        //Genera el reporte
        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader miLectura = new StreamReader("equipamiento.txt");
                string[] lineas = File.ReadAllLines("equipamiento.txt");


                listaEquipos.Clear();
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    listaEquipos.Add(new Equipo
                    {
                        ID = Convert.ToInt32(datos[0]),
                        Name = datos[1],
                        Price = Convert.ToInt32(datos[3]),
                        Stock = Convert.ToInt32(datos[2]),
                      });
                }
                // Crea un origen de datos válido
                ReportDataSource dataSource = new ReportDataSource("dsEquipamiento", listaEquipos);

                reporteReactivos reporte = new reporteReactivos();

                // Configura el informe
                reporte.RvReactivos.LocalReport.DataSources.Clear();
                reporte.RvReactivos.LocalReport.DataSources.Add(dataSource);
                reporte.RvReactivos.LocalReport.ReportEmbeddedResource = "Zas_Sistema_Administrativo_y_Inventario.Reportes.rptEquipamiento.rdlc";

                // Actualiza el informe
                reporte.RvReactivos.RefreshReport();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

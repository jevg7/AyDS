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
    public partial class vHerramienta : Form
    {
        private int idMax = 0;  
        private List<Herramienta> listaHerramienta =new List<Herramienta>();
        public vHerramienta()
        {
            InitializeComponent();
            dgvHerramienta.ColumnCount = 4;

            dgvHerramienta.Columns[0].Name = "ID";
            dgvHerramienta.Columns[1].Name = "NOMBRE";
            dgvHerramienta.Columns[2].Name = "STOCK";
            dgvHerramienta.Columns[3].Name = "PRECIO";

            dgvHerramienta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            getMaxID();
            mostrarDtgvHerramienta();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "EDITAR";
            btnEdit.Text = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvHerramienta.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            btnDel.HeaderText = "ELIMINAR";
            btnDel.Text = "ELIMINAR";
            btnDel.Name = "btnDel";
            btnDel.UseColumnTextForButtonValue = true;
            dgvHerramienta.Columns.Add(btnDel);
        }

        private void getMaxID()
        {

            if (File.Exists("herramienta.txt"))
            {
                string[] lineas = File.ReadAllLines("herramienta.txt");

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
                StreamWriter miEscritura = File.CreateText("herramienta.txt");
                miEscritura.Close();
                idMax = 1;

            }
        }

        private void mostrarDtgvHerramienta()
        {
            if (File.Exists("herramienta.txt"))
            {
                dgvHerramienta.Rows.Clear();
                string[] lineas = File.ReadAllLines("herramienta.txt");

                if (lineas.Length > 0)
                {
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dgvHerramienta.Rows.Add(datos);
                    }
                }
            }
        }

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

                Herramienta herra = new Herramienta();

                if (File.Exists("herramienta.txt"))
                {
                    StreamReader miLectura = new StreamReader("herramienta.txt");

                    herra.ID = Convert.ToInt32(txtID.Text);
                    herra.Name = txtNombre.Text;
                    herra.Stock = Convert.ToInt32(txtStock.Text);
                    herra.Price = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("herramienta.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == herra.ID)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    if (encontrado)
                    {
                        MessageBox.Show("Este ID ya esta ocupado");
                    }
                    else
                    {
                        StreamWriter miEscritura = new StreamWriter("herramienta.txt", append: true);
                        miEscritura.WriteLine(herra.ID + "," + herra.Name + "," + herra.Stock + "," + herra.Price + "3");
                        miEscritura.Close();
                        idMax = idMax + 1;
                        txtID.Text = idMax.ToString();
                        MessageBox.Show("Herramienta agregada correctamente");
                        Limpiar();
                        mostrarDtgvHerramienta();
                        CargarLista();
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("herramienta.txt");

                    herra.ID = Convert.ToInt32(txtID.Text);
                    herra.Name = txtNombre.Text;
                    herra.Stock = Convert.ToInt32(txtStock.Text);
                    herra.Price = Convert.ToDecimal(txtPrecio.Text);
                    miEscritura.WriteLine(herra.ID + "," + herra.Name + "," + herra.Stock + "," + herra.Price + "3");
                    miEscritura.Close();
                    idMax = idMax + 1;
                    txtID.Text = idMax.ToString();
                    MessageBox.Show("Herramienta agregado correctamente");
                    Limpiar();
                    mostrarDtgvHerramienta();
                    CargarLista();


                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }

        }

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

                Herramienta herra = new Herramienta();

                if (File.Exists("herramienta.txt"))
                {
                    StreamReader miLectura = new StreamReader("herramienta.txt");

                    herra.ID = Convert.ToInt32(txtID.Text);
                    herra.Name = txtNombre.Text;
                    herra.Stock = Convert.ToInt32(txtStock.Text);
                    herra.Price = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("herramienta.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    int i = 0;
                    for (i = 0; i < lineas.Length; i++)
                    {
                        string[] datos = lineas[i].Split(',');
                        if (Convert.ToInt32(datos[0]) == herra.ID)
                        {
                            encontrado = true;
                            lineas[i] = herra.ID + "," + herra.Name + "," + herra.Stock + "," + herra.Price + "3";
                            break;
                        }
                    }
                    if (encontrado)
                    {


                        File.WriteAllLines("herramienta.txt", lineas);
                        MessageBox.Show("Herramienta actualizada correctamente");
                        Limpiar();
                        mostrarDtgvHerramienta();
                        CargarLista();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro una herramienta con este ID");
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("herramienta.txt");


                    herra.ID = Convert.ToInt32(txtID.Text);
                    herra.Name = txtNombre.Text;
                    herra.Stock = Convert.ToInt32(txtStock.Text);
                    herra.Price = Convert.ToDecimal(txtPrecio.Text);
                    miEscritura.WriteLine(herra.ID + "," + herra.Name + "," + herra.Stock + "," + herra.Price + "3");
                    miEscritura.Close();

                    MessageBox.Show("Herramienta actualizada correctamente");
                    Limpiar();
                    mostrarDtgvHerramienta();
                    CargarLista();


                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

            if (File.Exists("herramienta.txt"))
            {
                string[] lineas = File.ReadAllLines("herramienta.txt");

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

        private void Eliminar(string id)
        {
            Herramienta herra = new Herramienta();

            if (File.Exists("herramienta.txt"))
            {
                StreamReader miLectura = new StreamReader("herramienta.txt");


                string[] lineas = File.ReadAllLines("herramienta.txt");
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


                    File.WriteAllLines("herramienta.txt", lineas);
                    var lines = File.ReadAllLines("herramienta.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                    File.WriteAllLines("herramienta.txt", lines);
                    MessageBox.Show("Herramienta actualizada correctamente");
                    Limpiar();
                    mostrarDtgvHerramienta();

                }
                else
                {
                    MessageBox.Show("No se encontro una herramienta con este ID");
                }

            }

        }


        private void CargarLista()
        {
            if (File.Exists("herrmaienta.txt"))
            {
                string[] lineas = File.ReadAllLines("herramienta.txt");
                listaHerramienta.Clear(); // Limpiar la lista para evitar duplicados

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length >= 4) // Validar que la línea contenga los campos necesarios
                    {
                        Herramienta herramienta = new Herramienta
                        {
                            ID = Convert.ToInt32(datos[0]),
                            Name = datos[1],
                            Stock = Convert.ToInt32(datos[2]),
                            Price = Convert.ToDecimal(datos[3])
                        };

                        listaHerramienta.Add(herramienta); // Agregar a la lista
                    }
                }
            }
        }
        private void dgvHerramienta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHerramienta.Columns[e.ColumnIndex].Name == "btnEdit")
            {

                txtID.Text = "" + dgvHerramienta.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = "" + dgvHerramienta.CurrentRow.Cells[1].Value.ToString();
                txtStock.Text = "" + dgvHerramienta.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = "" + dgvHerramienta.CurrentRow.Cells[3].Value.ToString();
                btnGuardar.Enabled = true;
                btnAgrgr.Enabled = false;

            }

            if (dgvHerramienta.Columns[e.ColumnIndex].Name == "btnDel")
            {
                Eliminar(dgvHerramienta.CurrentRow.Cells[0].Value.ToString());

            }
        }


        private void vHerramienta_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader miLectura = new StreamReader("herramienta.txt");
                string[] lineas = File.ReadAllLines("herramienta.txt");


                listaHerramienta.Clear();
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    listaHerramienta.Add(new Herramienta
                    {
                        ID = Convert.ToInt32(datos[0]),
                        Name = datos[1],
                        Price = Convert.ToDecimal(datos[3]),
                        Stock = Convert.ToInt32(datos[2])
                    });
                }
                // Crea un origen de datos válido
                ReportDataSource dataSource = new ReportDataSource("dsHerramientas", listaHerramienta);

                reporteReactivos reporte = new reporteReactivos();

                // Configura el informe
                reporte.RvReactivos.LocalReport.DataSources.Clear();
                reporte.RvReactivos.LocalReport.DataSources.Add(dataSource);
                reporte.RvReactivos.LocalReport.ReportEmbeddedResource = "Zas_Sistema_Administrativo_y_Inventario.Reportes.rptHerramientas.rdlc";

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zas_Sistema_Administrativo_y_Inventario.Inventario;

namespace Zas_Sistema_Administrativo_y_Inventario
{
    public partial class vOrden : Form
    {
        private int precioTotal = 0;
        private int idMax = 0;
        private int idMax2 = 0;
        public vOrden()
        {
            // Inicializa el formulario
            InitializeComponent();
            getMaxID();
            getMaxID2();
            mostrarDGV();
            mostrarDGV2();
            txtEmpleado.Text = session.usuario;
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #region Agregar
        // Método que se ejecuta al hacer clic en el botón "Buscar"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtCodigo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El ID debe ser un numero entero");
                    return;
                }


                Reactivo reactivo = new Reactivo();
                Equipo equipo = new Equipo();
                Herramienta herra = new Herramienta();
                // Verificar si los archivos de productos existen

                if (File.Exists("reactivos.txt") && File.Exists("equipamiento.txt") && File.Exists("herramienta.txt"))
                {
                    StreamReader miLectura = new StreamReader("reactivos.txt");
                    string[] lineas = File.ReadAllLines("reactivos.txt");
                    miLectura.Close();


                    StreamReader miLectura2 = new StreamReader("equipamiento.txt");
                    string[] lineas2 = File.ReadAllLines("equipamiento.txt");
                    miLectura2.Close();

                    StreamReader miLectura3 = new StreamReader("herramienta.txt");
                    string[] lineas3 = File.ReadAllLines("herramienta.txt");
                    miLectura3.Close();

                    dgvBuscar.ColumnCount = 5;

                    dgvBuscar.Columns[0].Name = "ID";
                    dgvBuscar.Columns[1].Name = "NOMBRE";
                    dgvBuscar.Columns[2].Name = "STOCK";
                    dgvBuscar.Columns[3].Name = "PRECIO";
                    dgvBuscar.Columns[4].Name = "TIPO";

                    dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    DataGridViewButtonColumn btnSelect = new DataGridViewButtonColumn();
                    btnSelect.HeaderText = "";
                    btnSelect.Text = "Seleccionar";
                    btnSelect.Name = "btnSelect";
                    btnSelect.UseColumnTextForButtonValue = true;
                    dgvBuscar.Columns.Add(btnSelect);

                    dgvBuscar.Rows.Clear();

                    // Método para agregar una fila al DataGridView

                    void AgregarFila(string[] datos, string tipo)
                    {
                        dgvBuscar.Rows.Add(datos[0], datos[1], datos[2], datos[3], tipo);
                    }

                    // Procesar cada línea de los archivos de productos

                    foreach (var linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == Convert.ToInt32(txtCodigo.Text))
                        {
                            dgvBuscar.Rows.Add(datos[0], datos[1], datos[3], datos[4], "Reactivo");
                            break;
                        }
                    }

                    foreach (var linea in lineas2)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == Convert.ToInt32(txtCodigo.Text))
                        {
                            AgregarFila(datos, "Equipamiento");
                            break;
                        }
                    }

                    foreach (var linea in lineas3)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == Convert.ToInt32(txtCodigo.Text))
                        {
                            AgregarFila(datos, "Herramienta");
                            break;
                        }
                    }


                    if (dgvBuscar.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún elemento con el ID especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más archivos no existen. Verifique y vuelva a intentar.");
                }

            }


        }

        // Método que se ejecuta al hacer clic en el botón "Limpiar"
        private void Limpiar()
        {
            txtCodigo.Text = "";
            dgvBuscar.Rows.Clear();
            mostrarDGV();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        // Método para mostrar los productos en el DataGridView
        private void mostrarDGV()
        {

            if (File.Exists("reactivos.txt") && File.Exists("equipamiento.txt") && File.Exists("herramienta.txt"))
            {
                StreamReader miLectura = new StreamReader("reactivos.txt");
                string[] lineas = File.ReadAllLines("reactivos.txt");
                miLectura.Close();


                StreamReader miLectura2 = new StreamReader("equipamiento.txt");
                string[] lineas2 = File.ReadAllLines("equipamiento.txt");
                miLectura2.Close();

                StreamReader miLectura3 = new StreamReader("herramienta.txt");
                string[] lineas3 = File.ReadAllLines("herramienta.txt");
                miLectura3.Close();

                dgvBuscar.ColumnCount = 5;

                dgvBuscar.Columns[0].Name = "ID";
                dgvBuscar.Columns[1].Name = "NOMBRE";
                dgvBuscar.Columns[2].Name = "STOCK";
                dgvBuscar.Columns[3].Name = "PRECIO";
                dgvBuscar.Columns[4].Name = "TIPO";

                dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOrden.ReadOnly = true;

                DataGridViewButtonColumn btnSelect = new DataGridViewButtonColumn();
                btnSelect.HeaderText = "";
                btnSelect.Text = "Seleccionar";
                btnSelect.Name = "btnSelect";
                btnSelect.UseColumnTextForButtonValue = true;
                dgvBuscar.Columns.Add(btnSelect);

                dgvBuscar.Rows.Clear();


                void AgregarFila(string[] datos, string tipo)
                {
                    dgvBuscar.Rows.Add(datos[0], datos[1], datos[2], datos[3], tipo);
                }


                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    dgvBuscar.Rows.Add(datos[0], datos[1], datos[3], datos[4], "Reactivo");
                }

                foreach (var linea in lineas2)
                {
                    string[] datos = linea.Split(',');
                    AgregarFila(datos, "Equipamiento");
                }

                foreach (var linea in lineas3)
                {
                    string[] datos = linea.Split(',');
                    AgregarFila(datos, "Herramienta");
                }


                if (dgvBuscar.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún elemento con el ID especificado.");
                }
            }
            else
            {
                
            }
        }

        // Método que se ejecuta al hacer clic en el botón "Seleccionar"
        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBuscar.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                if (dgvBuscar.DataSource == null)
                {

                    dgvOrden.ColumnCount = 5;

                    dgvOrden.Columns[0].Name = "ID";
                    dgvOrden.Columns[1].Name = "NOMBRE";
                    dgvOrden.Columns[2].Name = "CANTIDAD";
                    dgvOrden.Columns[3].Name = "PRECIO";
                    dgvOrden.Columns[4].Name = "TIPO";

                    dgvOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOrden.ReadOnly = true;
                }

                message_input testDialog = new message_input();
                DialogResult result = testDialog.ShowDialog();

                if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Yes)
                {

                    string id = "" + dgvBuscar.CurrentRow.Cells[0].Value.ToString();
                    string nombre = "" + dgvBuscar.CurrentRow.Cells[1].Value.ToString();
                    string precio = "" + dgvBuscar.CurrentRow.Cells[3].Value.ToString();
                    string tipo = "" + dgvBuscar.CurrentRow.Cells[4].Value.ToString();
                    string cantidad = "" + testDialog.value;

                    dgvOrden.Rows.Add(id, nombre, cantidad, precio, tipo);

                    precioTotal += Convert.ToInt32(precio) * Convert.ToInt32(cantidad);
                    lblTotal.Text = "Total Estimado: " + precioTotal;
                }
                testDialog.Dispose();

            }

        }

       
        private void getMaxID()
        {

            if (File.Exists("orden.txt"))
            {
                string[] lineas = File.ReadAllLines("orden.txt");

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

                }
                else
                {
                    idMax = 1;

                }

            }


            else
            {
                StreamWriter miEscritura = File.CreateText("orden.txt");
                miEscritura.Close();
                idMax = 1;

            }
        }

        private void getMaxID2()
        {

            if (File.Exists("detalleOrden.txt"))
            {
                string[] lineas = File.ReadAllLines("detalleOrden.txt");

                if (lineas.Length > 0)
                {

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        Console.WriteLine(datos);
                        int temp = Convert.ToInt32(datos[0]);

                        if (idMax2 < temp)
                        {
                            idMax2 = temp;
                        }
                    }
                    idMax2 = idMax2 + 1;

                }
                else
                {
                    idMax2 = 1;

                }

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Ordn orden = new Ordn();

            if (dgvOrden.Rows.Count != 0)
            {
                if (File.Exists("orden.txt"))
                {
                    orden.ID = idMax;
                    orden.Date = Convert.ToDateTime(dtpFecha.Text);
                    orden.Employee = txtEmpleado.Text;
                    orden.DateTo = Convert.ToDateTime(dtpNeeed.Text);
                    orden.Total = precioTotal;

                    StreamWriter miEscritura = File.AppendText("orden.txt");
                    miEscritura.WriteLine(orden.ID + "," + orden.Date + "," + orden.Employee + "," + orden.DateTo + "," + orden.Total);
                    miEscritura.Close();
                    idMax = idMax + 1;

                    foreach (DataGridViewRow row in dgvOrden.Rows)
                    {

                        DetalleOrden detalle = new DetalleOrden();

                        detalle.ID = idMax2;
                        detalle.IDProduct = Convert.ToInt32(row.Cells[0].Value);
                        detalle.Product = row.Cells[1].Value.ToString();
                        detalle.Quantity = Convert.ToInt32(row.Cells[2].Value);
                        detalle.Price = Convert.ToInt32(row.Cells[3].Value);
                        detalle.Type = row.Cells[4].Value.ToString();

                        StreamWriter miEscritura2 = File.AppendText("detalleOrden.txt");
                        miEscritura2.WriteLine(detalle.ID + "," + detalle.IDProduct + "," + detalle.Product + "," + detalle.Quantity + "," + detalle.Price + "," + detalle.Type);
                        miEscritura2.Close();
                        idMax2 = idMax2 + 1;

                        dgvOrden.Rows.Clear();
                        MessageBox.Show("Orden guardada con éxito");

                    }
                    precioTotal = 0;
                    lblTotal.Text = "Total Estimado: ";
                    dgvOrden.Rows.Clear();

                }
                else
                {
                    orden.ID = idMax;
                    orden.Date = Convert.ToDateTime(dtpFecha.Text);
                    orden.Employee = txtEmpleado.Text;
                    orden.DateTo = Convert.ToDateTime(dtpNeeed.Text);
                    orden.Total = precioTotal;

                    StreamWriter miEscritura = File.CreateText("orden.txt");
                    miEscritura.WriteLine(orden.ID + "," + orden.Date + "," + orden.Employee + "," + orden.DateTo + "," + orden.Total);
                    miEscritura.Close();
                    foreach (DataGridViewRow row in dgvOrden.Rows)
                    {

                        DetalleOrden detalle = new DetalleOrden();

                        detalle.ID = idMax;
                        detalle.IDProduct = Convert.ToInt32(row.Cells[0].Value);
                        detalle.Product = row.Cells[1].Value.ToString();
                        detalle.Quantity = Convert.ToInt32(row.Cells[2].Value);
                        detalle.Price = Convert.ToInt32(row.Cells[3].Value);
                        detalle.Type = row.Cells[4].Value.ToString();

                        StreamWriter miEscritura2 = File.CreateText("detalleOrden.txt");
                        miEscritura2.WriteLine(detalle.ID + "," + detalle.IDProduct + "," + detalle.Product + "," + detalle.Quantity + "," + detalle.Price + "," + detalle.Type);
                        miEscritura2.Close();
                        idMax = idMax + 1;
                        dgvOrden.Rows.Clear();
                        MessageBox.Show("Orden guardada con éxito");




                    }
                    precioTotal = 0;
                    lblTotal.Text = "Total Estimado: ";
                    dgvOrden.Rows.Clear();

                }

            }

            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto para la orden");
                return;
            }
        }

        private void btnLimpiarOrden_Click(object sender, EventArgs e)
        {
            dgvOrden.Rows.Clear();
            lblTotal.Text = "Total Estimado: ";
            dtpNeeed.Value = DateTime.Now;
        }
        #endregion

        #region Buscar
        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            if (txtIdBusq.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtIdBusq.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El ID debe ser un numero entero");
                    return;
                }


                Ordn orden = new Ordn();
                DetalleOrden detalle = new DetalleOrden();

                if (File.Exists("orden.txt") && File.Exists("detalleOrden.txt"))
                {
                    StreamReader miLectura = new StreamReader("orden.txt");
                    string[] lineas = File.ReadAllLines("orden.txt");
                    miLectura.Close();


                    StreamReader miLectura2 = new StreamReader("detalleOrden.txt");
                    string[] lineas2 = File.ReadAllLines("detalleOrden.txt");
                    miLectura2.Close();

                    dgvBuscarOrden.ColumnCount = 5;

                    dgvBuscarOrden.Columns[0].Name = "ID";
                    dgvBuscarOrden.Columns[1].Name = "FECHA";
                    dgvBuscarOrden.Columns[2].Name = "EMPLEADDO";
                    dgvBuscarOrden.Columns[3].Name = "PARA";
                    dgvBuscarOrden.Columns[4].Name = "TOTAL";

                    dgvBuscarOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    DataGridViewButtonColumn btnDetalles = new DataGridViewButtonColumn();
                    btnDetalles.HeaderText = "Detalles";
                    btnDetalles.Text = "Detalles";
                    btnDetalles.Name = "btnDetalles";
                    btnDetalles.UseColumnTextForButtonValue = true;
                    dgvBuscarOrden.Columns.Add(btnDetalles);


                    dgvBuscarOrden.Rows.Clear();


                    void AgregarFila2(string[] datos)
                    {
                        dgvBuscarOrden.Rows.Add(datos[0], datos[2], datos[1], datos[3], datos[4]);
                    }



                    foreach (var linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == Convert.ToInt32(txtIdBusq.Text))
                        {
                            AgregarFila2(datos);
                            break;
                        }
                    }

                    if (dgvBuscar.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún elemento con el ID especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más archivos no existen. Verifique y vuelva a intentar.");
                }

            }
        }

        private void Limpiar2()
        {
            txtIdBusq.Text = "";
            dgvBuscarOrden.Rows.Clear();
            mostrarDGV2();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            Limpiar2();
        }

        private void mostrarDGV2()
        {

            if (File.Exists("orden.txt") && File.Exists("detalleOrden.txt"))
            {
                StreamReader miLectura = new StreamReader("orden.txt");
                string[] lineas = File.ReadAllLines("orden.txt");
                miLectura.Close();


                StreamReader miLectura2 = new StreamReader("detalleOrden.txt");
                string[] lineas2 = File.ReadAllLines("detalleOrden.txt");
                miLectura2.Close();

                dgvBuscarOrden.ColumnCount = 5;

                dgvBuscarOrden.Columns[0].Name = "ID";
                dgvBuscarOrden.Columns[1].Name = "FECHA";
                dgvBuscarOrden.Columns[2].Name = "EMPLEADO";
                dgvBuscarOrden.Columns[3].Name = "PARA";
                dgvBuscarOrden.Columns[4].Name = "TOTAL";

                dgvBuscarOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                DataGridViewButtonColumn btnDetalles = new DataGridViewButtonColumn();
                btnDetalles.HeaderText = "Detalles";
                btnDetalles.Text = "Detalles";
                btnDetalles.Name = "btnDetalles";
                btnDetalles.UseColumnTextForButtonValue = true;
                dgvBuscarOrden.Columns.Add(btnDetalles);


                dgvBuscarOrden.Rows.Clear();


                void AgregarFila2(string[] datos)
                {
                    dgvBuscarOrden.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                }



                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    AgregarFila2(datos);

                }


                if (dgvBuscar.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún elemento con el ID especificado.");
                }
            }
            else
            {
               
            }

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvBuscarOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBuscarOrden.Columns[e.ColumnIndex].Name == "btnDetalles")
            {

                if (dataGridView2.DataSource == null)
                {
                    dataGridView2.ColumnCount = 6;

                    dataGridView2.Columns[0].Name = "ID";
                    dataGridView2.Columns[1].Name = "ID PRODUCTO";
                    dataGridView2.Columns[2].Name = "PRODUCTO";
                    dataGridView2.Columns[3].Name = "CANTIDAD";
                    dataGridView2.Columns[4].Name = "PRECIO";
                    dataGridView2.Columns[5].Name = "TIPO";

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                }
                string idOrden = dgvBuscarOrden.Rows[e.RowIndex].Cells[0].Value.ToString();


                dataGridView2.Rows.Clear();


                if (File.Exists("detalleOrden.txt"))
                {
                    string[] lineas = File.ReadAllLines("detalleOrden.txt");

                    foreach (var linea in lineas)
                    {
                        string[] datos = linea.Split(',');


                        if (datos[0] == idOrden)
                        {
                            dataGridView2.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de detalles de órdenes no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion


    }
    
    
}


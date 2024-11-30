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
    public partial class vReactivo : Form
    {

        private int idMax = 0;

        public vReactivo()
        {
            InitializeComponent();
            dgvReactivos.ColumnCount = 5;

            dgvReactivos.Columns[0].Name = "ID";
            dgvReactivos.Columns[1].Name = "NOMBRE";
            dgvReactivos.Columns[2].Name = "FORMULA";
            dgvReactivos.Columns[3].Name = "STOCK";
            dgvReactivos.Columns[4].Name = "PRECIO";
            
           

            dgvReactivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            getMaxID();
            mostrarDtgvReact();
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "EDITAR";
            btnEdit.Text = "Editar";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvReactivos.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
            btnDel.HeaderText = "ELIMINAR";
            btnDel.Text = "ELIMINAR";
            btnDel.Name = "btnDel";
            btnDel.UseColumnTextForButtonValue = true;
            dgvReactivos.Columns.Add(btnDel);
        }
       

        private void getMaxID() {

            if (File.Exists("reactivos.txt"))
            {
                string[] lineas = File.ReadAllLines("reactivos.txt");

                if (lineas.Length > 0)
                {
                    
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                       Console.WriteLine(datos);
                        int temp = Convert.ToInt32(datos[0]);

                        if (idMax < temp) {
                            idMax = temp;
                        }
                    }
                    idMax = idMax + 1;
                    txtIDreactivo.Text = idMax.ToString();
                }
                else
                {
                    idMax = 1;
                    txtIDreactivo.Text = idMax.ToString();
                }

            }


            else
            {
                StreamWriter miEscritura = File.CreateText("reactivos.txt");
                miEscritura.Close();
                idMax = 1;

            }
        }

        private void btnAgrgrReact_Click(object sender, EventArgs e)
        {
            bool valido = false;

            if (txtIDreactivo.Text != "" && txtNombre.Text != "" && txtFormula.Text != "" && txtStock.Text != "" && txtPrecio.Text != "")
            {
                try {
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

                Reactivo reactivo = new Reactivo();

                if (File.Exists("reactivos.txt"))
                {
                    StreamReader miLectura = new StreamReader("reactivos.txt");

                    reactivo.ID = Convert.ToInt32(txtIDreactivo.Text);
                    reactivo.Name = txtNombre.Text;
                    reactivo.Formula = txtFormula.Text;
                    reactivo.Stock = Convert.ToInt32(txtStock.Text);
                    reactivo.Price = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("reactivos.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == reactivo.ID)
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
                        StreamWriter miEscritura = new StreamWriter("reactivos.txt", append: true);
                        miEscritura.WriteLine(reactivo.ID + "," + reactivo.Name + "," + reactivo.Formula + "," + reactivo.Stock + "," + reactivo.Price);
                        miEscritura.Close();
                        idMax = idMax + 1;
                        txtIDreactivo.Text = idMax.ToString();
                        MessageBox.Show("Reactivo agregado correctamente");
                        Limpiar();
                        mostrarDtgvReact();
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("reactivos.txt");


                    reactivo.ID = Convert.ToInt32(txtIDreactivo.Text);
                    reactivo.Name = txtNombre.Text;
                    reactivo.Formula = txtFormula.Text;
                    reactivo.Stock = Convert.ToInt32(txtStock.Text);
                    reactivo.Price = Convert.ToDecimal(txtPrecio.Text);
                    miEscritura.WriteLine(reactivo.ID + "," + reactivo.Name + "," + reactivo.Formula + "," + reactivo.Stock + "," + reactivo.Price);
                    miEscritura.Close();
                    idMax = idMax + 1;
                    txtIDreactivo.Text = idMax.ToString();
                    MessageBox.Show("Reactivo agregado correctamente");
                    Limpiar();
                    mostrarDtgvReact();


                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }


        }

        private void mostrarDtgvReact()
        {
            if (File.Exists("reactivos.txt"))
            {
                dgvReactivos.Rows.Clear();
                string[] lineas = File.ReadAllLines("reactivos.txt");

                if (lineas.Length > 0)
                {
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        dgvReactivos.Rows.Add(datos);
                    }
                }
            }


            else
            {
                StreamWriter miEscritura = File.CreateText("reactivos.txt");
                miEscritura.Close();

            }
        }
        
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtFormula.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            btnGuardarReact.Enabled = false;
            btnAgrgrReact.Enabled = true;
        }

        private void btnCancelarReact_Click(object sender, EventArgs e)
        {
            Limpiar();

            if(File.Exists("reactivos.txt"))
            {
                string[] lineas = File.ReadAllLines("reactivos.txt");

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
                    txtIDreactivo.Text = idMax.ToString();
                }

            }
        }
        

       


        private void btnGuardarReact_Click(object sender, EventArgs e)
        {
            if (txtIDreactivo.Text != "" && txtNombre.Text != "" && txtFormula.Text != "" && txtStock.Text != "" && txtPrecio.Text != "")
            {
                Reactivo reactivo = new Reactivo();

                if (File.Exists("reactivos.txt"))
                {
                    StreamReader miLectura = new StreamReader("reactivos.txt");

                    reactivo.ID = Convert.ToInt32(txtIDreactivo.Text);
                    reactivo.Name = txtNombre.Text;
                    reactivo.Formula = txtFormula.Text;
                    reactivo.Stock = Convert.ToInt32(txtStock.Text);
                    reactivo.Price = Convert.ToDecimal(txtPrecio.Text);

                    string[] lineas = File.ReadAllLines("reactivos.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    int i = 0;
                    for (i = 0; i < lineas.Length; i++)
                    {
                        string[] datos = lineas[i].Split(',');
                        if (Convert.ToInt32(datos[0]) == reactivo.ID)
                        {
                            encontrado = true;
                            lineas[i] = reactivo.ID + "," + reactivo.Name + "," + reactivo.Formula + "," + reactivo.Stock + "," + reactivo.Price;
                            break;
                        }
                    }
                    if (encontrado)
                    {


                        File.WriteAllLines("reactivos.txt", lineas);
                        MessageBox.Show("Reactivo actualizado correctamente");
                        Limpiar();
                        mostrarDtgvReact();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un reactivo con este ID");
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("reactivos.txt");


                    reactivo.ID = Convert.ToInt32(txtIDreactivo.Text);
                    reactivo.Name = txtNombre.Text;
                    reactivo.Formula = txtFormula.Text;
                    reactivo.Stock = Convert.ToInt32(txtStock.Text);
                    reactivo.Price = Convert.ToDecimal(txtPrecio.Text);
                    miEscritura.WriteLine(reactivo.ID + "," + reactivo.Name + "," + reactivo.Formula + "," + reactivo.Stock + "," + reactivo.Price);
                    miEscritura.Close();

                    MessageBox.Show("Reactivo actualizado correctamente");
                    Limpiar();
                    mostrarDtgvReact();


                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }
        }

        private void Eliminar(string id)
        {
            Reactivo reactivo = new Reactivo();

            if (File.Exists("reactivos.txt"))
            {
                StreamReader miLectura = new StreamReader("reactivos.txt");


                string[] lineas = File.ReadAllLines("reactivos.txt");
                miLectura.Close();
                bool encontrado = false;
                int i = 0;
                for (i = 0; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    if (Convert.ToInt32(datos[0]) == Convert.ToInt32(id) )
                    {
                        encontrado = true;
                        lineas[i] = "";
                        break;
                    }
                }
                if (encontrado)
                {


                    File.WriteAllLines("reactivos.txt", lineas);
                    var lines = File.ReadAllLines("reactivos.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                    File.WriteAllLines("reactivos.txt", lines);
                    MessageBox.Show("Reactivo actualizado correctamente");
                    Limpiar();
                    mostrarDtgvReact();
                }
                else
                {
                    MessageBox.Show("No se encontro un reactivo con este ID");
                }

            }

        }
        private void dgvReactivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReactivos.Columns[e.ColumnIndex].Name == "btnEdit")
            {

                txtIDreactivo.Text = "" + dgvReactivos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = "" + dgvReactivos.CurrentRow.Cells[1].Value.ToString();
                txtFormula.Text = "" + dgvReactivos.CurrentRow.Cells[2].Value.ToString();
                txtStock.Text = "" + dgvReactivos.CurrentRow.Cells[3].Value.ToString();
                txtPrecio.Text = "" + dgvReactivos.CurrentRow.Cells[4].Value.ToString();
                btnGuardarReact.Enabled = true;
                btnAgrgrReact.Enabled = false;

            }

            if (dgvReactivos.Columns[e.ColumnIndex].Name == "btnDel")
            {
                Eliminar(dgvReactivos.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void vReactivo_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Añadirequipa : Form
    {
        public Añadirequipa()
        {
            InitializeComponent();
        }

        private void txtPrecioEquip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarEquipa_Click(object sender, EventArgs e)
        {
            if (txtIDEquipa.Text != "" && txtNombreEquip.Text != "" && txtPrecioEquip.Text != "" && txtStockEquip.Text != "" )
            {
                int idEquipamiento = 0;
                string nombreEquipamiento = "";
                int stockEquipamiento = 0;
                decimal priceEquipamiento = 0;

                if (File.Exists("equipamiento.txt"))
                {
                    StreamReader miLectura = new StreamReader("equipamiento.txt");

                    idEquipamiento = Convert.ToInt32(txtIDEquipa.Text);
                    nombreEquipamiento = txtNombreEquip.Text;
                    stockEquipamiento = Convert.ToInt32(txtStockEquip.Text);
                    priceEquipamiento = Convert.ToDecimal(txtPrecioEquip.Text);

                    string[] lineas = File.ReadAllLines("equipamiento.txt");
                    miLectura.Close();
                    bool encontrado = false;
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');
                        if (Convert.ToInt32(datos[0]) == idEquipamiento)
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
                        StreamWriter miEscritura = new StreamWriter("equipamiento.txt", append: true);
                        miEscritura.WriteLine(idEquipamiento + "," + nombreEquipamiento + "," + stockEquipamiento + "," + priceEquipamiento);
                        miEscritura.Close();
                        this.Close();
                    }

                }

                else
                {
                    StreamWriter miEscritura = File.CreateText("equipamiento.txt");


                    idEquipamiento = Convert.ToInt32(txtIDEquipa.Text);
                    nombreEquipamiento = txtNombreEquip.Text;
                    stockEquipamiento = Convert.ToInt32(txtStockEquip.Text);
                    priceEquipamiento = Convert.ToDecimal(txtPrecioEquip.Text);
                    miEscritura.WriteLine(idEquipamiento + "," + nombreEquipamiento + "," + stockEquipamiento + "," + priceEquipamiento);
                    miEscritura.Close();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("No puede dejar ningun campo vacio");
            }
        }

        private void Añadirequipa_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ModificarEquipa : Form
    {
        public ModificarEquipa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModificarEquipa_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarEquipMod_Click(object sender, EventArgs e)
        {
            if (txtIDEquipa.Text != "" && txtNombreEquip.Text != "" && txtStockEquip.Text != "" && txtPrecioEquip.Text != "")
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
                    int i = 0;
                   
                    
                    for ( i = 0; i < lineas.Length; i++)
                    {
                      
                        string[] datos = lineas[i].Split(',');
                        if (Convert.ToInt32(datos[0]) == idEquipamiento)
                        {
                            encontrado = true;
                            lineas[i] = idEquipamiento + "," + nombreEquipamiento + "," + stockEquipamiento + "," + priceEquipamiento;
                            break;
                        }
                    }
                    if (encontrado)
                    {


                        File.WriteAllLines("equipamiento.txt", lineas);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un reactivo con este ID");
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
    }
}

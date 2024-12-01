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
    public partial class vOrden : Form
    {

        public vOrden()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

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

                if (File.Exists("reactivo.txt") && File.Exists("equipamiento.txt") && File.Exists("herramienta.txt"))
                {
                    StreamReader miLectura = new StreamReader("reactivo.txt");
                    string[] lineas = File.ReadAllLines("reactivo.txt");
                    miLectura.Close();


                    StreamReader miLectura2 = new StreamReader("equipamiento.txt");
                    string[] lineas2 = File.ReadAllLines("equipamiento.txt");
                    miLectura2.Close();

                    StreamReader miLectura3 = new StreamReader("herramienta.txt");
                    string[] lineas3 = File.ReadAllLines("herramienta.txt");
                    miLectura3.Close();

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
                      

                    }
                    else
                    {
                        MessageBox.Show("No se encontro un equipamiento con este ID");
                    }
                }








            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zas_Sistema_Administrativo_y_Inventario;

namespace Zas_Sistema_Administrativo_y_Inventario.Inventario
{
    public class Ordn
    {
        public int ID { get; set; }

        public string Employee { get; set; }

        public DateTime Date { get; set; }
      
        public DateTime DateTo { get; set; }

        public decimal Total { get; set; }

    }

    public class DetalleOrden
    {
        public int ID { get; set; }
        public int IDProduct { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

    }
}


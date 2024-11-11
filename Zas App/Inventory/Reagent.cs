using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zas_Sistema_Administrativo_y_Inventario.Inventory
{
    public class Reagent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Formula { get; set; }
        public string Stock { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }

    }
}

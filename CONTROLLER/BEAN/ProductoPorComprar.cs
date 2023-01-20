using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.CONTROLLER.BEAN {
    public class ProductoPorComprar {
        DATA_BASE.Controller db = new DATA_BASE.Controller();

        public ProductoPorComprar(int id) {
            this.ID_product = id;
            this.Name= db.getNameByID_product(id);

        }


        public int ID_product { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; } = 1;
        public double SubTotal { get; set; }  
    }
}

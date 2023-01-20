using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.CONTROLLER.BEAN {
    public  class MetodoDePago {
        public MetodoDePago(int ID_PaymentMethod, double amount) { 
            this.ID_payment = ID_PaymentMethod;
            this.amount = amount;
            this.state = true;
        }

        public int ID_payment { set; get; }
        public double amount { set; get; }
        public bool state { set; get; }
    }
}

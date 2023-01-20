using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.CONTROLLER {
    public class PaymenthMethodToList {

        DATA_BASE.Controller controller = new DATA_BASE.Controller();
        public List<CONTROLLER.BEAN.MetodoDePago> listadoDePago { get; } = new List<BEAN.MetodoDePago>(); 
        public void ADD(int id_metodoDePago, double monto) {
            BEAN.MetodoDePago pago = new BEAN.MetodoDePago(id_metodoDePago, monto);
            this.listadoDePago.Add(pago);
        }
    }
}

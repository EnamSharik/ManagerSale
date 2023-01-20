using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public List<PAYMENT_METHOD> EnablePaymentMethodTable() {

            var n = (from k in Conection.PAYMENT_METHOD
                        where k.STATE == true
                        select k).ToList();

            return n;

        }

        public List<PAYMENT_METHOD> PaymentMethodTable() {

            var n = (from k in Conection.PAYMENT_METHOD
                        select k).ToList();

            return n;

        }

        public bool AddPaymentMethod(string name) {
            bool ready = false;

            PAYMENT_METHOD PAY = new PAYMENT_METHOD() {
                METHOD = name,
                STATE = true
            };

            Conection.PAYMENT_METHOD.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            
            return ready;

        }

        public bool RemovePaymentMethod(int id) {
            bool ready = false;
             
                

            PAYMENT_METHOD pay = Conection.PAYMENT_METHOD.Where(s => s.ID_PAYMENT == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;
            
            return ready;
        }

        public bool EditPaymentMethod(int id, string name, bool state) {
            bool ready = false;
             
                

            PAYMENT_METHOD pay = Conection.PAYMENT_METHOD.Where(s => s.ID_PAYMENT == id).FirstOrDefault();
            pay.METHOD = name;
            pay.STATE = state;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }
    
    }
}

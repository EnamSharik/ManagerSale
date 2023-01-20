using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public List<TRANSACTION_DETAIL> EnableTransactionDetailTable() {
             
                
            var n = (from k in Conection.TRANSACTION_DETAIL
                        where k.STATE == true
                        select k).ToList();

            return n;
            

        }

        public List<TRANSACTION_DETAIL> TransactionDetailTable() {
             
                

            var n = (from k in Conection.TRANSACTION_DETAIL
                        select k).ToList();

            return n;
            

        }

        public bool AddTransactionDetail(int id_product, int id_transaction, int quantity, decimal price) {
            bool ready = false;

             

            TRANSACTION_DETAIL PAY = new TRANSACTION_DETAIL() {
                PRODUCT = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id_product).FirstOrDefault(),
                TRANSACTION_SALE = Conection.TRANSACTION_SALE.Where(s => s.ID_TRANSACTION == id_transaction).FirstOrDefault(),
                QUANTITY = quantity,
                PRICE = price,
                STATE = true
            };

            Conection.TRANSACTION_DETAIL.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            
            return ready;

        }

        public bool RemoveTransactionDetail(int id) {
            bool ready = false;
             
                
            TRANSACTION_DETAIL pay = Conection.TRANSACTION_DETAIL.Where(s => s.ID_TRANSACTION_DETAIL == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool EditTransactionDetail(int id, int id_product, int id_transaction, int quantity, decimal price, bool state) {
            bool ready = false;
             
                
            TRANSACTION_DETAIL PAY = Conection.TRANSACTION_DETAIL.Where(s => s.ID_TRANSACTION_DETAIL == id).FirstOrDefault();

            PAY.PRODUCT = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id).FirstOrDefault();
            PAY.QUANTITY = quantity;
            PAY.PRICE = price;
            PAY.STATE = state;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

    }
}

using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public List<TRANSACTION_PAYMENT_DETAIL> EnableTransactionPaymentDetailTable() {
             
                
            var n = (from k in Conection.TRANSACTION_PAYMENT_DETAIL
                        where k.STATE == true
                        select k).ToList();

            return n;
            

        }

        public List<TRANSACTION_PAYMENT_DETAIL> TransactionPaymentDetailTable() {

            var n = (from k in Conection.TRANSACTION_PAYMENT_DETAIL
                        select k).ToList();

            return n;
            

        }

        public bool AddTransactionPaymentDetail(int id_payment, int id_transaction, decimal transactionAmoun) {
            bool ready = false;

            var payment = (from n in Conection.PAYMENT_METHOD
                           where n.ID_PAYMENT == id_payment
                           select n).FirstOrDefault();

            var transactionsale = (from n in Conection.TRANSACTION_SALE
                                    where n.ID_TRANSACTION == id_transaction
                                    select n).FirstOrDefault();



            TRANSACTION_PAYMENT_DETAIL PAY = new TRANSACTION_PAYMENT_DETAIL() {
                PAYMENT_METHOD = payment,
                TRANSACTION_SALE = transactionsale,
                TRANSACTION_AMOUNT = transactionAmoun,
                STATE = true
            };

            Conection.TRANSACTION_PAYMENT_DETAIL.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            
            return ready;

        }

        public bool RemoveTransactionPaymentDetail(int id) {
            bool ready = false;
             
                
            TRANSACTION_PAYMENT_DETAIL pay = Conection.TRANSACTION_PAYMENT_DETAIL.Where(s => s.ID_TRANSACTION_PAYMENT_DETAIL== id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool EditTransactionPaymentDetail(int id, int id_payment, int id_transaction, decimal transactionAmoun, bool state) {
            bool ready = false;
             
                
            TRANSACTION_PAYMENT_DETAIL PAY = Conection.TRANSACTION_PAYMENT_DETAIL.Where(s => s.ID_TRANSACTION_PAYMENT_DETAIL == id).FirstOrDefault();

            PAY.PAYMENT_METHOD = Conection.PAYMENT_METHOD.Where(s => s.ID_PAYMENT == id_payment).FirstOrDefault();
            PAY.TRANSACTION_AMOUNT = transactionAmoun;
            PAY.STATE = state;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

    }
}

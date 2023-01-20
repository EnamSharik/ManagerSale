using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public IQueryable EnableBuyDetailTable() {
             
            var table = from n in Conection.BUY_DETAIL
                        where n.STATE == true
                        select n;
            return table;

            
        }

        public IQueryable BuyDetailTable() {
             
            var table = from n in Conection.BUY_DETAIL
                        select n;
            return table;

            
        }

        public bool AddBuyDetail(int id_buy, int id_product) {
            bool ready = false;

            BUY_DETAIL PAY = new BUY_DETAIL() {
                BUY = Conection.BUY.Where(s => s.ID_BUY == id_buy).FirstOrDefault(),
                PRODUCT = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id_product).FirstOrDefault(),
            };

            Conection.BUY_DETAIL.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            
        return ready;
        }

        public bool ModifyBuyDetail(int id, int id_buy, int id_product) {
            bool ready = false;

            BUY_DETAIL PAY = Conection.BUY_DETAIL.Where(s => s.ID_BUY_DETAIL == id).FirstOrDefault();
            PAY.BUY = Conection.BUY.Where(s => s.ID_BUY == id_buy).FirstOrDefault();
            PAY.PRODUCT = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id_product).FirstOrDefault();

            Conection.SubmitChanges();
            ready = true;

            return ready;
        }

        public bool RemoveBuyDetail(int id) {
            bool ready = false;
             

            BUY_DETAIL pay = Conection.BUY_DETAIL.Where(s => s.ID_BUY == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

    }
}

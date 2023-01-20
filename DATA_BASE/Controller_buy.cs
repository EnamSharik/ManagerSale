using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller { 
        public IQueryable EnableBuyTable() {

            var table = from n in Conection.BUY
                        where n.STATE == true
                        select new {
                            ID = n.ID_BUY,
                            PROVIDER = n.PROVIDER.COMPANY,
                            DATE_BUY = n.DATE_OF_BUY,
                            EXPIRATION = n.DATE_OF_EXPIRATION,
                            QUANTITY = n.QUANTITY_OF_PRODUCT,
                            COST = n.PURCHASE_COST,
                            STATE = n.STATE
                        };
            return table;

            
        }

        public IQueryable BuyTable() {
             
            var table = from n in Conection.BUY
                        select new {
                            ID = n.ID_BUY,
                            PROVIDER = n.PROVIDER.COMPANY,
                            DATE_BUY = n.DATE_OF_BUY,
                            EXPIRATION = n.DATE_OF_EXPIRATION,
                            QUANTITY = n.QUANTITY_OF_PRODUCT,
                            COST = n.PURCHASE_COST,
                            STATE = n.STATE
                        };
            return table;

            
        }
    
        public bool AddBuy(int id_provider, string dateBuy, string dateExp, int quantity, decimal purchaseCost) {
            bool ready = false;

            BUY PAY = new BUY() {
                PROVIDER = Conection.PROVIDER.Where(s => s.ID_PROVIDER == id_provider).FirstOrDefault(),
                DATE_OF_BUY = dateBuy,
                DATE_OF_EXPIRATION = dateExp,
                QUANTITY_OF_PRODUCT = quantity,
                PURCHASE_COST = purchaseCost,
                STATE = true
            };

            Conection.BUY.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool ModifyBuy(int id, int id_provider, string dateBuy, string dateExp, int quantity, decimal purchaseCost) {
            bool ready = false;

            BUY PAY = (from n in Conection.BUY
                       where n.ID_BUY == id
                       select n).FirstOrDefault();
            PAY.ID_PROVIDER = id_provider;
            PAY.DATE_OF_BUY = dateBuy;
            PAY.DATE_OF_EXPIRATION = dateExp;
            PAY.QUANTITY_OF_PRODUCT = quantity;
            PAY.PURCHASE_COST = purchaseCost;
            PAY.STATE = true;
                
            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool RemoveBuy(int id) {
            bool ready = false;

            BUY pay = Conection.BUY.Where(s => s.ID_BUY == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            return ready;
        }

        public int getLastID_BUY() {
            List<BUY> compra = (from k in Conection.BUY
                               select k).ToList();
            int id = compra.Last().ID_BUY;
            return id;
        }


    }
}

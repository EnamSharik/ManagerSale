using DevExpress.Utils.DPI;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        DATA_BASE.DataClassesDataContext Conection;
        public Controller(){
            
            if (CONTROLLER.GlobalVARS.ConexionDB != null) {
                Conection = new DataClassesDataContext(CONTROLLER.GlobalVARS.ConexionDB);
            } else {
                Conection = new DataClassesDataContext("Data Source=BRANDON-PC;Initial Catalog=POINT_OF_SALE;Integrated Security=True");
            }
        }

        
        public IQueryable EnableProductTable() {

            var n = (from prod in Conection.PRODUCT
                        where prod.STATE == true
                        select new {
                            ID = prod.ID_PRODUCT,
                            NAME = prod.NAME,
                            TRADEMARK = prod.TRADEMARK,
                            CODE = prod.CODE,
                            DESCRIPTION = prod.DESCRIPTION,
                            PRICE_COST = prod.PRICE_COST,
                            PRICE_SALE = prod.PRICE_SALE,
                            STOCK = prod.STOCK,
                            STATE = prod.STATE
                        });
            return n;
      

        }

        public IQueryable ProductTable() {

            var n = (from prod in Conection.PRODUCT
                        where prod.STATE == true
                        select new {
                            ID = prod.ID_PRODUCT,
                            NAME = prod.NAME,
                            TRADEMARK = prod.TRADEMARK,
                            CODE = prod.CODE,
                            DESCRIPTION = prod.DESCRIPTION,
                            PRICE_COST = prod.PRICE_COST,
                            PRICE_SALE = prod.PRICE_SALE,
                            STOCK = prod.STOCK,
                            STATE = prod.STATE
                        });
                
            return n;
            

        }

        public bool AddProduct(string tradeMark, string name, string code, string description, decimal price_cost,decimal price_sale, int stock) {
            bool ready = false;

            PRODUCT PAY = new PRODUCT() {
                TRADEMARK= tradeMark,
                CODE = code,
                NAME = name,
                DESCRIPTION = description,
                PRICE_COST = price_cost,
                PRICE_SALE = price_sale,
                STOCK = stock,
                STATE = true

            };

            Conection.PRODUCT.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            return ready;

        }

        public bool RemoveProduct(int id) {
            bool ready = false;
            
                
            PRODUCT pay = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            return ready;
        }

        public bool EditProduct(int id, string tradeMArk, string name, string code, string description, decimal price_cost, decimal price_sale, int stock, bool state) {
            bool ready = false;

            PRODUCT pay = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id).FirstOrDefault();



            pay.TRADEMARK = tradeMArk;
            pay.CODE = code;
            pay.NAME = name;
            pay.DESCRIPTION = description;
            pay.PRICE_COST = price_cost;
            pay.PRICE_SALE = price_sale;
            pay.STOCK = stock;
            pay.STATE = state;

            Conection.SubmitChanges();
            ready = true;
            
            return ready;
        }
        public int getIDByCompany(string company) {
            
            var k = Conection.PROVIDER.Where(x => x.STATE == true);
            int val = 0;
            foreach (var n in k) {
                if (n.COMPANY.Equals(company)) {
                    return n.ID_PROVIDER;
                } else {
                    val = 0;
                }

            }
            return val;
            
                
        }
    
        public decimal getPriceByID(int id) {
            
            var prod = Conection.PRODUCT.Where(s => s.ID_PRODUCT == id).FirstOrDefault();
            return (decimal)prod.PRICE_SALE;
        }
        public int getIDByName(string name) {
            var k = Conection.PRODUCT.Where(x => x.STATE == true);
            int val = 0;
            foreach (var n in k) {
                if (n.NAME.Equals(name)) {
                    return n.ID_PRODUCT;
                } else {
                    val = 0;
                }

            }
            return val;
        }

        public string getNameByID_product(int id) {
            var k = Conection.PRODUCT.Where(x => x.STATE == true);
            string val = "ERRRORRRRRR";
            foreach (var n in k) {
                if (n.ID_PRODUCT.Equals(id)) {
                    return n.NAME;
                } else {
                    continue;
                }

            }
            return val;
        }

        public int getLastID_product() {
            List<PRODUCT> products = (from n in Conection.PRODUCT
                                      select n).ToList();

            int id = products.Last().ID_PRODUCT;
            return id;
        }

        public void decrementoDeProducto(int cantidad, int id) {
            var inv = (from k in Conection.PRODUCT
                       where k.ID_PRODUCT == id
                       select k).FirstOrDefault();

            inv.STOCK -= cantidad;
            Conection.SubmitChanges();
        }
    }



}

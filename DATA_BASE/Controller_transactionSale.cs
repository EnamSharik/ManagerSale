using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGER_SALE.DATA_BASE {
    public partial class Controller {
        public List<TRANSACTION_SALE> EnableTransactionSaleTable() {
             
                
            var n = (from k in Conection.TRANSACTION_SALE
                        where k.STATE == true
                        select k).ToList();

            return n;
            

        }

        public List<TRANSACTION_SALE> TransactionSaleTable() {
             
                
            var n = (from k in Conection.TRANSACTION_SALE
                        select k).ToList();

            return n;
            

        }

        public bool AddTransactionSale(int id_client, int id_employees, decimal total) {
            bool ready = false;

            var cliente = (from k in Conection.CLIENT
                          where k.ID_CLIENT== id_client
                          select k).FirstOrDefault();

            var empleado = (from k in Conection.EMPLOYEES
                            where k.ID_EMPLOYEES == id_employees
                            select k).FirstOrDefault();

            TRANSACTION_SALE PAY = new TRANSACTION_SALE() {
                CLIENT = cliente,
                EMPLOYEES = empleado,
                DATE = DateTime.Now.Date.ToShortDateString(),
                TIME = DateTime.Now.ToShortTimeString(),
                TOTAL = total,
                STATE = true
            };
            Conection.TRANSACTION_SALE.InsertOnSubmit(PAY);
            Conection.SubmitChanges();
            ready = true;

            

            return ready;

        }

        public bool RemoveTransactionSale(int id) {
            bool ready = false;
             
            TRANSACTION_SALE pay = Conection.TRANSACTION_SALE.Where(s => s.ID_TRANSACTION == id).FirstOrDefault();
            pay.STATE = false;

            Conection.SubmitChanges();
            ready = true;

            
            return ready;
        }

        public bool EditTransactionSale(int id, int id_client, int id_employees, decimal total, bool state) {
            bool ready = false;
             

            TRANSACTION_SALE PAY = Conection.TRANSACTION_SALE.Where(s => s.ID_TRANSACTION == id).FirstOrDefault();
            PAY.CLIENT = Conection.CLIENT.Where(s => s.ID_CLIENT == id_client).FirstOrDefault();
            PAY.TOTAL = total;
            PAY.STATE = true;
                

            Conection.SubmitChanges();

            
            return ready;
        }

        public int getLastID_TRANSACTIONSALE() {
            List<TRANSACTION_SALE> TRANSS = (from K in Conection.TRANSACTION_SALE
                                             select K).ToList();
            
            return TRANSS.Last().ID_TRANSACTION;
            
        }

        public void generarFactura() {

            var query = from n in Conection.TRANSACTION_DETAIL
                        where n.TRANSACTION_SALE.ID_TRANSACTION == Conection.TRANSACTION_SALE.Count()
                        select new {
                            CANTIDAD = n.QUANTITY,
                            PRODUCTO = n.PRODUCT.NAME,
                            PRECIO = n.PRICE/n.QUANTITY,
                            SUBTOTAL = n.PRICE

                        };

            CONTROLLER.REPORTS.XtraReport1 FACTURA = new CONTROLLER.REPORTS.XtraReport1();
            FACTURA.DataSource = query;

            var query2 = (from n in Conection.TRANSACTION_DETAIL
                          where n.TRANSACTION_SALE.ID_TRANSACTION == Conection.TRANSACTION_SALE.Count()
                          select n).FirstOrDefault();

            FACTURA.Parameters["FACTURA"].Value = query2.ID_TRANSACTION;
            FACTURA.Parameters["FECHA"].Value = query2.TRANSACTION_SALE.DATE;
            FACTURA.Parameters["VENDEDOR"].Value = query2.TRANSACTION_SALE.EMPLOYEES.USER;
            FACTURA.Parameters["CLIENTE"].Value = query2.TRANSACTION_SALE.CLIENT.NAME;
            FACTURA.Parameters["NIT"].Value = query2.TRANSACTION_SALE.CLIENT.NIT;
            FACTURA.Parameters["TOTALAPAGAR"].Value = query2.TRANSACTION_SALE.TOTAL;

            FACTURA.RequestParameters = false;
            ReportPrintTool IMPRESORA = new ReportPrintTool(FACTURA);
            IMPRESORA.Report.CreateDocument(false);
            IMPRESORA.AutoShowParametersPanel= false;
            IMPRESORA.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            IMPRESORA.ShowPreviewDialog();

            
        }
        private void PreviewForm_Load(object sender, EventArgs e ) {
            PrintPreviewFormEx asdfk = (PrintPreviewFormEx)sender;

        }
    }
}

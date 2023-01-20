using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.SALE {
    public partial class frame_datoClient : DevExpress.XtraEditors.XtraForm {

        //public CONTROLLER.PaymenthMethodToList gestorDeMetodosDePagoEnlistados { get; set; } = new CONTROLLER.PaymenthMethodToList();
        double monto { get; set; }
        

        DATA_BASE.Controller ControlDB = new DATA_BASE.Controller();
        public frame_datoClient(double monto) {
            InitializeComponent();
            //this.productoToLists = listadoProductos;
            this.monto= monto;
            
        }
        

        private void frame_datoClient_Load(object sender, EventArgs e) {

            this.searchLookUpEdit_metodosAlternativos.Properties.DataSource = ControlDB.EnablePaymentMethodTable();
            this.searchLookUpEdit_metodosAlternativos.Properties.ValueMember = "ID_PAYMENT";
            this.searchLookUpEdit_metodosAlternativos.Properties.DisplayMember = "METHOD";

            searchLookUpEdit_nit.Properties.DataSource = ControlDB.EnableClientTable();
            searchLookUpEdit_nit.Properties.ValueMember= "ID_CLIENT";
            searchLookUpEdit_nit.Properties.DisplayMember = "NAME";

            searchLookUpEdit_nit.Enabled = false;
            this.button_generateCheck.Enabled = false;

        }

        private void button_efective_Click(object sender, EventArgs e) {
            INTERFACE.SALE.frame_paymentEfective pago = new frame_paymentEfective(this, this.monto);
            this.Visible = false;
            pago.Visible = true;
            
        }

        private void simpleButton3_Click(object sender, EventArgs e) {
            INTERFACE.SALE.frame_paymentCard pago = new frame_paymentCard(this, this.monto);
            this.Visible = false;
            pago.Visible = true;
            
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            INTERFACE.SALE.frame_paymentCripto pago = new frame_paymentCripto(this, this.monto);
            this.Visible = false;
            pago.Visible = true;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            INTERFACE.SALE.frame_partialPayment pago = new frame_partialPayment(this, this.monto);
            this.Visible = false;
            pago.Visible = true;

            
        }

        private void searchLookUpEdit_nit_EnabledChanged(object sender, EventArgs e) {
            this.button_generateCheck.Enabled = true;
        }

        private void button_cf_Click(object sender, EventArgs e) {
            searchLookUpEdit_nit.EditValue = 4;
        }

        private void simpleButton4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_generateCheck_Click(object sender, EventArgs e) {
            ControlDB.AddTransactionSale(Convert.ToInt32(searchLookUpEdit_nit.EditValue), CONTROLLER.GlobalVARS.id_employeed, Convert.ToDecimal(monto));
            int trans = ControlDB.getLastID_TRANSACTIONSALE();
            foreach (var n in CONTROLLER.GlobalVARS.gestorProductoEnlistado.listadoDeProductos) {
                ControlDB.AddTransactionDetail(n.ID_product, trans, n.quantity, Convert.ToDecimal(n.quantity * ControlDB.getPriceByID(n.ID_product)));
            }
            foreach (var n in CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.listadoDePago) {
                ControlDB.AddTransactionPaymentDetail(n.ID_payment, trans, Convert.ToDecimal(n.amount));
            }
            foreach(var n in CONTROLLER.GlobalVARS.gestorProductoEnlistado.listadoDeProductos) {
                ControlDB.decrementoDeProducto(n.quantity, n.ID_product);
            }
  
            CONTROLLER.GlobalVARS.RESTART_CYCLE();
            // GENERAR LA FACTURA
            ControlDB.generarFactura();
        }

        private void frame_datoClient_VisibleChanged(object sender, EventArgs e) {
            if (CONTROLLER.GlobalVARS.pagoRealizado) {
                this.searchLookUpEdit_nit.Enabled = true;
            }
        }
    }
}
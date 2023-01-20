using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.SALE {
    public partial class frame_paymentCard : DevExpress.XtraEditors.XtraForm {
        
        public double totalAPagar = 0;
        Form SuperForm;
        public frame_paymentCard(Form k, double monto) {
            InitializeComponent();
            this.label_montoAPagar.Text = Convert.ToString(monto);
            totalAPagar = monto;
            SuperForm = k;
        }

        private void frame_paymentCard_Load(object sender, EventArgs e) {
            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e) {
            
            CONTROLLER.GlobalVARS.cantidadPagada += Convert.ToDecimal(totalAPagar);
            if (CONTROLLER.GlobalVARS.cantidadPagada >= Convert.ToDecimal(CONTROLLER.GlobalVARS.gestorProductoEnlistado.total)) {

                CONTROLLER.GlobalVARS.pagoRealizado = true;
            }
            CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.ADD(3, this.totalAPagar);
            SuperForm.Visible = true;
            this.Close();
            
        }
    }
}
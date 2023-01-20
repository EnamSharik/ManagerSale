using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.SALE {
    public partial class frame_paymentCripto : DevExpress.XtraEditors.XtraForm {
        Form SuperForm;
        
        double monto = 0;
        public frame_paymentCripto(Form k, double pago) {
            InitializeComponent();
            this.label_totalAPagar.Text = Convert.ToString(pago);
            this.monto = pago; 
            SuperForm = k;
        }

        private void button_pagoEfectuado_Click(object sender, EventArgs e) {
            
            CONTROLLER.GlobalVARS.cantidadPagada += Convert.ToDecimal(monto);
            if (CONTROLLER.GlobalVARS.cantidadPagada >= Convert.ToDecimal(CONTROLLER.GlobalVARS.gestorProductoEnlistado.total)) {
                CONTROLLER.GlobalVARS.pagoRealizado = true;

            }
            CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.ADD(2, this.monto);
            SuperForm.Visible = true;
            this.Close();
        }

        private void imageSlider1_Click(object sender, EventArgs e) {

        }

        private void frame_paymentCripto_Load(object sender, EventArgs e) {

        }
    }
}
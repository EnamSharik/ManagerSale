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
    public partial class frame_paymentEfective : DevExpress.XtraEditors.XtraForm {
        double efectivoEntregadoVariable = 0;
        double totalAPagar;
        
        
        Form SuperForm;
        public frame_paymentEfective(Form k, double totalAPagar) {
            InitializeComponent();
            this.totalAPagar= totalAPagar;
            this.label_efective_totalVenta.Text = totalAPagar.ToString();
            this.label_efective_change.Text = "-1";
            SuperForm = k;
        }

        private void button_10_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 10;
            sinc();
        }

        private void sinc() {
            if (efectivoEntregadoVariable < totalAPagar) {
                this.label_efective_change.Text = "Insuficiente";
            } else {
                this.label_efective_change.Text = Convert.ToString(efectivoEntregadoVariable - totalAPagar);
            }
            
            this.label_efectivoEntregado.Text = Convert.ToString(efectivoEntregadoVariable);

        }

        private void button_100_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 100;
            sinc();
        }

        private void button_5_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 5;
            sinc();
        }

        private void button_50_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 50;
            sinc();
        }

        private void button_1_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 1;
            sinc();
        }

        private void button_20_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 20;
            sinc();
        }

        private void button_10C_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 0.10;
            sinc();
        }

        private void button_50C_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 0.50;
            sinc();
        }

        private void button_5C_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 0.05;
            sinc();
        }

        private void button_25C_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable += 0.25;
            sinc();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            efectivoEntregadoVariable = 0;
            sinc();
        }

        private void button_ready_Click(object sender, EventArgs e) {
            
            CONTROLLER.GlobalVARS.cantidadPagada += Convert.ToDecimal(efectivoEntregadoVariable);
            if(CONTROLLER.GlobalVARS.cantidadPagada >= Convert.ToDecimal(CONTROLLER.GlobalVARS.gestorProductoEnlistado.total)) {
                CONTROLLER.GlobalVARS.pagoRealizado = true;
            }
            SuperForm.Visible = true;
            CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.ADD(1, this.totalAPagar);
            this.Close();        
        }
    }
}
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
    public partial class frame_partialPayment : DevExpress.XtraEditors.XtraForm {
        double monto = 0;
        Form SuperForm;
        public bool pagoRealizado { set; get; } = false;
        public frame_partialPayment(Form k, double monto) {
            InitializeComponent();
            this.SuperForm = k;
            this.monto = monto;
        }


        private void button_efectivo_Click(object sender, EventArgs e) {
            if (Convert.ToDouble(this.label_total.Text) < Convert.ToDouble(this.entry_efectivo.Text)) {
                MessageBox.Show("Monto Invalido");

            } else {
                if (Convert.ToDouble(this.label_restante.Text) <= 0) {
                    MessageBox.Show("Pago efectuado, no es necesario otro cobro");
                    this.entry_efectivo.Text = string.Empty;
                    return;
                }
                if (Convert.ToDouble(this.label_restante.Text) < Convert.ToDouble(this.entry_efectivo.Text)) {
                    MessageBox.Show("Monto invalido");
                    this.entry_efectivo.Text = string.Empty;
                    return;
                }

                INTERFACE.SALE.frame_paymentEfective frame = new frame_paymentEfective(this, Convert.ToDouble(this.entry_efectivo.Text));
                this.Visible = false;
                frame.Visible = true;

                this.label_restante.Text = Convert.ToString(Convert.ToDouble(this.label_restante.Text) - Convert.ToDouble(this.entry_efectivo.Text));

                //FALTA AGREGAR EL METODO DE PAGO UTILIZADO A LA BD
                //CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.ADD(1, Convert.ToDouble(this.entry_efectivo.Text));
            }
            this.entry_efectivo.Text = string.Empty;
        }

        private void button_card_Click(object sender, EventArgs e) {
            if (Convert.ToDouble(this.label_total.Text) < Convert.ToDouble(this.entry_tarjeta.Text)) {
                MessageBox.Show("Monto Invalido");
                
            } else {
                if (Convert.ToDouble(this.label_restante.Text) <= 0) {
                    MessageBox.Show("Pago efectuado, no es necesario otro cobro");
                    this.entry_tarjeta.Text = string.Empty;
                    return;
                }
                if (Convert.ToDouble(this.label_restante.Text) < Convert.ToDouble(this.entry_tarjeta.Text)) {
                    MessageBox.Show("Monto Invalido");
                    this.entry_tarjeta.Text = string.Empty;
                    return;
                }
                INTERFACE.SALE.frame_paymentCard frame = new frame_paymentCard(this, Convert.ToDouble(this.entry_tarjeta.Text));
                this.Visible = false;
                frame.Visible = true;
                
                this.label_restante.Text = Convert.ToString(Convert.ToDouble(this.label_restante.Text) - Convert.ToDouble(this.entry_tarjeta.Text));
                //CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.ADD(3, Convert.ToDouble(this.entry_tarjeta.Text));
                //FALTA AGREGAR EL METODO DE PAGO UTILIZADO A LA BD

            }
            this.entry_tarjeta.Text = string.Empty;
        }

        private void button_cripto_Click(object sender, EventArgs e) {
            if (Convert.ToDouble(this.label_total.Text) < Convert.ToDouble(this.entry_cripto.Text)) {
                MessageBox.Show("Monto Invalido");
                
            } else {
                if (Convert.ToDouble(this.label_restante.Text) <= 0) {
                    MessageBox.Show("Pago efectuado, no es necesario otro cobro");
                    this.entry_efectivo.Text = string.Empty;
                    return;
                }
                if (Convert.ToDouble(this.label_restante.Text) < Convert.ToDouble(this.entry_cripto.Text)) {
                    MessageBox.Show("Monto Invalido");
                    this.entry_cripto.Text = string.Empty;
                    return;
                }

                INTERFACE.SALE.frame_paymentCripto frame = new frame_paymentCripto(this, Convert.ToDouble(this.entry_cripto.Text));
                this.Visible = false;
                frame.Visible = true;
                
                this.label_restante.Text = Convert.ToString(Convert.ToDouble(this.label_restante.Text) - Convert.ToDouble(this.entry_cripto.Text));
                //CONTROLLER.GlobalVARS.gestorDeMetodosDePagoEnlistados.ADD(3, Convert.ToDouble(this.entry_efectivo.Text));
                //FALTA AGREGAR EL METODO DE PAGO UTILIZADO A LA BD
            }
            this.entry_cripto.Text = string.Empty;
        }

        private void frame_partialPayment_Load(object sender, EventArgs e) {
            this.label_total.Text = Convert.ToString(this.monto);
            this.label_restante.Text = Convert.ToString(this.monto);
        }

        private void button_complete_Click(object sender, EventArgs e) {
            SuperForm.Visible = true;
            if(Convert.ToDouble(this.label_restante.Text) == 0) {
                this.pagoRealizado = true;
            }

        }
    }
}
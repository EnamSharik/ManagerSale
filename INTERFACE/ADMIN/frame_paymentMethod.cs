using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.ADMIN {
    public partial class frame_paymentMethod : DevExpress.XtraEditors.XtraForm {
        DATA_BASE.Controller dbCtrl = new DATA_BASE.Controller();
        int ID;
        public frame_paymentMethod() {
            InitializeComponent();
        }

        private void LoadTable() {
            this.entry_state.Properties.DataSource = dbCtrl.BooleanStates();

            if (this.Check_ShowDisable.Checked) {
                this.gridControl.DataSource = dbCtrl.PaymentMethodTable();
            } else {
                this.gridControl.DataSource = dbCtrl.EnablePaymentMethodTable();
            }
        }

        private void frame_paymentMethod_Load(object sender, EventArgs e) {
            
            DefaultState();
        }
    

        private void DefaultState() {
            this.entry_metodo.Text = string.Empty;
            this.entry_state.EditValue = 1;

            this.button_delete.Enabled = false;
            this.button_modify.Enabled = false;
            this.button_add.Enabled = true;


            LoadTable();
        }


        private void Check_ShowDisable_CheckedChanged_1(object sender, EventArgs e) {
            LoadTable();
        }

        private void frame_paymentMethod_Click(object sender, EventArgs e) {
            DefaultState();
        }

        private void button_add_Click(object sender, EventArgs e) {
            string name = this.entry_metodo.Text;
            
            dbCtrl.AddPaymentMethod(name);
            DefaultState();
        }

        private void button_modify_Click(object sender, EventArgs e) {
            string name = this.entry_metodo.Text;
            bool state = Convert.ToBoolean(this.entry_state.Text);

            dbCtrl.EditPaymentMethod(ID, name, state);
            DefaultState();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            dbCtrl.RemovePaymentMethod(ID);
            DefaultState();
        }

        private void gridControl_DoubleClick_1(object sender, EventArgs e) {
            this.entry_metodo.Text = Convert.ToString(gridView.GetFocusedRowCellValue("METHOD"));
            this.entry_state.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STATE"));

            this.ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID_PAYMENT"));

            this.button_add.Enabled = false;
            this.button_delete.Enabled = true;
            this.button_modify.Enabled = true;
        }
    }
}
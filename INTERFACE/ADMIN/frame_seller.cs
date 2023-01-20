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

namespace MANAGER_SALE.INTERFACE.ADMIN {
    public partial class frame_seller : DevExpress.XtraEditors.XtraForm {
        DATA_BASE.Controller dbCtrl = new DATA_BASE.Controller();
        int ID;
        public frame_seller() {
            InitializeComponent();
        }

        private void frame_seller_Load(object sender, EventArgs e) {

            DefaultState();
        }

        private void LoadTable() {
            this.entry_state.Properties.DataSource = dbCtrl.BooleanStates();
            this.lookup_super.Properties.DataSource = dbCtrl.BooleanStates();

            if (this.Check_ShowDisable.Checked) {
                this.gridControl.DataSource = dbCtrl.EmployeesTable();
            } else {
                this.gridControl.DataSource = dbCtrl.EnableEmployeeTable();
            }
        }

        private void DefaultState() {
            this.entry_user.Text = string.Empty;
            this.entry_password.Text = string.Empty;
            this.entry_state.EditValue = 1;
            this.lookup_super.EditValue = 1;

            this.button_delete.Enabled = false;
            this.button_modify.Enabled = false;
            this.button_add.Enabled = true;
            LoadTable();
        }

        private void Check_ShowDisable_CheckedChanged(object sender, EventArgs e) {
            LoadTable();
        }

        private void button_add_Click(object sender, EventArgs e) {
            string name = this.entry_user.Text;
            string nit = this.entry_password.Text;
            bool state = Convert.ToBoolean(this.entry_state.Text);
            dbCtrl.AddEmployees(name, nit, state);
            DefaultState();
        }

        private void button_modify_Click(object sender, EventArgs e) {
            string name = this.entry_user.Text;
            string nit = this.entry_password.Text;
            bool state = Convert.ToBoolean(this.entry_state.Text);

            dbCtrl.EditEmployees(ID, name, nit, state);
            DefaultState();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            dbCtrl.RemoveEmployees(ID);
            DefaultState();
        }

        private void gridControl_DoubleClick_1(object sender, EventArgs e) {
            this.entry_user.Text = Convert.ToString(gridView.GetFocusedRowCellValue("USER"));
            this.entry_password.Text = Convert.ToString(gridView.GetFocusedRowCellValue("PASSWORD"));
            this.entry_state.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STATE"));
            this.lookup_super.Text = Convert.ToString(gridView.GetFocusedRowCellValue("SUPERUSER"));
            this.ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID_EMPLOYEES"));

            this.button_add.Enabled = false;
            this.button_delete.Enabled = true;
            this.button_modify.Enabled = true;
        }

        private void frame_seller_Click(object sender, EventArgs e) {
            DefaultState();
        }
    }
}
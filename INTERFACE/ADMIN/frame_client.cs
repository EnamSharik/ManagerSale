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
    public partial class frame_client : DevExpress.XtraEditors.XtraForm {
        readonly DATA_BASE.Controller dbCtrl = new DATA_BASE.Controller();
        int ID;
        public frame_client() {
            InitializeComponent();
        }

        private void frame_client_Load(object sender, EventArgs e) {

            LoadTable();
        }

        private void LoadTable() {
            this.entry_state.Properties.DataSource = dbCtrl.BooleanStates();

            if (this.Check_ShowDisable.Checked) {
                this.gridControl.DataSource = dbCtrl.ClientTable();
            }else {
                this.gridControl.DataSource = dbCtrl.EnableClientTable();
            }
        }

        private void Check_ShowDisable_CheckedChanged(object sender, EventArgs e) {
            LoadTable();
        }

        private void button_add_Click(object sender, EventArgs e) {
            string name = this.entry_name.Text;
            string nit = this.entry_nit.Text;
            string tel = this.entry_phone.Text;
            dbCtrl.AddClient(name, nit, tel);            
            DefaultState();
        }

        private void DefaultState() {
            this.entry_name.Text = string.Empty;
            this.entry_nit.Text = string.Empty;
            this.entry_phone.Text = string.Empty;
            this.entry_state.EditValue = 1;

            this.button_delete.Enabled = false;
            this.button_modify.Enabled = false;
            this.button_add.Enabled = true;
            LoadTable();
        }

        private void button_modify_Click(object sender, EventArgs e) {
            string name = this.entry_name.Text;
            string nit = this.entry_nit.Text;
            string tel = this.entry_phone.Text;
            bool state = Convert.ToBoolean(this.entry_state.Text);

            dbCtrl.EditClient(ID, name, nit, tel, state);
            DefaultState();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            dbCtrl.RemoveClient(ID);
            DefaultState();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e) {
            this.entry_name.Text = Convert.ToString(gridView.GetFocusedRowCellValue("NAME"));
            this.entry_nit.Text = Convert.ToString(gridView.GetFocusedRowCellValue("NIT"));
            this.entry_phone.Text = Convert.ToString(gridView.GetFocusedRowCellValue("PHONE_NUMBER"));
            this.entry_state.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STATE"));

            this.ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID_CLIENT"));

            this.button_add.Enabled = false;
            this.button_delete.Enabled = true;
            this.button_modify.Enabled = true;

        }

        private void frame_client_Click(object sender, EventArgs e) {
            DefaultState();
        }
    }
}
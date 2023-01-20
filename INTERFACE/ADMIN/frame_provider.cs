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
    public partial class frame_provider : DevExpress.XtraEditors.XtraForm {
        readonly DATA_BASE.Controller dbCtrl = new DATA_BASE.Controller();
        int ID;
        public frame_provider() {
            InitializeComponent();
        }

        private void frame_provider_Load(object sender, EventArgs e) {
            
            DefaultState();

        }

        private void LoadTable() {
            this.entry_state.Properties.DataSource = dbCtrl.BooleanStates();

            if (this.Check_ShowDisable.Checked) {
                this.gridControl.DataSource = dbCtrl.ProviderTable();
            } else {
                this.gridControl.DataSource = dbCtrl.EnableProviderTable();
            }
        }


        private void DefaultState() {
            this.entry_company.Text = string.Empty;
            this.entry_representative.Text = string.Empty;
            this.entry_contact.Text = string.Empty;
            this.entry_state.EditValue = 1;

            this.button_delete.Enabled = false;
            this.button_modify.Enabled = false;
            this.button_add.Enabled = true;
            LoadTable();
        }

        private void gridControl_DoubleClick_1(object sender, EventArgs e) {
            this.entry_company.Text = Convert.ToString(gridView.GetFocusedRowCellValue("COMPANY"));
            this.entry_representative.Text = Convert.ToString(gridView.GetFocusedRowCellValue("REPRESENTATIVE"));
            this.entry_contact.Text = Convert.ToString(gridView.GetFocusedRowCellValue("CONTACT_INFORMATION"));
            this.entry_state.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STATE"));

            this.ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID_PROVIDER"));

            this.button_add.Enabled = false;
            this.button_delete.Enabled = true;
            this.button_modify.Enabled = true;
        }

        private void Check_ShowDisable_CheckedChanged_1(object sender, EventArgs e) {
            LoadTable();
        }

        private void button_add_Click(object sender, EventArgs e) {
            string company = this.entry_company.Text;
            string repre = this.entry_representative.Text;
            string contact = this.entry_contact.Text;
            dbCtrl.AddProvider(company, repre, contact);
            DefaultState();
        }

        private void button_modify_Click(object sender, EventArgs e) {
            string company = this.entry_company.Text;
            string repre = this.entry_representative.Text;
            string contact = this.entry_contact.Text;
            bool state = Convert.ToBoolean(this.entry_state.Text);

            dbCtrl.EditProvider(ID, company, repre, contact, state);
            DefaultState();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            dbCtrl.RemoveProvider(ID);
            DefaultState();
        }

        private void frame_provider_Click(object sender, EventArgs e) {
            DefaultState();
        }
    }
}
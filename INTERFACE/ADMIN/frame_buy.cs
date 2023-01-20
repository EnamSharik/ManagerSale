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
    public partial class frame_buy : DevExpress.XtraEditors.XtraForm {
        readonly DATA_BASE.Controller dbCtrl = new DATA_BASE.Controller();
        int ID;
        public frame_buy() {
            InitializeComponent();
        }

        private void frame_buy_Load(object sender, EventArgs e) {
            DefaultState();
        }
        private void LoadTable() {
            this.searchLookUpEdit_providers.Properties.DataSource = dbCtrl.EnableProviderLookUp();
            this.searchLookUpEdit_providers.Properties.ValueMember= "ID";
            this.searchLookUpEdit_providers.Properties.DisplayMember= "COMPANY";
            this.entry_state.Properties.DataSource = dbCtrl.BooleanStates();

            if (this.Check_ShowDisable.Checked) {
                this.gridControl.DataSource = dbCtrl.BuyTable();
                this.gridView.Columns["ID"].Visible=false;
            } else {
                this.gridControl.DataSource = dbCtrl.EnableBuyTable();
            }
        }
        private void Check_ShowDisable_CheckedChanged(object sender, EventArgs e) {
            LoadTable();
        }
        private void DefaultState() {
            this.searchLookUpEdit_providers.EditValue = 1;
            this.dateEdit.Text = string.Empty;
            this.entry_quantity.Text = string.Empty;
            this.entry_cost.Text = string.Empty;
            this.entry_state.EditValue = 1;

            this.button_delete.Enabled = false;
            this.button_modify.Enabled = false;
            this.button_add.Enabled = true;
            LoadTable();
        }
        private void button_add_Click(object sender, EventArgs e) {
            int id_provider = Convert.ToInt32(searchLookUpEdit_providers.EditValue);
            string exp = this.dateEdit.Text;
            string buyDate = DateTime.Now.ToShortDateString();
            int quantity = Convert.ToInt32(this.entry_quantity.Text);
            decimal cost = Convert.ToDecimal(this.entry_cost.Text);

            dbCtrl.AddBuy(id_provider, buyDate, exp,quantity,cost);
            
            CONTROLLER.GlobalVARS.ID_CURRENT_BUY = dbCtrl.getLastID_BUY();
            //AGREGAR EL PPRODUCTO FRAME
            INTERFACE.ADMIN.frame_product producto = new frame_product(cost,quantity);
            producto.Show();
            DefaultState();
        }

        private void button_modify_Click(object sender, EventArgs e) {
            int id_provider = Convert.ToInt32(searchLookUpEdit_providers.EditValue);
            string exp = this.dateEdit.Text;
            string buyDate = DateTime.Now.ToShortDateString();
            int quantity = Convert.ToInt32(this.entry_quantity.Text);
            decimal cost = Convert.ToDecimal(this.entry_cost.Text);

            dbCtrl.ModifyBuy(ID, id_provider, buyDate, exp, quantity, cost);
            DefaultState();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            dbCtrl.RemoveBuy(ID);
            DefaultState();
        }

        private void frame_buy_DoubleClick(object sender, EventArgs e) {
            
        }

        private void frame_buy_Click(object sender, EventArgs e) {
            DefaultState();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e) {
            this.searchLookUpEdit_providers.EditValue = dbCtrl.getIDProviderByCompany(Convert.ToString(gridView.GetFocusedRowCellValue("PROVIDER")));
            this.dateEdit.Text = Convert.ToString(gridView.GetFocusedRowCellValue("EXPIRATION"));
            this.entry_quantity.Text = Convert.ToString(gridView.GetFocusedRowCellValue("QUANTITY"));
            this.entry_cost.Text = Convert.ToString(gridView.GetFocusedRowCellValue("COST"));
            this.entry_state.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STATE"));

            this.ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));

            this.button_add.Enabled = false;
            this.button_delete.Enabled = true;
            this.button_modify.Enabled = true;
        }
    }
}
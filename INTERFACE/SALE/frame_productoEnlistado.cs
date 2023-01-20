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
    public partial class frame_productoEnlistado : DevExpress.XtraEditors.XtraForm {
        public CONTROLLER.ProductoToList gestorProductoEnlistado { get; set; } = new CONTROLLER.ProductoToList();
        readonly DATA_BASE.Controller CtrlDB = new DATA_BASE.Controller();
        
        public frame_productoEnlistado() {
            InitializeComponent();
            
        }

        public frame_productoEnlistado(CONTROLLER.ProductoToList gestor) {
            InitializeComponent();
            
            if(gestor != null) {
                this.gestorProductoEnlistado = gestor;
                ByDefault();
            }
            
            
        }

        private void frame_productoEnlistado_Load(object sender, EventArgs e) {
            
            this.searchLookUpEdit_searchProduct.Properties.DataSource = CtrlDB.EnableProductTable();
            this.searchLookUpEdit_searchProduct.Properties.ValueMember = "ID_PRODUCT";
            this.searchLookUpEdit_searchProduct.Properties.DisplayMember = "NAME";

            
        }

        private void ByDefault() {
            
            this.gridControl.DataSource = gestorProductoEnlistado.listadoDeProductos;
            this.gridView.UpdateSummary();
            this.entry_code.Text = string.Empty;
            this.label_total.Text = gestorProductoEnlistado.total.ToString();
            
            
        }
        
        private void button_add_Click(object sender, EventArgs e) {
            string id = this.searchLookUpEdit_searchProduct.Text;
            gestorProductoEnlistado.ADD(CtrlDB.getIDByName(id));
            ByDefault();

        }

        private void button_delete_Click(object sender, EventArgs e) {
            int id = Convert.ToInt32(this.gridView.GetFocusedRowCellValue("ID_product"));
            gestorProductoEnlistado.DELETE(id);
            ByDefault();
        }

        private void button_complete_Click(object sender, EventArgs e) {
            //var lista = this.gestorProductoEnlistado.listadoDeProductos;
            var monto = this.gestorProductoEnlistado.total;
            INTERFACE.SALE.frame_datoClient CLIT = new INTERFACE.SALE.frame_datoClient(monto);
            this.Visible = false;
            CLIT.Visible = true;

        }

        private void button_cancel_Click(object sender, EventArgs e) {
            this.gestorProductoEnlistado.listadoDeProductos.Clear();
            this.gestorProductoEnlistado.total = 0;
            this.label_total.Text = "0.00";
            this.gridControl.RefreshDataSource();
            this.Close();
        }
    }
}
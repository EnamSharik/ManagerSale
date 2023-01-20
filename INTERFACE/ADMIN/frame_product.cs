using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.ADMIN {
    public partial class frame_product : DevExpress.XtraEditors.XtraForm {
        DATA_BASE.Controller dbCtrl = new DATA_BASE.Controller();
        bool productoExistente = false;
        int cantidadProducto =0;
        decimal costo = 0;
        int ID;
        public frame_product(decimal cost, int quantity) {

            InitializeComponent();
            DefaultState();
            
            cantidadProducto = quantity;
            costo = cost;
        }
        public frame_product() {
            InitializeComponent();
        }
        private void LoadTable() {

            this.entry_state.Properties.DataSource = dbCtrl.BooleanStates();
            this.entry_state.EditValue = 1;


            if (this.Check_ShowDisable.Checked) {
                this.gridControl.DataSource = dbCtrl.ProductTable();
            } else {
                this.gridControl.DataSource = dbCtrl.EnableProductTable();
            }
        }

        private void DefaultState() {
            
            this.entry_name.Text = string.Empty;
            this.entry_description.Text = string.Empty;
            this.entry_cost.Text = string.Empty;
            this.entry_profitPercentage.Text = string.Empty;
            this.entry_salePrice.Text = string.Empty;
            this.entry_quantity.Text = string.Empty;
            this.entry_tradeMark.Text = string.Empty;
            this.entry_state.EditValue = 1;
            this.entry_code.Text = string.Empty;

            this.button_delete.Enabled = false;
            this.button_modify.Enabled = false;
            this.button_add.Enabled = true;
            

            LoadTable();
        }


        private void frame_product_Load(object sender, EventArgs e) {
            
            DefaultState();
            this.entry_cost.Text = Convert.ToString(costo);
            this.entry_quantity.Text = Convert.ToString(cantidadProducto);

        }

        private void entry_code_EditValueChanged(object sender, EventArgs e) {
            
            //this.barCodeControl.Text = entry_code.Text;
            
        }

        private void Check_ShowDisable_CheckedChanged(object sender, EventArgs e) {
            LoadTable();
        }

        private void frame_product_Click(object sender, EventArgs e) {
            DefaultState();
        }

        private void button_add_Click_1(object sender, EventArgs e) {
            string tradeMark = this.entry_tradeMark.Text;
            string code = this.entry_code.Text;
            string name = this.entry_name.Text;
            string description = this.entry_description.Text;
            decimal cost = Convert.ToDecimal(this.entry_cost.Text);
            decimal salePrice = Convert.ToDecimal(this.entry_salePrice.Text);
            int stock = Convert.ToInt32(this.entry_quantity.Text);
            dbCtrl.AddProduct(tradeMark, name, code, description, cost, salePrice, stock);
            if (productoExistente) {//el producto existe

            }else { //el producto no existe
                CONTROLLER.GlobalVARS.ID_CURRENT_PRODUCT = dbCtrl.getLastID_product();
                dbCtrl.AddBuyDetail(CONTROLLER.GlobalVARS.ID_CURRENT_BUY, CONTROLLER.GlobalVARS.ID_CURRENT_PRODUCT);
            }
            cantidadProducto = 0;
            costo = 0;
            DefaultState();
        }

        private void button_modify_Click(object sender, EventArgs e) {
            string tradeMark = this.entry_tradeMark.Text;
            string code = this.entry_code.Text;
            string name = this.entry_name.Text;
            string description = this.entry_description.Text;
            decimal cost = Convert.ToDecimal(this.entry_cost.Text);
            decimal salePrice = Convert.ToDecimal(this.entry_salePrice.Text);
            int stock = Convert.ToInt32(this.entry_quantity.Text);
            bool state = Convert.ToBoolean(this.entry_state.Text);
            dbCtrl.EditProduct(ID, tradeMark, name, code, description, cost, salePrice, stock, state);
            if (productoExistente) {//el producto existe
                CONTROLLER.GlobalVARS.ID_CURRENT_PRODUCT = this.ID;
                dbCtrl.AddBuyDetail(CONTROLLER.GlobalVARS.ID_CURRENT_BUY, CONTROLLER.GlobalVARS.ID_CURRENT_PRODUCT);
            } else { //el producto no existe
                
                
            }
            cantidadProducto = 0;
            costo = 0;
            DefaultState();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            dbCtrl.RemoveProduct(ID);
            DefaultState();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e) {
            
            
            this.entry_name.Text = Convert.ToString(gridView.GetFocusedRowCellValue("NAME"));
            this.entry_description.Text = Convert.ToString(gridView.GetFocusedRowCellValue("DESCRIPTION"));
            if(costo == 0) {
                this.entry_cost.Text = Convert.ToString(gridView.GetFocusedRowCellValue("PRICE_COST"));
            }else {
                decimal costoLocal = Convert.ToDecimal(gridView.GetFocusedRowCellValue("PRICE_COST"));
                this.entry_cost.Text = Convert.ToString((costo + costoLocal)/2);
            }
            
            this.entry_salePrice.Text = Convert.ToString(gridView.GetFocusedRowCellValue("PRICE_SALE"));
            if (cantidadProducto == 0) {
                this.entry_quantity.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STOCK"));
            } else {
                int local = Convert.ToInt32(gridView.GetFocusedRowCellValue("STOCK"));
                this.entry_quantity.Text = Convert.ToString(cantidadProducto+local);
            }
            this.entry_state.Text = Convert.ToString(gridView.GetFocusedRowCellValue("STATE"));
            this.ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
            this.entry_tradeMark.Text = Convert.ToString(gridView.GetFocusedRowCellValue("TRADEMARK"));
            this.entry_profitPercentage.Text = Convert.ToString(returnPorcentage(entry_salePrice.Text, entry_cost.Text));
            this.entry_code.Text = Convert.ToString(gridView.GetFocusedRowCellValue("CODE"));
            this.button_add.Enabled = false;
            this.button_delete.Enabled = true;
            this.button_modify.Enabled = true;
        }

        private void entry_name_EditValueChanged(object sender, EventArgs e) {
            string code = Convert.ToString(entry_tradeMark.Text)+"-"+ entry_name.Text;
            entry_code.Text = code;

            this.barCodeControl.Text = code;
        }

        private void entry_profitPercentage_EditValueChanged(object sender, EventArgs e) {
            if(this.entry_cost.Text == string.Empty && this.entry_code.Text != "-1" && this.entry_code.Text == string.Empty) {
                MessageBox.Show("El costo es un campo obligatorio");
            } else {
                if (this.entry_profitPercentage.Text == string.Empty) {
                    return;
                } else {
                    double costo = Convert.ToDouble(this.entry_cost.Text);
                    double porcentaje = Convert.ToDouble(this.entry_profitPercentage.Text) / 100;
                    double subtotal = (costo * porcentaje) + costo;
                    double iva = subtotal * 0.12;
                    double precioDeVenta = subtotal + iva;

                    this.entry_salePrice.Text = precioDeVenta.ToString();
                }
                
            }
        }

        private double returnPorcentage(string totalString, string costString) {
            double t = Convert.ToDouble(totalString);
            double c = Convert.ToDouble(costString);

            double porcentaje = 100 * (((t) / (1.12 * c)) - 1);

            return porcentaje;
        }
    }
}
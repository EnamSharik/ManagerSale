using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE.ADMIN {
    public partial class frameMain_admin : Form {
        private int childFormNumber = 0;
        Form super;

        public frameMain_admin(Form k) {
            InitializeComponent();
            this.super = k;
            
        }
        
        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_product_Click(object sender, EventArgs e) {
            frame_product pro = new frame_product();
            pro.MdiParent = this;
            pro.Show();

        }

        private void button_provider_Click(object sender, EventArgs e) {
            frame_provider prov = new frame_provider();
            prov.MdiParent = this;
            prov.Show();
        }

        private void button_client_Click(object sender, EventArgs e) {
            frame_client client = new frame_client(false);
            client.MdiParent = this;
            client.Show();
        }

        private void button_seller_Click(object sender, EventArgs e) {
            frame_seller seller = new frame_seller();
            seller.MdiParent = this;
            seller.Show();
        }

        private void button_paymenthMethod_Click(object sender, EventArgs e) {
            frame_paymentMethod pay = new frame_paymentMethod();
            pay.MdiParent = this;
            pay.Show();
        }

        private void button_report_Click(object sender, EventArgs e) {
            frame_report rep = new frame_report();
            rep.MdiParent = this;
            rep.Show();
        }

        private void button_closeSesion_Click(object sender, EventArgs e) {
            super.Visible = true;
            this.Close();
        }

        private void button_buy_Click(object sender, EventArgs e) {
            frame_buy buy = new frame_buy();
            buy.MdiParent = this;
            buy.Show();
        }
    }
}

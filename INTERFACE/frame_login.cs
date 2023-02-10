using DevExpress.XtraEditors;
using MANAGER_SALE.INTERFACE.ADMIN;
using MANAGER_SALE.INTERFACE.SALE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_SALE.INTERFACE {
    public partial class frame_login : DevExpress.XtraEditors.XtraForm {
        DATA_BASE.Controller dataBases = new DATA_BASE.Controller();
        
        string userActive = "";

        public frame_login() {
            InitializeComponent();
        }

        private void frame_login_Load(object sender, EventArgs e) {
            this.panel_login_pssw.Visible = false;
            this.button_login_init.Enabled = false;
            
        }
        private void button_login_validate_Click(object sender, EventArgs e) {
            
            if (dataBases.ValidateUser(entry_login_user.Text)) {
                this.panel_login_user.Visible = false;
                this.panel_login_pssw.Visible = true;

                this.userActive = entry_login_user.Text;
                this.entry_login_user.Text = string.Empty;
                this.button_login_init.Enabled = true;
                this.entry_login_password.Focus();

            } else {
                this.entry_login_user.Text = string.Empty;
                MessageBox.Show("WRONG USER :C");
            }

        }

        private void button_login_init_Click(object sender, EventArgs e) {
            if (dataBases.ValidatePSSW(this.userActive,entry_login_password.Text)) {
                this.panel_login_user.Visible = true;
                this.panel_login_pssw.Visible = false; 

                if (dataBases.isSuperUser(this.userActive)) {
                    
                    //frameMain_admin adm = new frameMain_admin(this);
                    this.Visible = false;
                    //adm.Show();
                    this.entry_login_password.Text = string.Empty;
                    frameMain_admin k = new frameMain_admin(this);
                    k.Show();
                } else {

                    frameMain_sale sale = new frameMain_sale(this, userActive);
                    CONTROLLER.GlobalVARS.id_employeed = dataBases.getIdByName_employee(userActive);
                    this.Visible = false;
                    sale.Show();
                    this.entry_login_password.Text = string.Empty;

                }

            } else {
                this.entry_login_password.Text = string.Empty;
                MessageBox.Show("WRONG PASSWORD :C");
                this.panel_login_user.Visible = true;
                this.panel_login_pssw.Visible = false;
            }
        }

    }
}
namespace MANAGER_SALE.INTERFACE.SALE {
    partial class frameMain_sale {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frameMain_sale));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.button_product = new DevExpress.XtraEditors.SimpleButton();
            this.button_client = new DevExpress.XtraEditors.SimpleButton();
            this.button_check = new DevExpress.XtraEditors.SimpleButton();
            this.button_closeSesion = new DevExpress.XtraEditors.SimpleButton();
            this.text_user = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip.Location = new System.Drawing.Point(0, 490);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(856, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(50, 19);
            this.label_status.Text = "Estado";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.MinimumSize = new System.Drawing.Size(0, 85);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(856, 85);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // button_product
            // 
            this.button_product.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.Appearance.Options.UseFont = true;
            this.button_product.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_product.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_product.ImageOptions.SvgImage")));
            this.button_product.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_product.Location = new System.Drawing.Point(9, 10);
            this.button_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(82, 65);
            this.button_product.TabIndex = 10;
            this.button_product.Text = "PRODUCTOS";
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_client
            // 
            this.button_client.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_client.Appearance.Options.UseFont = true;
            this.button_client.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_client.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_client.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_client.ImageOptions.SvgImage")));
            this.button_client.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_client.Location = new System.Drawing.Point(95, 10);
            this.button_client.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(74, 65);
            this.button_client.TabIndex = 11;
            this.button_client.Text = "DATOS DE\r\nCLIENTE";
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // button_check
            // 
            this.button_check.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Appearance.Options.UseFont = true;
            this.button_check.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_check.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_check.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_check.ImageOptions.SvgImage")));
            this.button_check.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_check.Location = new System.Drawing.Point(173, 10);
            this.button_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(73, 65);
            this.button_check.TabIndex = 12;
            this.button_check.Text = "GENERAR\r\nFACTURA";
            // 
            // button_closeSesion
            // 
            this.button_closeSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_closeSesion.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_closeSesion.Appearance.Options.UseFont = true;
            this.button_closeSesion.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_closeSesion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_closeSesion.ImageOptions.Image")));
            this.button_closeSesion.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_closeSesion.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_closeSesion.Location = new System.Drawing.Point(777, 10);
            this.button_closeSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_closeSesion.Name = "button_closeSesion";
            this.button_closeSesion.Size = new System.Drawing.Size(70, 65);
            this.button_closeSesion.TabIndex = 18;
            this.button_closeSesion.Text = "CERRAR \r\nSESIÓN";
            this.button_closeSesion.Click += new System.EventHandler(this.button_closeSesion_Click);
            // 
            // text_user
            // 
            this.text_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_user.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user.Appearance.Options.UseFont = true;
            this.text_user.Location = new System.Drawing.Point(350, 10);
            this.text_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(140, 22);
            this.text_user.TabIndex = 20;
            this.text_user.Text = "BRANDON LOPEZ";
            // 
            // frameMain_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 514);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.button_closeSesion);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_client);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Name = "frameMain_sale";
            this.Text = "SALE";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel label_status;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private DevExpress.XtraEditors.SimpleButton button_product;
        private DevExpress.XtraEditors.SimpleButton button_client;
        private DevExpress.XtraEditors.SimpleButton button_check;
        private DevExpress.XtraEditors.SimpleButton button_closeSesion;
        private DevExpress.XtraEditors.LabelControl text_user;
    }
}




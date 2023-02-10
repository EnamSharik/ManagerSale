namespace MANAGER_SALE.INTERFACE.ADMIN {
    partial class frameMain_admin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frameMain_admin));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textLabel_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip();
            this.button_product = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.button_provider = new DevExpress.XtraEditors.SimpleButton();
            this.button_client = new DevExpress.XtraEditors.SimpleButton();
            this.button_seller = new DevExpress.XtraEditors.SimpleButton();
            this.button_paymenthMethod = new DevExpress.XtraEditors.SimpleButton();
            this.button_report = new DevExpress.XtraEditors.SimpleButton();
            this.button_closeSesion = new DevExpress.XtraEditors.SimpleButton();
            this.button_buy = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textLabel_state});
            this.statusStrip.Location = new System.Drawing.Point(0, 574);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(973, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // textLabel_state
            // 
            this.textLabel_state.Name = "textLabel_state";
            this.textLabel_state.Size = new System.Drawing.Size(44, 19);
            this.textLabel_state.Text = "STATE";
            // 
            // button_product
            // 
            this.button_product.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.Appearance.Options.UseFont = true;
            this.button_product.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_product.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_product.ImageOptions.SvgImage")));
            this.button_product.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_product.Location = new System.Drawing.Point(10, 10);
            this.button_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(80, 65);
            this.button_product.TabIndex = 9;
            this.button_product.Text = "PRODUCTO";
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowDrop = true;
            this.toolStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.MinimumSize = new System.Drawing.Size(0, 85);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(973, 85);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "ToolStrip";
            // 
            // button_provider
            // 
            this.button_provider.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_provider.Appearance.Options.UseFont = true;
            this.button_provider.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_provider.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_provider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_provider.ImageOptions.SvgImage")));
            this.button_provider.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_provider.Location = new System.Drawing.Point(94, 10);
            this.button_provider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_provider.Name = "button_provider";
            this.button_provider.Size = new System.Drawing.Size(109, 65);
            this.button_provider.TabIndex = 12;
            this.button_provider.Text = "PROVEEDORES";
            this.button_provider.Click += new System.EventHandler(this.button_provider_Click);
            // 
            // button_client
            // 
            this.button_client.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_client.Appearance.Options.UseFont = true;
            this.button_client.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_client.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_client.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_client.ImageOptions.SvgImage")));
            this.button_client.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_client.Location = new System.Drawing.Point(207, 10);
            this.button_client.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(70, 65);
            this.button_client.TabIndex = 13;
            this.button_client.Text = "CLIENTES";
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // button_seller
            // 
            this.button_seller.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.Appearance.Options.UseFont = true;
            this.button_seller.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_seller.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_seller.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_seller.ImageOptions.SvgImage")));
            this.button_seller.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_seller.Location = new System.Drawing.Point(281, 10);
            this.button_seller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(98, 65);
            this.button_seller.TabIndex = 16;
            this.button_seller.Text = "VENDEDORES";
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // button_paymenthMethod
            // 
            this.button_paymenthMethod.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_paymenthMethod.Appearance.Options.UseFont = true;
            this.button_paymenthMethod.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_paymenthMethod.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_paymenthMethod.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_paymenthMethod.ImageOptions.SvgImage")));
            this.button_paymenthMethod.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_paymenthMethod.Location = new System.Drawing.Point(383, 11);
            this.button_paymenthMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_paymenthMethod.Name = "button_paymenthMethod";
            this.button_paymenthMethod.Size = new System.Drawing.Size(77, 65);
            this.button_paymenthMethod.TabIndex = 14;
            this.button_paymenthMethod.Text = "METODOS \r\nDE PAGO";
            this.button_paymenthMethod.Click += new System.EventHandler(this.button_paymenthMethod_Click);
            // 
            // button_report
            // 
            this.button_report.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_report.Appearance.Options.UseFont = true;
            this.button_report.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_report.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_report.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_report.ImageOptions.SvgImage")));
            this.button_report.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_report.Location = new System.Drawing.Point(538, 10);
            this.button_report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(77, 65);
            this.button_report.TabIndex = 15;
            this.button_report.Text = "REPORTES";
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
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
            this.button_closeSesion.Location = new System.Drawing.Point(893, 10);
            this.button_closeSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_closeSesion.Name = "button_closeSesion";
            this.button_closeSesion.Size = new System.Drawing.Size(70, 65);
            this.button_closeSesion.TabIndex = 17;
            this.button_closeSesion.Text = "CERRAR \r\nSESIÓN";
            this.button_closeSesion.Click += new System.EventHandler(this.button_closeSesion_Click);
            // 
            // button_buy
            // 
            this.button_buy.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buy.Appearance.Options.UseFont = true;
            this.button_buy.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_buy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_buy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_buy.ImageOptions.SvgImage")));
            this.button_buy.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_buy.Location = new System.Drawing.Point(464, 11);
            this.button_buy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(70, 65);
            this.button_buy.TabIndex = 19;
            this.button_buy.Text = "COMPRAS";
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // frameMain_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 598);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.button_closeSesion);
            this.Controls.Add(this.button_provider);
            this.Controls.Add(this.button_client);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.button_paymenthMethod);
            this.Controls.Add(this.button_report);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "frameMain_admin";
            this.Text = "ADMINISTRADOR";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textLabel_state;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraEditors.SimpleButton button_product;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraEditors.SimpleButton button_provider;
        private DevExpress.XtraEditors.SimpleButton button_client;
        private DevExpress.XtraEditors.SimpleButton button_seller;
        private DevExpress.XtraEditors.SimpleButton button_paymenthMethod;
        private DevExpress.XtraEditors.SimpleButton button_report;
        private DevExpress.XtraEditors.SimpleButton button_closeSesion;
        private DevExpress.XtraEditors.SimpleButton button_buy;
    }
}




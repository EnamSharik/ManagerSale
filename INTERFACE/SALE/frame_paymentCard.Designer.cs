namespace MANAGER_SALE.INTERFACE.SALE {
    partial class frame_paymentCard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_paymentCard));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label_montoAPagar = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(304, 324);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(220, 74);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "PAGO EFECTUADO";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(369, 155);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 24);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Q";
            // 
            // label_montoAPagar
            // 
            this.label_montoAPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_montoAPagar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_montoAPagar.Appearance.Options.UseFont = true;
            this.label_montoAPagar.Location = new System.Drawing.Point(429, 155);
            this.label_montoAPagar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label_montoAPagar.Name = "label_montoAPagar";
            this.label_montoAPagar.Size = new System.Drawing.Size(39, 24);
            this.label_montoAPagar.TabIndex = 12;
            this.label_montoAPagar.Text = "0.00";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(255, 237);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(288, 24);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "ACERQUE SU TARJETA AL POS...\r\n";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(245, 117);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(141, 24);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "MONTO TOTAL:";
            // 
            // frame_paymentCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 515);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label_montoAPagar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Name = "frame_paymentCard";
            this.Text = "frame_paymentCard";
            this.Load += new System.EventHandler(this.frame_paymentCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl label_montoAPagar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
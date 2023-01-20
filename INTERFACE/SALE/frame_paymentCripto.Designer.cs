namespace MANAGER_SALE.INTERFACE.SALE {
    partial class frame_paymentCripto {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_paymentCripto));
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label_totalAPagar = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.button_pagoEfectuado = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(514, 81);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(379, 349);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.Click += new System.EventHandler(this.imageSlider1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Location = new System.Drawing.Point(157, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Debe Cancelar:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Location = new System.Drawing.Point(260, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Q";
            // 
            // label_totalAPagar
            // 
            this.label_totalAPagar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_totalAPagar.Location = new System.Drawing.Point(280, 97);
            this.label_totalAPagar.Name = "label_totalAPagar";
            this.label_totalAPagar.Size = new System.Drawing.Size(39, 24);
            this.label_totalAPagar.TabIndex = 3;
            this.label_totalAPagar.Text = "0.00";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl3.Location = new System.Drawing.Point(50, 228);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(438, 72);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Acerque su telefono y escanee el codigo\r\nQR a continuación por medio de su wallet" +
    " digital.\r\nEl pago será debitado directamente de su wallet";
            // 
            // button_pagoEfectuado
            // 
            this.button_pagoEfectuado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_pagoEfectuado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_pagoEfectuado.ImageOptions.SvgImage")));
            this.button_pagoEfectuado.Location = new System.Drawing.Point(147, 386);
            this.button_pagoEfectuado.Name = "button_pagoEfectuado";
            this.button_pagoEfectuado.Size = new System.Drawing.Size(243, 61);
            this.button_pagoEfectuado.TabIndex = 5;
            this.button_pagoEfectuado.Text = "PAGO EFECTUADO";
            this.button_pagoEfectuado.Click += new System.EventHandler(this.button_pagoEfectuado_Click);
            // 
            // frame_paymentCripto
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 520);
            this.Controls.Add(this.button_pagoEfectuado);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label_totalAPagar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.imageSlider1);
            this.Name = "frame_paymentCripto";
            this.Text = "frame_paymentCripto";
            this.Load += new System.EventHandler(this.frame_paymentCripto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl label_totalAPagar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton button_pagoEfectuado;
    }
}
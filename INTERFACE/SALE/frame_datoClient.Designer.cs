namespace MANAGER_SALE.INTERFACE.SALE {
    partial class frame_datoClient {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_datoClient));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit_metodosAlternativos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button_generateCheck = new DevExpress.XtraEditors.SimpleButton();
            this.button_cf = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.button_efective = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_metodosAlternativos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(299, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(222, 30);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "DATOS DE CLIENTE";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(463, 102);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(326, 22);
            this.labelControl13.TabIndex = 8;
            this.labelControl13.Text = "METODOS DE PAGO ALTERNATIVOS:";
            // 
            // searchLookUpEdit_metodosAlternativos
            // 
            this.searchLookUpEdit_metodosAlternativos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLookUpEdit_metodosAlternativos.Location = new System.Drawing.Point(535, 157);
            this.searchLookUpEdit_metodosAlternativos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchLookUpEdit_metodosAlternativos.Name = "searchLookUpEdit_metodosAlternativos";
            this.searchLookUpEdit_metodosAlternativos.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit_metodosAlternativos.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit_metodosAlternativos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit_metodosAlternativos.Properties.PopupView = this.gridView1;
            this.searchLookUpEdit_metodosAlternativos.Size = new System.Drawing.Size(195, 28);
            this.searchLookUpEdit_metodosAlternativos.TabIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // button_generateCheck
            // 
            this.button_generateCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_generateCheck.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generateCheck.Appearance.Options.UseFont = true;
            this.button_generateCheck.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_generateCheck.ImageOptions.SvgImage")));
            this.button_generateCheck.Location = new System.Drawing.Point(463, 221);
            this.button_generateCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_generateCheck.Name = "button_generateCheck";
            this.button_generateCheck.Size = new System.Drawing.Size(326, 86);
            this.button_generateCheck.TabIndex = 8;
            this.button_generateCheck.Text = "GENERAR FACTURA";
            this.button_generateCheck.Click += new System.EventHandler(this.button_generateCheck_Click);
            // 
            // button_cf
            // 
            this.button_cf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_cf.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cf.Appearance.Options.UseFont = true;
            this.button_cf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_cf.ImageOptions.SvgImage")));
            this.button_cf.Location = new System.Drawing.Point(15, 260);
            this.button_cf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cf.Name = "button_cf";
            this.button_cf.Size = new System.Drawing.Size(212, 48);
            this.button_cf.TabIndex = 7;
            this.button_cf.Text = "CF";
            this.button_cf.Click += new System.EventHandler(this.button_cf_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(15, 221);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(34, 22);
            this.labelControl11.TabIndex = 6;
            this.labelControl11.Text = "NIT:";
            // 
            // searchLookUpEdit_nit
            // 
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Location = new System.Drawing.Point(66, 218);
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Name = "searchLookUpEdit_nit";
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Properties.Appearance.Options.UseFont = true;
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Properties.PopupView = this.searchLookUpEdit1View;
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Size = new System.Drawing.Size(379, 28);
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.TabIndex = 0;
            CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.EnabledChanged += new System.EventHandler(this.searchLookUpEdit_nit_EnabledChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.DetailHeight = 284;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(233, 149);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(212, 43);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "MULTIPLE\r\nMETODO";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(233, 102);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(212, 43);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "CRIPTOMONEDAS";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(15, 150);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(212, 43);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "TARJETA";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // button_efective
            // 
            this.button_efective.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_efective.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_efective.Appearance.Options.UseFont = true;
            this.button_efective.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_efective.ImageOptions.SvgImage")));
            this.button_efective.Location = new System.Drawing.Point(15, 102);
            this.button_efective.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_efective.Name = "button_efective";
            this.button_efective.Size = new System.Drawing.Size(212, 43);
            this.button_efective.TabIndex = 12;
            this.button_efective.Text = "EFECTIVO";
            this.button_efective.Click += new System.EventHandler(this.button_efective_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(690, 11);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(100, 38);
            this.simpleButton4.TabIndex = 13;
            this.simpleButton4.Text = "CANCEL";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(233, 260);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(212, 48);
            this.simpleButton5.TabIndex = 14;
            this.simpleButton5.Text = "Crear Cliente";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // frame_datoClient
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 318);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.button_efective);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.button_cf);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.searchLookUpEdit_metodosAlternativos);
            this.Controls.Add(this.button_generateCheck);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(803, 355);
            this.Name = "frame_datoClient";
            this.Text = "DATOS DE CLIENTE";
            this.Load += new System.EventHandler(this.frame_datoClient_Load);
            this.VisibleChanged += new System.EventHandler(this.frame_datoClient_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_metodosAlternativos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(CONTROLLER.GlobalVARS.searchLookUpEdit_nitGlobal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton button_generateCheck;
        private DevExpress.XtraEditors.SimpleButton button_cf;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit_metodosAlternativos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton button_efective;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}
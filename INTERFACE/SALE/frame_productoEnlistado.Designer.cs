namespace MANAGER_SALE.INTERFACE.SALE {
    partial class frame_productoEnlistado {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_productoEnlistado));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchLookUpEdit_searchProduct = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit_viewEdit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.entry_code = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label_total = new DevExpress.XtraEditors.LabelControl();
            this.button_delete = new DevExpress.XtraEditors.SimpleButton();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.button_complete = new DevExpress.XtraEditors.SimpleButton();
            this.button_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_searchProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_viewEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_code.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl.Location = new System.Drawing.Point(359, 16);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(556, 415);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.DetailHeight = 284;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // searchLookUpEdit_searchProduct
            // 
            this.searchLookUpEdit_searchProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchLookUpEdit_searchProduct.EditValue = "";
            this.searchLookUpEdit_searchProduct.Location = new System.Drawing.Point(11, 163);
            this.searchLookUpEdit_searchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchLookUpEdit_searchProduct.Name = "searchLookUpEdit_searchProduct";
            this.searchLookUpEdit_searchProduct.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit_searchProduct.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit_searchProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit_searchProduct.Properties.DisplayMember = "NAME";
            this.searchLookUpEdit_searchProduct.Properties.PopupView = this.searchLookUpEdit_viewEdit;
            this.searchLookUpEdit_searchProduct.Properties.ValueMember = "ID_PRODUCT";
            this.searchLookUpEdit_searchProduct.Size = new System.Drawing.Size(342, 28);
            this.searchLookUpEdit_searchProduct.TabIndex = 1;
            // 
            // searchLookUpEdit_viewEdit
            // 
            this.searchLookUpEdit_viewEdit.DetailHeight = 284;
            this.searchLookUpEdit_viewEdit.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit_viewEdit.Name = "searchLookUpEdit_viewEdit";
            this.searchLookUpEdit_viewEdit.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit_viewEdit.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 86);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(263, 30);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ENLISTAR PRODUCTOS";
            // 
            // entry_code
            // 
            this.entry_code.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.entry_code.Location = new System.Drawing.Point(107, 131);
            this.entry_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entry_code.Name = "entry_code";
            this.entry_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_code.Properties.Appearance.Options.UseFont = true;
            this.entry_code.Size = new System.Drawing.Size(246, 28);
            this.entry_code.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 134);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 22);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "CODIGO";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(738, 435);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "TOTAL =  Q";
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Appearance.Options.UseFont = true;
            this.label_total.Location = new System.Drawing.Point(852, 435);
            this.label_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(35, 22);
            this.label_total.TabIndex = 6;
            this.label_total.Text = "0.00";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_delete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_delete.ImageOptions.SvgImage")));
            this.button_delete.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_delete.Location = new System.Drawing.Point(185, 195);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(168, 65);
            this.button_delete.TabIndex = 56;
            this.button_delete.Text = "DELETE";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_add.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_add.ImageOptions.SvgImage")));
            this.button_add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_add.Location = new System.Drawing.Point(12, 195);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(169, 65);
            this.button_add.TabIndex = 54;
            this.button_add.Text = "AGREGAR";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_complete
            // 
            this.button_complete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_complete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_complete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_complete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_complete.ImageOptions.SvgImage")));
            this.button_complete.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_complete.Location = new System.Drawing.Point(12, 264);
            this.button_complete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_complete.Name = "button_complete";
            this.button_complete.Size = new System.Drawing.Size(273, 65);
            this.button_complete.TabIndex = 57;
            this.button_complete.Text = "COMPLETADO";
            this.button_complete.Click += new System.EventHandler(this.button_complete_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_cancel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_cancel.ImageOptions.SvgImage")));
            this.button_cancel.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_cancel.Location = new System.Drawing.Point(299, 264);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.button_cancel.Size = new System.Drawing.Size(54, 65);
            this.button_cancel.TabIndex = 58;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // frame_productoEnlistado
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 465);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_complete);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.entry_code);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.searchLookUpEdit_searchProduct);
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frame_productoEnlistado";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.frame_productoEnlistado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_searchProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_viewEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_code.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit_searchProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit_viewEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit entry_code;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl label_total;
        private DevExpress.XtraEditors.SimpleButton button_delete;
        private DevExpress.XtraEditors.SimpleButton button_add;
        private DevExpress.XtraEditors.SimpleButton button_complete;
        private DevExpress.XtraEditors.SimpleButton button_cancel;
    }
}
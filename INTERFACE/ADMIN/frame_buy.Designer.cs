namespace MANAGER_SALE.INTERFACE.ADMIN {
    partial class frame_buy {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_buy));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit_providers = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.entry_quantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.entry_cost = new DevExpress.XtraEditors.TextEdit();
            this.entry_state = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Check_ShowDisable = new DevExpress.XtraEditors.CheckEdit();
            this.button_modify = new DevExpress.XtraEditors.SimpleButton();
            this.button_delete = new DevExpress.XtraEditors.SimpleButton();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_providers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_cost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl.Location = new System.Drawing.Point(7, 7);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(692, 557);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // gridView
            // 
            this.gridView.DetailHeight = 190;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(801, 101);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "COMPRAS";
            // 
            // searchLookUpEdit_providers
            // 
            this.searchLookUpEdit_providers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLookUpEdit_providers.Location = new System.Drawing.Point(837, 145);
            this.searchLookUpEdit_providers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchLookUpEdit_providers.Name = "searchLookUpEdit_providers";
            this.searchLookUpEdit_providers.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEdit_providers.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit_providers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit_providers.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit_providers.Size = new System.Drawing.Size(186, 28);
            this.searchLookUpEdit_providers.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.DetailHeight = 190;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(703, 148);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "PROVEEDOR:";
            // 
            // dateEdit
            // 
            this.dateEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(837, 177);
            this.dateEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit.Properties.Appearance.Options.UseFont = true;
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(186, 28);
            this.dateEdit.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(703, 180);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "EXPIRA:";
            // 
            // entry_quantity
            // 
            this.entry_quantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_quantity.Location = new System.Drawing.Point(837, 209);
            this.entry_quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entry_quantity.Name = "entry_quantity";
            this.entry_quantity.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_quantity.Properties.Appearance.Options.UseFont = true;
            this.entry_quantity.Size = new System.Drawing.Size(186, 28);
            this.entry_quantity.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(703, 212);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 22);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "CANTIDAD:";
            // 
            // entry_cost
            // 
            this.entry_cost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_cost.Location = new System.Drawing.Point(837, 241);
            this.entry_cost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entry_cost.Name = "entry_cost";
            this.entry_cost.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_cost.Properties.Appearance.Options.UseFont = true;
            this.entry_cost.Size = new System.Drawing.Size(186, 28);
            this.entry_cost.TabIndex = 8;
            // 
            // entry_state
            // 
            this.entry_state.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_state.Location = new System.Drawing.Point(837, 273);
            this.entry_state.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entry_state.Name = "entry_state";
            this.entry_state.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_state.Properties.Appearance.Options.UseFont = true;
            this.entry_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.entry_state.Size = new System.Drawing.Size(186, 28);
            this.entry_state.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(703, 244);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 22);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "COSTO:";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(703, 276);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 22);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "STATE:";
            // 
            // Check_ShowDisable
            // 
            this.Check_ShowDisable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Check_ShowDisable.Location = new System.Drawing.Point(785, 314);
            this.Check_ShowDisable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_ShowDisable.Name = "Check_ShowDisable";
            this.Check_ShowDisable.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_ShowDisable.Properties.Appearance.Options.UseFont = true;
            this.Check_ShowDisable.Properties.Caption = "Mostrar Ocultos";
            this.Check_ShowDisable.Size = new System.Drawing.Size(151, 26);
            this.Check_ShowDisable.TabIndex = 26;
            this.Check_ShowDisable.CheckedChanged += new System.EventHandler(this.Check_ShowDisable_CheckedChanged);
            // 
            // button_modify
            // 
            this.button_modify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_modify.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify.Appearance.Options.UseFont = true;
            this.button_modify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_modify.ImageOptions.Image")));
            this.button_modify.Location = new System.Drawing.Point(703, 390);
            this.button_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(320, 37);
            this.button_modify.TabIndex = 25;
            this.button_modify.Text = "MODIFICAR";
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Appearance.Options.UseFont = true;
            this.button_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.ImageOptions.Image")));
            this.button_delete.Location = new System.Drawing.Point(703, 432);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(320, 37);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = "DELETE";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_add.ImageOptions.Image")));
            this.button_add.Location = new System.Drawing.Point(704, 354);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(319, 32);
            this.button_add.TabIndex = 23;
            this.button_add.Text = "CREAR";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // frame_buy
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.Check_ShowDisable);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.entry_state);
            this.Controls.Add(this.entry_cost);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.entry_quantity);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.searchLookUpEdit_providers);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frame_buy";
            this.Text = "BUY";
            this.Load += new System.EventHandler(this.frame_buy_Load);
            this.Click += new System.EventHandler(this.frame_buy_Click);
            this.DoubleClick += new System.EventHandler(this.frame_buy_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit_providers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_cost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit_providers;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit entry_quantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit entry_cost;
        private DevExpress.XtraEditors.LookUpEdit entry_state;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit Check_ShowDisable;
        private DevExpress.XtraEditors.SimpleButton button_modify;
        private DevExpress.XtraEditors.SimpleButton button_delete;
        private DevExpress.XtraEditors.SimpleButton button_add;
    }
}
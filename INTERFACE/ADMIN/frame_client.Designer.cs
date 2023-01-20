namespace MANAGER_SALE.INTERFACE.ADMIN {
    partial class frame_client {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_client));
            this.button_modify = new DevExpress.XtraEditors.SimpleButton();
            this.button_delete = new DevExpress.XtraEditors.SimpleButton();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.entry_nit = new DevExpress.XtraEditors.TextEdit();
            this.entry_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.entry_phone = new DevExpress.XtraEditors.TextEdit();
            this.Check_ShowDisable = new DevExpress.XtraEditors.CheckEdit();
            this.entry_state = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_nit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modify
            // 
            this.button_modify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_modify.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify.Appearance.Options.UseFont = true;
            this.button_modify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_modify.ImageOptions.Image")));
            this.button_modify.Location = new System.Drawing.Point(1117, 588);
            this.button_modify.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(556, 69);
            this.button_modify.TabIndex = 17;
            this.button_modify.Text = "MODIFICAR";
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Appearance.Options.UseFont = true;
            this.button_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.ImageOptions.Image")));
            this.button_delete.Location = new System.Drawing.Point(1117, 666);
            this.button_delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(556, 69);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "DELETE";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_add.ImageOptions.Image")));
            this.button_add.Location = new System.Drawing.Point(1117, 510);
            this.button_add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(556, 69);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "CREAR";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // entry_nit
            // 
            this.entry_nit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_nit.Location = new System.Drawing.Point(1329, 232);
            this.entry_nit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_nit.Name = "entry_nit";
            this.entry_nit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_nit.Properties.Appearance.Options.UseFont = true;
            this.entry_nit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_nit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.entry_nit.Properties.MaskSettings.Set("mask", "########-#");
            this.entry_nit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.entry_nit.Size = new System.Drawing.Size(344, 30);
            this.entry_nit.TabIndex = 14;
            // 
            // entry_name
            // 
            this.entry_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_name.Location = new System.Drawing.Point(1329, 162);
            this.entry_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_name.Name = "entry_name";
            this.entry_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_name.Properties.Appearance.Options.UseFont = true;
            this.entry_name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_name.Size = new System.Drawing.Size(344, 30);
            this.entry_name.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1117, 237);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 24);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "NIT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1117, 166);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 24);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "NOMBRE:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(1342, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 35);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "CLIENTES";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.DataSource = this.cLIENTBindingSource1;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl.Location = new System.Drawing.Point(27, 21);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1064, 714);
            this.gridControl.TabIndex = 9;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // gridView
            // 
            this.gridView.DetailHeight = 525;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1117, 380);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 24);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "ESTADO:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1117, 310);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(117, 24);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "TELEFONO: ";
            // 
            // entry_phone
            // 
            this.entry_phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_phone.Location = new System.Drawing.Point(1329, 306);
            this.entry_phone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_phone.Name = "entry_phone";
            this.entry_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_phone.Properties.Appearance.Options.UseFont = true;
            this.entry_phone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_phone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.entry_phone.Properties.MaskSettings.Set("mask", "(###)####-####");
            this.entry_phone.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.entry_phone.Size = new System.Drawing.Size(344, 30);
            this.entry_phone.TabIndex = 21;
            // 
            // Check_ShowDisable
            // 
            this.Check_ShowDisable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Check_ShowDisable.Location = new System.Drawing.Point(1262, 444);
            this.Check_ShowDisable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Check_ShowDisable.Name = "Check_ShowDisable";
            this.Check_ShowDisable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_ShowDisable.Properties.Appearance.Options.UseFont = true;
            this.Check_ShowDisable.Properties.Caption = "Mostrar Ocultos";
            this.Check_ShowDisable.Size = new System.Drawing.Size(264, 28);
            this.Check_ShowDisable.TabIndex = 22;
            this.Check_ShowDisable.CheckedChanged += new System.EventHandler(this.Check_ShowDisable_CheckedChanged);
            // 
            // entry_state
            // 
            this.entry_state.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_state.Location = new System.Drawing.Point(1329, 375);
            this.entry_state.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_state.Name = "entry_state";
            this.entry_state.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_state.Properties.Appearance.Options.UseFont = true;
            this.entry_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.entry_state.Size = new System.Drawing.Size(344, 30);
            this.entry_state.TabIndex = 23;
            // 
            // frame_client
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 756);
            this.Controls.Add(this.entry_state);
            this.Controls.Add(this.Check_ShowDisable);
            this.Controls.Add(this.entry_phone);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.entry_nit);
            this.Controls.Add(this.entry_name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frame_client";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.frame_client_Load);
            this.Click += new System.EventHandler(this.frame_client_Click);
            ((System.ComponentModel.ISupportInitialize)(this.entry_nit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton button_modify;
        private DevExpress.XtraEditors.SimpleButton button_delete;
        private DevExpress.XtraEditors.SimpleButton button_add;
        private DevExpress.XtraEditors.TextEdit entry_nit;
        private DevExpress.XtraEditors.TextEdit entry_name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit entry_phone;
        private DevExpress.XtraEditors.CheckEdit Check_ShowDisable;
        private DevExpress.XtraEditors.LookUpEdit entry_state;
        //private POINT_OF_SALEDataSet pOINT_OF_SALEDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        //private POINT_OF_SALEDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
    }
}
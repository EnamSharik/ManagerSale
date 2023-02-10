namespace MANAGER_SALE.INTERFACE.ADMIN {
    partial class frame_provider {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_provider));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.entry_company = new DevExpress.XtraEditors.TextEdit();
            this.entry_representative = new DevExpress.XtraEditors.TextEdit();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.button_delete = new DevExpress.XtraEditors.SimpleButton();
            this.button_modify = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.entry_contact = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.entry_state = new DevExpress.XtraEditors.LookUpEdit();
            this.Check_ShowDisable = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_representative.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_contact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl.Location = new System.Drawing.Point(10, 10);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(754, 600);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick_1);
            // 
            // gridView
            // 
            this.gridView.DetailHeight = 284;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(861, 139);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "PROVEEDORES";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(770, 202);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "COMPAÑIA:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(770, 234);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(162, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "REPRESENTANTE:";
            // 
            // entry_company
            // 
            this.entry_company.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_company.Location = new System.Drawing.Point(940, 199);
            this.entry_company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entry_company.Name = "entry_company";
            this.entry_company.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_company.Properties.Appearance.Options.UseFont = true;
            this.entry_company.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_company.Size = new System.Drawing.Size(184, 28);
            this.entry_company.TabIndex = 4;
            // 
            // entry_representative
            // 
            this.entry_representative.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_representative.Location = new System.Drawing.Point(940, 231);
            this.entry_representative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entry_representative.Name = "entry_representative";
            this.entry_representative.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_representative.Properties.Appearance.Options.UseFont = true;
            this.entry_representative.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_representative.Size = new System.Drawing.Size(184, 28);
            this.entry_representative.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Appearance.Options.UseFont = true;
            this.button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_add.ImageOptions.Image")));
            this.button_add.Location = new System.Drawing.Point(770, 383);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(360, 37);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "CREAR";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Appearance.Options.UseFont = true;
            this.button_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.ImageOptions.Image")));
            this.button_delete.Location = new System.Drawing.Point(770, 465);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(360, 37);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "DELETE";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_modify.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify.Appearance.Options.UseFont = true;
            this.button_modify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_modify.ImageOptions.Image")));
            this.button_modify.Location = new System.Drawing.Point(770, 424);
            this.button_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(360, 37);
            this.button_modify.TabIndex = 8;
            this.button_modify.Text = "MODIFICAR";
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(770, 298);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 22);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "ESTADO:";
            // 
            // entry_contact
            // 
            this.entry_contact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_contact.Location = new System.Drawing.Point(940, 263);
            this.entry_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entry_contact.Name = "entry_contact";
            this.entry_contact.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_contact.Properties.Appearance.Options.UseFont = true;
            this.entry_contact.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_contact.Size = new System.Drawing.Size(184, 28);
            this.entry_contact.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(770, 266);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 22);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "CONTACTO:";
            // 
            // entry_state
            // 
            this.entry_state.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_state.Location = new System.Drawing.Point(940, 295);
            this.entry_state.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entry_state.Name = "entry_state";
            this.entry_state.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_state.Properties.Appearance.Options.UseFont = true;
            this.entry_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.entry_state.Size = new System.Drawing.Size(184, 28);
            this.entry_state.TabIndex = 13;
            // 
            // Check_ShowDisable
            // 
            this.Check_ShowDisable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Check_ShowDisable.Location = new System.Drawing.Point(829, 339);
            this.Check_ShowDisable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Check_ShowDisable.Name = "Check_ShowDisable";
            this.Check_ShowDisable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_ShowDisable.Properties.Appearance.Options.UseFont = true;
            this.Check_ShowDisable.Properties.Caption = "MOSTRAR DESHABILITADOS";
            this.Check_ShowDisable.Size = new System.Drawing.Size(256, 26);
            this.Check_ShowDisable.TabIndex = 14;
            this.Check_ShowDisable.CheckedChanged += new System.EventHandler(this.Check_ShowDisable_CheckedChanged_1);
            // 
            // frame_provider
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 623);
            this.Controls.Add(this.Check_ShowDisable);
            this.Controls.Add(this.entry_state);
            this.Controls.Add(this.entry_contact);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.entry_representative);
            this.Controls.Add(this.entry_company);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frame_provider";
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.frame_provider_Load);
            this.Click += new System.EventHandler(this.frame_provider_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_representative.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_contact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit entry_company;
        private DevExpress.XtraEditors.TextEdit entry_representative;
        private DevExpress.XtraEditors.SimpleButton button_add;
        private DevExpress.XtraEditors.SimpleButton button_delete;
        private DevExpress.XtraEditors.SimpleButton button_modify;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit entry_contact;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit entry_state;
        private DevExpress.XtraEditors.CheckEdit Check_ShowDisable;
    }
}
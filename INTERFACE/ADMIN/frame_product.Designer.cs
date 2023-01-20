namespace MANAGER_SALE.INTERFACE.ADMIN {
    partial class frame_product {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frame_product));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator6 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.entry_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.entry_description = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.entry_cost = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.entry_quantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.button_modify = new DevExpress.XtraEditors.SimpleButton();
            this.button_delete = new DevExpress.XtraEditors.SimpleButton();
            this.barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.entry_code = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.entry_salePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Check_ShowDisable = new DevExpress.XtraEditors.CheckEdit();
            this.entry_state = new DevExpress.XtraEditors.LookUpEdit();
            this.entry_profitPercentage = new DevExpress.XtraEditors.TextEdit();
            this.entry_tradeMark = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_cost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_salePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_profitPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_tradeMark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(733, 391);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 24);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "ESTADO:";
            // 
            // entry_name
            // 
            this.entry_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_name.Location = new System.Drawing.Point(957, 123);
            this.entry_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_name.Name = "entry_name";
            this.entry_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_name.Properties.Appearance.Options.UseFont = true;
            this.entry_name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_name.Size = new System.Drawing.Size(301, 30);
            this.entry_name.TabIndex = 35;
            this.entry_name.EditValueChanged += new System.EventHandler(this.entry_name_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(733, 126);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 24);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "NOMBRE:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(904, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 35);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "PRODUCTO";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl.Location = new System.Drawing.Point(14, 23);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(693, 699);
            this.gridControl.TabIndex = 31;
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
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(733, 88);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 24);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "MARCA";
            // 
            // entry_description
            // 
            this.entry_description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_description.Location = new System.Drawing.Point(957, 161);
            this.entry_description.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_description.Name = "entry_description";
            this.entry_description.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_description.Properties.Appearance.Options.UseFont = true;
            this.entry_description.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_description.Size = new System.Drawing.Size(301, 30);
            this.entry_description.TabIndex = 46;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(733, 164);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(151, 24);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "DESCRIPCION:";
            // 
            // entry_cost
            // 
            this.entry_cost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_cost.Location = new System.Drawing.Point(957, 237);
            this.entry_cost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_cost.Name = "entry_cost";
            this.entry_cost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_cost.Properties.Appearance.Options.UseFont = true;
            this.entry_cost.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_cost.Properties.ReadOnly = true;
            this.entry_cost.Size = new System.Drawing.Size(301, 30);
            this.entry_cost.TabIndex = 48;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(733, 240);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 24);
            this.labelControl7.TabIndex = 47;
            this.labelControl7.Text = "COSTO:";
            // 
            // entry_quantity
            // 
            this.entry_quantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_quantity.Location = new System.Drawing.Point(957, 351);
            this.entry_quantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_quantity.Name = "entry_quantity";
            this.entry_quantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_quantity.Properties.Appearance.Options.UseFont = true;
            this.entry_quantity.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_quantity.Properties.ReadOnly = true;
            this.entry_quantity.Size = new System.Drawing.Size(301, 30);
            this.entry_quantity.TabIndex = 50;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(733, 354);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(115, 24);
            this.labelControl8.TabIndex = 49;
            this.labelControl8.Text = "CANTIDAD:";
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_add.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_add.ImageOptions.SvgImage")));
            this.button_add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_add.Location = new System.Drawing.Point(718, 600);
            this.button_add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(148, 120);
            this.button_add.TabIndex = 51;
            this.button_add.Text = "AGREGAR";
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // button_modify
            // 
            this.button_modify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_modify.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_modify.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_modify.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_modify.ImageOptions.SvgImage")));
            this.button_modify.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_modify.Location = new System.Drawing.Point(913, 600);
            this.button_modify.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(148, 120);
            this.button_modify.TabIndex = 52;
            this.button_modify.Text = "MODIFICAR";
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_delete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.button_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.button_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("button_delete.ImageOptions.SvgImage")));
            this.button_delete.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.button_delete.Location = new System.Drawing.Point(1108, 600);
            this.button_delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(148, 120);
            this.button_delete.TabIndex = 53;
            this.button_delete.Text = "DELETE";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // barCodeControl
            // 
            this.barCodeControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.barCodeControl.Location = new System.Drawing.Point(717, 460);
            this.barCodeControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.barCodeControl.Name = "barCodeControl";
            this.barCodeControl.Padding = new System.Windows.Forms.Padding(16, 3, 16, 0);
            this.barCodeControl.Size = new System.Drawing.Size(539, 131);
            this.barCodeControl.Symbology = code128Generator6;
            this.barCodeControl.TabIndex = 54;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(733, 202);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 24);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "CODIGO:";
            // 
            // entry_code
            // 
            this.entry_code.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_code.Location = new System.Drawing.Point(957, 199);
            this.entry_code.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_code.Name = "entry_code";
            this.entry_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_code.Properties.Appearance.Options.UseFont = true;
            this.entry_code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_code.Properties.ReadOnly = true;
            this.entry_code.Size = new System.Drawing.Size(301, 30);
            this.entry_code.TabIndex = 44;
            this.entry_code.EditValueChanged += new System.EventHandler(this.entry_code_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(733, 278);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(158, 24);
            this.labelControl9.TabIndex = 55;
            this.labelControl9.Text = "GANANCIA (%)";
            // 
            // entry_salePrice
            // 
            this.entry_salePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_salePrice.Location = new System.Drawing.Point(957, 313);
            this.entry_salePrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_salePrice.Name = "entry_salePrice";
            this.entry_salePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_salePrice.Properties.Appearance.Options.UseFont = true;
            this.entry_salePrice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_salePrice.Properties.ReadOnly = true;
            this.entry_salePrice.Size = new System.Drawing.Size(299, 30);
            this.entry_salePrice.TabIndex = 58;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(733, 316);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(158, 24);
            this.labelControl10.TabIndex = 57;
            this.labelControl10.Text = "PRECIO VENTA:";
            // 
            // Check_ShowDisable
            // 
            this.Check_ShowDisable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Check_ShowDisable.Location = new System.Drawing.Point(956, 424);
            this.Check_ShowDisable.Name = "Check_ShowDisable";
            this.Check_ShowDisable.Properties.Caption = "MOSTRAR DESHABILITADOS";
            this.Check_ShowDisable.Size = new System.Drawing.Size(300, 28);
            this.Check_ShowDisable.TabIndex = 59;
            this.Check_ShowDisable.CheckedChanged += new System.EventHandler(this.Check_ShowDisable_CheckedChanged);
            // 
            // entry_state
            // 
            this.entry_state.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_state.Location = new System.Drawing.Point(957, 388);
            this.entry_state.Name = "entry_state";
            this.entry_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.entry_state.Size = new System.Drawing.Size(301, 30);
            this.entry_state.TabIndex = 60;
            // 
            // entry_profitPercentage
            // 
            this.entry_profitPercentage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_profitPercentage.Location = new System.Drawing.Point(957, 275);
            this.entry_profitPercentage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_profitPercentage.Name = "entry_profitPercentage";
            this.entry_profitPercentage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_profitPercentage.Properties.Appearance.Options.UseFont = true;
            this.entry_profitPercentage.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_profitPercentage.Size = new System.Drawing.Size(301, 30);
            this.entry_profitPercentage.TabIndex = 61;
            this.entry_profitPercentage.EditValueChanged += new System.EventHandler(this.entry_profitPercentage_EditValueChanged);
            // 
            // entry_tradeMark
            // 
            this.entry_tradeMark.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entry_tradeMark.Location = new System.Drawing.Point(957, 85);
            this.entry_tradeMark.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entry_tradeMark.Name = "entry_tradeMark";
            this.entry_tradeMark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_tradeMark.Properties.Appearance.Options.UseFont = true;
            this.entry_tradeMark.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entry_tradeMark.Size = new System.Drawing.Size(301, 30);
            this.entry_tradeMark.TabIndex = 62;
            // 
            // frame_product
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 735);
            this.Controls.Add(this.entry_tradeMark);
            this.Controls.Add(this.entry_profitPercentage);
            this.Controls.Add(this.entry_state);
            this.Controls.Add(this.Check_ShowDisable);
            this.Controls.Add(this.entry_salePrice);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.barCodeControl);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.entry_quantity);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.entry_cost);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.entry_description);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.entry_code);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.entry_name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frame_product";
            this.Text = "PRODUCTO";
            this.Load += new System.EventHandler(this.frame_product_Load);
            this.Click += new System.EventHandler(this.frame_product_Click);
            ((System.ComponentModel.ISupportInitialize)(this.entry_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_cost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_salePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_ShowDisable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_profitPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_tradeMark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit entry_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit entry_description;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit entry_cost;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit entry_quantity;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton button_add;
        private DevExpress.XtraEditors.SimpleButton button_modify;
        private DevExpress.XtraEditors.SimpleButton button_delete;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit entry_code;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit entry_salePrice;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit Check_ShowDisable;
        private DevExpress.XtraEditors.LookUpEdit entry_state;
        private DevExpress.XtraEditors.TextEdit entry_profitPercentage;
        private DevExpress.XtraEditors.TextEdit entry_tradeMark;
    }
}
namespace DanhMuc
{
    partial class mnc1DMDuocBenhVienUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDangSUDung = new System.Windows.Forms.TabPage();
            this.grvDangSuDung = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbNgungSuDung = new System.Windows.Forms.TabPage();
            this.grvNgungSuDung = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkLoaiVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbDangSUDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDangSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tbNgungSuDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNgungSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVatTu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDangSUDung);
            this.tabControl1.Controls.Add(this.tbNgungSuDung);
            this.tabControl1.Location = new System.Drawing.Point(7, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tbDangSUDung
            // 
            this.tbDangSUDung.Controls.Add(this.grvDangSuDung);
            this.tbDangSUDung.Location = new System.Drawing.Point(4, 24);
            this.tbDangSUDung.Name = "tbDangSUDung";
            this.tbDangSUDung.Padding = new System.Windows.Forms.Padding(3);
            this.tbDangSUDung.Size = new System.Drawing.Size(1006, 535);
            this.tbDangSUDung.TabIndex = 0;
            this.tbDangSUDung.Text = "Đang Sử Dụng";
            this.tbDangSUDung.UseVisualStyleBackColor = true;
            // 
            // grvDangSuDung
            // 
            this.grvDangSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDangSuDung.Location = new System.Drawing.Point(3, 3);
            this.grvDangSuDung.MainView = this.gridView2;
            this.grvDangSuDung.Name = "grvDangSuDung";
            this.grvDangSuDung.Size = new System.Drawing.Size(1000, 529);
            this.grvDangSuDung.TabIndex = 0;
            this.grvDangSuDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grvDangSuDung;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // tbNgungSuDung
            // 
            this.tbNgungSuDung.Controls.Add(this.grvNgungSuDung);
            this.tbNgungSuDung.Location = new System.Drawing.Point(4, 24);
            this.tbNgungSuDung.Name = "tbNgungSuDung";
            this.tbNgungSuDung.Padding = new System.Windows.Forms.Padding(3);
            this.tbNgungSuDung.Size = new System.Drawing.Size(1006, 535);
            this.tbNgungSuDung.TabIndex = 1;
            this.tbNgungSuDung.Text = "Ngưng Sử Dụng";
            this.tbNgungSuDung.UseVisualStyleBackColor = true;
            // 
            // grvNgungSuDung
            // 
            this.grvNgungSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvNgungSuDung.Location = new System.Drawing.Point(3, 3);
            this.grvNgungSuDung.MainView = this.gridView1;
            this.grvNgungSuDung.Name = "grvNgungSuDung";
            this.grvNgungSuDung.Size = new System.Drawing.Size(1000, 529);
            this.grvNgungSuDung.TabIndex = 0;
            this.grvNgungSuDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grvNgungSuDung;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkLoaiVatTu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lkLoaiVatTu
            // 
            this.lkLoaiVatTu.Location = new System.Drawing.Point(76, 17);
            this.lkLoaiVatTu.Name = "lkLoaiVatTu";
            this.lkLoaiVatTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLoaiVatTu.Properties.Appearance.Options.UseFont = true;
            this.lkLoaiVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiVatTu.Properties.NullText = "";
            this.lkLoaiVatTu.Size = new System.Drawing.Size(151, 22);
            this.lkLoaiVatTu.TabIndex = 2;
            this.lkLoaiVatTu.TextChanged += new System.EventHandler(this.lkLoaiVatTu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại vật tư";
            // 
            // mnc1DMDuocBenhVienUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "mnc1DMDuocBenhVienUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.tabControl1.ResumeLayout(false);
            this.tbDangSUDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDangSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tbNgungSuDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvNgungSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVatTu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDangSUDung;
        private System.Windows.Forms.TabPage tbNgungSuDung;
        private DevExpress.XtraGrid.GridControl grvDangSuDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grvNgungSuDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit lkLoaiVatTu;
        private System.Windows.Forms.Label label1;
    }
}

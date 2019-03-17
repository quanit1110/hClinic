namespace DanhMuc
{
    partial class mnc1GioiHanDuocTonKhoUC
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDuocDayDu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoDuoc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNguonDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkNguonHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lkKhoDuoc = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNguonHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoDuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1014, 577);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDuoc,
            this.TenDuocDayDu,
            this.TenLoaiDuoc,
            this.gridColumn1,
            this.Soluong,
            this.KhoDuoc_Id,
            this.TenNguonDuoc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaDuoc
            // 
            this.MaDuoc.Caption = "Mã dược";
            this.MaDuoc.FieldName = "MaDuoc";
            this.MaDuoc.Name = "MaDuoc";
            this.MaDuoc.Visible = true;
            this.MaDuoc.VisibleIndex = 0;
            // 
            // TenDuocDayDu
            // 
            this.TenDuocDayDu.Caption = "Tên dược";
            this.TenDuocDayDu.FieldName = "TenDuocDayDu";
            this.TenDuocDayDu.Name = "TenDuocDayDu";
            this.TenDuocDayDu.Visible = true;
            this.TenDuocDayDu.VisibleIndex = 1;
            // 
            // TenLoaiDuoc
            // 
            this.TenLoaiDuoc.Caption = "Loại dược";
            this.TenLoaiDuoc.FieldName = "TenLoaiDuoc";
            this.TenLoaiDuoc.Name = "TenLoaiDuoc";
            this.TenLoaiDuoc.Visible = true;
            this.TenLoaiDuoc.VisibleIndex = 2;
            // 
            // Soluong
            // 
            this.Soluong.Caption = "Tồn hiện tại";
            this.Soluong.FieldName = "Soluong";
            this.Soluong.Name = "Soluong";
            this.Soluong.Visible = true;
            this.Soluong.VisibleIndex = 4;
            // 
            // KhoDuoc_Id
            // 
            this.KhoDuoc_Id.Caption = "Kho dược";
            this.KhoDuoc_Id.FieldName = "KhoDuoc_Id";
            this.KhoDuoc_Id.Name = "KhoDuoc_Id";
            this.KhoDuoc_Id.Visible = true;
            this.KhoDuoc_Id.VisibleIndex = 5;
            // 
            // TenNguonDuoc
            // 
            this.TenNguonDuoc.Caption = "Nguồn hàng nhập";
            this.TenNguonDuoc.FieldName = "TenNguonDuoc";
            this.TenNguonDuoc.Name = "TenNguonDuoc";
            this.TenNguonDuoc.Visible = true;
            this.TenNguonDuoc.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkNguonHang);
            this.groupBox1.Controls.Add(this.lkKhoDuoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lkNguonHang
            // 
            this.lkNguonHang.Location = new System.Drawing.Point(382, 16);
            this.lkNguonHang.Name = "lkNguonHang";
            this.lkNguonHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkNguonHang.Properties.Appearance.Options.UseFont = true;
            this.lkNguonHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNguonHang.Properties.NullText = "";
            this.lkNguonHang.Size = new System.Drawing.Size(223, 22);
            this.lkNguonHang.TabIndex = 43;
            // 
            // lkKhoDuoc
            // 
            this.lkKhoDuoc.Location = new System.Drawing.Point(68, 17);
            this.lkKhoDuoc.Name = "lkKhoDuoc";
            this.lkKhoDuoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkKhoDuoc.Properties.Appearance.Options.UseFont = true;
            this.lkKhoDuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoDuoc.Properties.NullText = "";
            this.lkKhoDuoc.Size = new System.Drawing.Size(223, 22);
            this.lkKhoDuoc.TabIndex = 42;
            this.lkKhoDuoc.TextChanged += new System.EventHandler(this.lkKhoDuoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(297, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nguồn Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Kho Dược:";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số lượng";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // mnc1GioiHanDuocTonKhoUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Name = "mnc1GioiHanDuocTonKhoUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNguonHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoDuoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn MaDuoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenDuocDayDu;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiDuoc;
        private DevExpress.XtraGrid.Columns.GridColumn Soluong;
        private DevExpress.XtraGrid.Columns.GridColumn KhoDuoc_Id;
        private DevExpress.XtraGrid.Columns.GridColumn TenNguonDuoc;
        private DevExpress.XtraEditors.LookUpEdit lkNguonHang;
        private DevExpress.XtraEditors.LookUpEdit lkKhoDuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}

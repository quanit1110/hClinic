namespace KhamSucKhoe
{
    partial class mncDanhMucCongTyKhamSucKhoeUC
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
            this.MaCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCongty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaNuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NuocNgoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 630);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCongTy,
            this.TenCongty,
            this.NhaNuoc,
            this.NuocNgoai,
            this.DiaChi,
            this.DienThoai,
            this.Fax,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // MaCongTy
            // 
            this.MaCongTy.Caption = "Mã công ty";
            this.MaCongTy.FieldName = "MaCongty";
            this.MaCongTy.Name = "MaCongTy";
            this.MaCongTy.Visible = true;
            this.MaCongTy.VisibleIndex = 0;
            this.MaCongTy.Width = 68;
            // 
            // TenCongty
            // 
            this.TenCongty.Caption = "Tên công ty";
            this.TenCongty.FieldName = "TenCongty";
            this.TenCongty.Name = "TenCongty";
            this.TenCongty.Visible = true;
            this.TenCongty.VisibleIndex = 1;
            this.TenCongty.Width = 158;
            // 
            // NhaNuoc
            // 
            this.NhaNuoc.Caption = "Nhà Nước";
            this.NhaNuoc.FieldName = "NhaNuoc";
            this.NhaNuoc.Name = "NhaNuoc";
            this.NhaNuoc.Tag = false;
            this.NhaNuoc.Visible = true;
            this.NhaNuoc.VisibleIndex = 2;
            this.NhaNuoc.Width = 52;
            // 
            // NuocNgoai
            // 
            this.NuocNgoai.Caption = "Nước ngoài";
            this.NuocNgoai.FieldName = "NuocNgoai";
            this.NuocNgoai.Name = "NuocNgoai";
            this.NuocNgoai.Tag = false;
            this.NuocNgoai.Visible = true;
            this.NuocNgoai.VisibleIndex = 3;
            this.NuocNgoai.Width = 52;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 4;
            this.DiaChi.Width = 212;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 5;
            this.DienThoai.Width = 78;
            // 
            // Fax
            // 
            this.Fax.Caption = "Fax";
            this.Fax.FieldName = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Visible = true;
            this.Fax.VisibleIndex = 6;
            this.Fax.Width = 78;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Số Thuế";
            this.gridColumn1.FieldName = "MaSoThue";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 78;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Giám đốc";
            this.gridColumn2.FieldName = "GiamDoc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            this.gridColumn2.Width = 78;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Người liên hệ";
            this.gridColumn3.FieldName = "NguoiLienHe";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 78;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tạm Ngưng";
            this.gridColumn4.FieldName = "TamNgung";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Tag = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            this.gridColumn4.Width = 70;
            // 
            // mncDanhMucCongTyKhamSucKhoeUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "mncDanhMucCongTyKhamSucKhoeUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn TenCongty;
        private DevExpress.XtraGrid.Columns.GridColumn NhaNuoc;
        private DevExpress.XtraGrid.Columns.GridColumn NuocNgoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn Fax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}

namespace DanhMuc
{
    partial class mnc1DanhMucBacSiDichVuUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnc1DanhMucBacSiDichVuUC));
            this.tvDichVu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDichVu
            // 
            this.tvDichVu.CheckBoxes = true;
            this.tvDichVu.Location = new System.Drawing.Point(703, 3);
            this.tvDichVu.Name = "tvDichVu";
            this.tvDichVu.Size = new System.Drawing.Size(314, 624);
            this.tvDichVu.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Home-icon.png");
            this.imageList1.Images.SetKeyName(2, "Steak-icon.png");
            this.imageList1.Images.SetKeyName(3, "strawberry-icon.png");
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(694, 624);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhanVien,
            this.Ho,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.TenPhongBan,
            this.MaChucVu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVien.AppearanceCell.Options.UseFont = true;
            this.MaNhanVien.Caption = "Mã nhân viên";
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 0;
            // 
            // Ho
            // 
            this.Ho.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ho.AppearanceCell.Options.UseFont = true;
            this.Ho.Caption = "Họ";
            this.Ho.FieldName = "Ho";
            this.Ho.Name = "Ho";
            this.Ho.Visible = true;
            this.Ho.VisibleIndex = 1;
            // 
            // Ten
            // 
            this.Ten.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.AppearanceCell.Options.UseFont = true;
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 2;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.AppearanceCell.Options.UseFont = true;
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.AppearanceCell.Options.UseFont = true;
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhongBan.AppearanceCell.Options.UseFont = true;
            this.TenPhongBan.Caption = "Tên Phòng Ban";
            this.TenPhongBan.FieldName = "TenPhongBan";
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.Visible = true;
            this.TenPhongBan.VisibleIndex = 5;
            // 
            // MaChucVu
            // 
            this.MaChucVu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaChucVu.AppearanceCell.Options.UseFont = true;
            this.MaChucVu.Caption = "Mã Chức Vụ";
            this.MaChucVu.FieldName = "MaChucVu";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Visible = true;
            this.MaChucVu.VisibleIndex = 6;
            // 
            // mnc1DanhMucBacSiDichVuUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tvDichVu);
            this.Name = "mnc1DanhMucBacSiDichVuUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tvDichVu;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn Ho;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn TenPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn MaChucVu;
    }
}

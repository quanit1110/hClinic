namespace DanhMuc
{
    partial class mnc1DanhMucGiuongBenhUC
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
            this.MaGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiuongTrong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TamNgung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VatDungKemTheo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 627);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaGiuong,
            this.Tang,
            this.GiuongTrong,
            this.TamNgung,
            this.VatDungKemTheo,
            this.MoTa,
            this.TenPhongBan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaGiuong
            // 
            this.MaGiuong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiuong.AppearanceCell.Options.UseFont = true;
            this.MaGiuong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiuong.AppearanceHeader.Options.UseFont = true;
            this.MaGiuong.Caption = "Mã giường";
            this.MaGiuong.FieldName = "MaGiuong";
            this.MaGiuong.Name = "MaGiuong";
            this.MaGiuong.Visible = true;
            this.MaGiuong.VisibleIndex = 0;
            // 
            // Tang
            // 
            this.Tang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tang.AppearanceCell.Options.UseFont = true;
            this.Tang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tang.AppearanceHeader.Options.UseFont = true;
            this.Tang.Caption = "Tầng";
            this.Tang.FieldName = "Tang";
            this.Tang.Name = "Tang";
            this.Tang.Visible = true;
            this.Tang.VisibleIndex = 1;
            // 
            // GiuongTrong
            // 
            this.GiuongTrong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiuongTrong.AppearanceCell.Options.UseFont = true;
            this.GiuongTrong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiuongTrong.AppearanceHeader.Options.UseFont = true;
            this.GiuongTrong.Caption = "Giường trống";
            this.GiuongTrong.FieldName = "GiuongTrong";
            this.GiuongTrong.Name = "GiuongTrong";
            this.GiuongTrong.Visible = true;
            this.GiuongTrong.VisibleIndex = 2;
            // 
            // TamNgung
            // 
            this.TamNgung.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamNgung.AppearanceCell.Options.UseFont = true;
            this.TamNgung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamNgung.AppearanceHeader.Options.UseFont = true;
            this.TamNgung.Caption = "Tạm Ngưng";
            this.TamNgung.FieldName = "TamNgung";
            this.TamNgung.Name = "TamNgung";
            this.TamNgung.Visible = true;
            this.TamNgung.VisibleIndex = 3;
            // 
            // VatDungKemTheo
            // 
            this.VatDungKemTheo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VatDungKemTheo.AppearanceCell.Options.UseFont = true;
            this.VatDungKemTheo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VatDungKemTheo.AppearanceHeader.Options.UseFont = true;
            this.VatDungKemTheo.Caption = "Vật dụng kèm theo";
            this.VatDungKemTheo.FieldName = "VatDungKemTheo";
            this.VatDungKemTheo.Name = "VatDungKemTheo";
            this.VatDungKemTheo.Visible = true;
            this.VatDungKemTheo.VisibleIndex = 4;
            // 
            // MoTa
            // 
            this.MoTa.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa.AppearanceCell.Options.UseFont = true;
            this.MoTa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa.AppearanceHeader.Options.UseFont = true;
            this.MoTa.Caption = "Mô tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 5;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhongBan.AppearanceCell.Options.UseFont = true;
            this.TenPhongBan.Caption = "Tên Phòng Ban";
            this.TenPhongBan.FieldName = "TenPhongBan";
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.Visible = true;
            this.TenPhongBan.VisibleIndex = 6;
            // 
            // mnc1DanhMucGiuongBenhUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "mnc1DanhMucGiuongBenhUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn Tang;
        private DevExpress.XtraGrid.Columns.GridColumn GiuongTrong;
        private DevExpress.XtraGrid.Columns.GridColumn TamNgung;
        private DevExpress.XtraGrid.Columns.GridColumn VatDungKemTheo;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraGrid.Columns.GridColumn TenPhongBan;
    }
}

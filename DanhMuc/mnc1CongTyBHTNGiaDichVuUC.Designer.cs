namespace DanhMuc
{
    partial class mnc1CongTyBHTNGiaDichVuUC
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
            this.Congty_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCongty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCongty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DichVu_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InputCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhomDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(415, 624);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Congty_Id,
            this.MaCongty,
            this.TenCongty});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Congty_Id
            // 
            this.Congty_Id.Caption = "Công ty ID";
            this.Congty_Id.FieldName = "Congty_Id";
            this.Congty_Id.Name = "Congty_Id";
            this.Congty_Id.Visible = true;
            this.Congty_Id.VisibleIndex = 0;
            this.Congty_Id.Width = 90;
            // 
            // MaCongty
            // 
            this.MaCongty.Caption = "Mã công ty";
            this.MaCongty.FieldName = "MaCongty";
            this.MaCongty.Name = "MaCongty";
            this.MaCongty.Visible = true;
            this.MaCongty.VisibleIndex = 1;
            this.MaCongty.Width = 79;
            // 
            // TenCongty
            // 
            this.TenCongty.Caption = "Tên công ty";
            this.TenCongty.FieldName = "TenCongty";
            this.TenCongty.Name = "TenCongty";
            this.TenCongty.Visible = true;
            this.TenCongty.VisibleIndex = 2;
            this.TenCongty.Width = 228;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(421, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.check});
            this.gridControl2.Size = new System.Drawing.Size(596, 624);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.DichVu_Id,
            this.InputCode,
            this.TenDichVu,
            this.TenNhomDichVu,
            this.TenLoaiDichVu,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.Caption = "Chọn";
            this.gridColumn4.ColumnEdit = this.check;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 64;
            // 
            // check
            // 
            this.check.AutoHeight = false;
            this.check.Name = "check";
            // 
            // DichVu_Id
            // 
            this.DichVu_Id.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DichVu_Id.AppearanceCell.Options.UseFont = true;
            this.DichVu_Id.Caption = "Dịch vụ ID";
            this.DichVu_Id.FieldName = "DichVu_Id";
            this.DichVu_Id.Name = "DichVu_Id";
            this.DichVu_Id.Visible = true;
            this.DichVu_Id.VisibleIndex = 1;
            this.DichVu_Id.Width = 64;
            // 
            // InputCode
            // 
            this.InputCode.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCode.AppearanceCell.Options.UseFont = true;
            this.InputCode.Caption = "InputCode";
            this.InputCode.FieldName = "InputCode";
            this.InputCode.Name = "InputCode";
            this.InputCode.Visible = true;
            this.InputCode.VisibleIndex = 2;
            this.InputCode.Width = 64;
            // 
            // TenDichVu
            // 
            this.TenDichVu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDichVu.AppearanceCell.Options.UseFont = true;
            this.TenDichVu.Caption = "Tên dịch vụ";
            this.TenDichVu.FieldName = "TenDichVu";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.Visible = true;
            this.TenDichVu.VisibleIndex = 3;
            this.TenDichVu.Width = 102;
            // 
            // TenNhomDichVu
            // 
            this.TenNhomDichVu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhomDichVu.AppearanceCell.Options.UseFont = true;
            this.TenNhomDichVu.Caption = "Tên nhóm dịch vụ";
            this.TenNhomDichVu.FieldName = "TenNhomDichVu";
            this.TenNhomDichVu.Name = "TenNhomDichVu";
            this.TenNhomDichVu.Visible = true;
            this.TenNhomDichVu.VisibleIndex = 4;
            this.TenNhomDichVu.Width = 56;
            // 
            // TenLoaiDichVu
            // 
            this.TenLoaiDichVu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoaiDichVu.AppearanceCell.Options.UseFont = true;
            this.TenLoaiDichVu.Caption = "Tên loại dịch vụ";
            this.TenLoaiDichVu.FieldName = "TenLoaiDichVu";
            this.TenLoaiDichVu.Name = "TenLoaiDichVu";
            this.TenLoaiDichVu.Visible = true;
            this.TenLoaiDichVu.VisibleIndex = 8;
            this.TenLoaiDichVu.Width = 60;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "Đơn giá";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 56;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.Caption = "Người cập nhật";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 56;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.Caption = "Ngày cập nhật";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 56;
            // 
            // mnc1CongTyBHTNGiaDichVuUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "mnc1CongTyBHTNGiaDichVuUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Congty_Id;
        private DevExpress.XtraGrid.Columns.GridColumn MaCongty;
        private DevExpress.XtraGrid.Columns.GridColumn TenCongty;
        private DevExpress.XtraGrid.Columns.GridColumn DichVu_Id;
        private DevExpress.XtraGrid.Columns.GridColumn InputCode;
        private DevExpress.XtraGrid.Columns.GridColumn TenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhomDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit check;
    }
}

namespace DanhMuc
{
    partial class mnc1DMDuocTheoNguonHangUC
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.MaDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDuocDayDu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiDuoc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HamLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lkNguonHang = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNguonHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1014, 590);
            this.gridControl1.TabIndex = 101;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.MaDuoc,
            this.TenDuocDayDu,
            this.LoaiDuoc_Id,
            this.DonViTinh,
            this.HamLuong,
            this.TenHang,
            this.QuocGia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chọn";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // MaDuoc
            // 
            this.MaDuoc.Caption = "Mã dược";
            this.MaDuoc.FieldName = "MaDuoc";
            this.MaDuoc.Name = "MaDuoc";
            this.MaDuoc.Visible = true;
            this.MaDuoc.VisibleIndex = 1;
            // 
            // TenDuocDayDu
            // 
            this.TenDuocDayDu.Caption = "Tên Dược";
            this.TenDuocDayDu.FieldName = "TenDuocDayDu";
            this.TenDuocDayDu.Name = "TenDuocDayDu";
            this.TenDuocDayDu.Visible = true;
            this.TenDuocDayDu.VisibleIndex = 2;
            // 
            // LoaiDuoc_Id
            // 
            this.LoaiDuoc_Id.Caption = "Loại dược";
            this.LoaiDuoc_Id.FieldName = "LoaiDuoc_Id";
            this.LoaiDuoc_Id.Name = "LoaiDuoc_Id";
            this.LoaiDuoc_Id.Visible = true;
            this.LoaiDuoc_Id.VisibleIndex = 3;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 4;
            // 
            // HamLuong
            // 
            this.HamLuong.Caption = "Hàm lượng";
            this.HamLuong.FieldName = "HamLuong";
            this.HamLuong.Name = "HamLuong";
            this.HamLuong.Visible = true;
            this.HamLuong.VisibleIndex = 5;
            // 
            // TenHang
            // 
            this.TenHang.Caption = "Tên Hàng";
            this.TenHang.FieldName = "TenHang";
            this.TenHang.Name = "TenHang";
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 6;
            // 
            // QuocGia
            // 
            this.QuocGia.Caption = "Quốc gia";
            this.QuocGia.FieldName = "QuocGia";
            this.QuocGia.Name = "QuocGia";
            this.QuocGia.Visible = true;
            this.QuocGia.VisibleIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(17, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 99;
            this.label10.Text = "Nguồn Hàng:";
            // 
            // lkNguonHang
            // 
            this.lkNguonHang.Location = new System.Drawing.Point(93, 7);
            this.lkNguonHang.Name = "lkNguonHang";
            this.lkNguonHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkNguonHang.Properties.Appearance.Options.UseFont = true;
            this.lkNguonHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNguonHang.Properties.NullText = "";
            this.lkNguonHang.Size = new System.Drawing.Size(532, 22);
            this.lkNguonHang.TabIndex = 102;
            this.lkNguonHang.TextChanged += new System.EventHandler(this.lkNguonHang_TextChanged);
            // 
            // mnc1DMDuocTheoNguonHangUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lkNguonHang);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label10);
            this.Name = "mnc1DMDuocTheoNguonHangUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNguonHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.LookUpEdit lkNguonHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaDuoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenDuocDayDu;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiDuoc_Id;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn HamLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraGrid.Columns.GridColumn QuocGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}

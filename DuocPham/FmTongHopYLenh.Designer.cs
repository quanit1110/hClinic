namespace DuocPham
{
    partial class FmTongHopYLenh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoQua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nguon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoQua.Appearance.Options.UseFont = true;
            this.btnBoQua.Location = new System.Drawing.Point(714, 460);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(131, 23);
            this.btnBoQua.TabIndex = 603;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongY.Appearance.Options.UseFont = true;
            this.btnDongY.Location = new System.Drawing.Point(554, 460);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(129, 23);
            this.btnDongY.TabIndex = 602;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(853, 449);
            this.gridControl1.TabIndex = 604;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BenhNhan,
            this.NgayKham,
            this.TenDuoc,
            this.DVT,
            this.SoLuong,
            this.Nguon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BenhNhan
            // 
            this.BenhNhan.FieldName = "BenhNhan";
            this.BenhNhan.Name = "BenhNhan";
            this.BenhNhan.Visible = true;
            this.BenhNhan.VisibleIndex = 1;
            // 
            // NgayKham
            // 
            this.NgayKham.FieldName = "Ngay";
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Visible = true;
            this.NgayKham.VisibleIndex = 2;
            // 
            // TenDuoc
            // 
            this.TenDuoc.Caption = "Tên thuốc, Hàm lượng (Hãng SX)";
            this.TenDuoc.FieldName = "TenDuocDayDu";
            this.TenDuoc.Name = "TenDuoc";
            this.TenDuoc.Visible = true;
            this.TenDuoc.VisibleIndex = 3;
            // 
            // DVT
            // 
            this.DVT.Caption = "DVT";
            this.DVT.FieldName = "DonViTinhCoBan";
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 4;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuongYeuCau";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 5;
            // 
            // Nguon
            // 
            this.Nguon.Caption = "Nguồn dược";
            this.Nguon.FieldName = "NguonDuoc";
            this.Nguon.Name = "Nguon";
            this.Nguon.Visible = true;
            this.Nguon.VisibleIndex = 6;
            // 
            // FmTongHopYLenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 489);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FmTongHopYLenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn y lệnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBoQua;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKham;
        private DevExpress.XtraGrid.Columns.GridColumn TenDuoc;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn Nguon;
    }
}
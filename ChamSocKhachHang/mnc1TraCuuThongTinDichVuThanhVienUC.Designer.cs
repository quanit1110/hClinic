namespace ChamSocKhachHang
{
    partial class mnc1TraCuuThongTinDichVuThanhVienUC
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btLayDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaThe = new DevExpress.XtraEditors.TextEdit();
            this.lkLoaiTV = new DevExpress.XtraEditors.LookUpEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDenNgay = new DevExpress.XtraEditors.TextEdit();
            this.txtTuNgay = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lkPhuongXa = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lkQuanHuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.lkTinhThanh = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamSinh = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiTV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhuongXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkQuanHuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTinhThanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(9, 87);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1006, 540);
            this.gridControl1.TabIndex = 84;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btLayDuLieu
            // 
            this.btLayDuLieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayDuLieu.Appearance.Options.UseFont = true;
            this.btLayDuLieu.Location = new System.Drawing.Point(940, 3);
            this.btLayDuLieu.Name = "btLayDuLieu";
            this.btLayDuLieu.Size = new System.Drawing.Size(75, 75);
            this.btLayDuLieu.TabIndex = 83;
            this.btLayDuLieu.Text = "Lấy dữ liệu";
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(750, 31);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Properties.Appearance.Options.UseFont = true;
            this.txtMaThe.Size = new System.Drawing.Size(185, 22);
            this.txtMaThe.TabIndex = 82;
            // 
            // lkLoaiTV
            // 
            this.lkLoaiTV.Location = new System.Drawing.Point(750, 3);
            this.lkLoaiTV.Name = "lkLoaiTV";
            this.lkLoaiTV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLoaiTV.Properties.Appearance.Options.UseFont = true;
            this.lkLoaiTV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiTV.Properties.NullText = "";
            this.lkLoaiTV.Size = new System.Drawing.Size(185, 22);
            this.lkLoaiTV.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(693, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 80;
            this.label10.Text = "Mã thẻ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 79;
            this.label9.Text = "Loại TV:";
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Location = new System.Drawing.Point(574, 31);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenNgay.Properties.Appearance.Options.UseFont = true;
            this.txtDenNgay.Size = new System.Drawing.Size(113, 22);
            this.txtDenNgay.TabIndex = 78;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Location = new System.Drawing.Point(574, 3);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.Properties.Appearance.Options.UseFont = true;
            this.txtTuNgay.Size = new System.Drawing.Size(113, 22);
            this.txtTuNgay.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "Đến ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 75;
            this.label7.Text = "Từ ngày:";
            // 
            // lkPhuongXa
            // 
            this.lkPhuongXa.Location = new System.Drawing.Point(386, 59);
            this.lkPhuongXa.Name = "lkPhuongXa";
            this.lkPhuongXa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkPhuongXa.Properties.Appearance.Options.UseFont = true;
            this.lkPhuongXa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhuongXa.Properties.NullText = "";
            this.lkPhuongXa.Size = new System.Drawing.Size(121, 22);
            this.lkPhuongXa.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "Phường/Xã:";
            // 
            // lkQuanHuyen
            // 
            this.lkQuanHuyen.Location = new System.Drawing.Point(386, 31);
            this.lkQuanHuyen.Name = "lkQuanHuyen";
            this.lkQuanHuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkQuanHuyen.Properties.Appearance.Options.UseFont = true;
            this.lkQuanHuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkQuanHuyen.Properties.NullText = "";
            this.lkQuanHuyen.Size = new System.Drawing.Size(121, 22);
            this.lkQuanHuyen.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Quận/Huyện:";
            // 
            // lkTinhThanh
            // 
            this.lkTinhThanh.Location = new System.Drawing.Point(386, 3);
            this.lkTinhThanh.Name = "lkTinhThanh";
            this.lkTinhThanh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkTinhThanh.Properties.Appearance.Options.UseFont = true;
            this.lkTinhThanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTinhThanh.Properties.NullText = "";
            this.lkTinhThanh.Size = new System.Drawing.Size(121, 22);
            this.lkTinhThanh.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tỉnh/Thành:";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(69, 59);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Properties.Appearance.Options.UseFont = true;
            this.txtNamSinh.Size = new System.Drawing.Size(89, 22);
            this.txtNamSinh.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "Năm sinh:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(69, 31);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(228, 22);
            this.txtDiaChi.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(69, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Size = new System.Drawing.Size(228, 22);
            this.txtHoTen.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Họ tên:";
            // 
            // mnc1TraCuuThongTinDichVuThanhVienUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btLayDuLieu);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.lkLoaiTV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.txtTuNgay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lkPhuongXa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lkQuanHuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lkTinhThanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Name = "mnc1TraCuuThongTinDichVuThanhVienUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiTV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhuongXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkQuanHuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTinhThanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btLayDuLieu;
        private DevExpress.XtraEditors.TextEdit txtMaThe;
        private DevExpress.XtraEditors.LookUpEdit lkLoaiTV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtDenNgay;
        private DevExpress.XtraEditors.TextEdit txtTuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit lkPhuongXa;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lkQuanHuyen;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lkTinhThanh;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNamSinh;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.Label label2;
    }
}

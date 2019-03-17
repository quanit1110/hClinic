namespace DanhMuc
{
    partial class mnc1DMGiaThauBenhVienUC
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
            this.tvGoiThau = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBoLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdNhaThuoc = new System.Windows.Forms.RadioButton();
            this.rdBenhVien = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayCungCap = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dtHopDong = new DevExpress.XtraEditors.DateEdit();
            this.dtHetHan = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lkNCC = new DevExpress.XtraEditors.LookUpEdit();
            this.lkGT = new DevExpress.XtraEditors.LookUpEdit();
            this.lkDuoc = new DevExpress.XtraEditors.LookUpEdit();
            this.lkNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.lkGoiThau = new DevExpress.XtraEditors.LookUpEdit();
            this.Duoc_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaDuTru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongDaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaThongTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoViSa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaQuyetDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNamHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCungCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHopDong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHopDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHetHan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkGT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkGoiThau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tvGoiThau
            // 
            this.tvGoiThau.Location = new System.Drawing.Point(6, 143);
            this.tvGoiThau.Name = "tvGoiThau";
            this.tvGoiThau.Size = new System.Drawing.Size(290, 475);
            this.tvGoiThau.TabIndex = 2;
            this.tvGoiThau.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvGoiThau_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkDuoc);
            this.groupBox1.Controls.Add(this.lkGT);
            this.groupBox1.Controls.Add(this.lkNCC);
            this.groupBox1.Controls.Add(this.btnBoLoc);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tvGoiThau);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 624);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoLoc.Appearance.Options.UseFont = true;
            this.btnBoLoc.Location = new System.Drawing.Point(168, 109);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(75, 23);
            this.btnBoLoc.TabIndex = 103;
            this.btnBoLoc.Text = "Bỏ Lọc";
            // 
            // btnLoc
            // 
            this.btnLoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Appearance.Options.UseFont = true;
            this.btnLoc.Location = new System.Drawing.Point(52, 109);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 102;
            this.btnLoc.Text = "Lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 100;
            this.label2.Text = "Dược:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 98;
            this.label1.Text = "Gói Thầu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 96;
            this.label10.Text = "NCC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lkGoiThau);
            this.groupBox2.Controls.Add(this.lkNhaCungCap);
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Controls.Add(this.rdNhaThuoc);
            this.groupBox2.Controls.Add(this.rdBenhVien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtNgayCungCap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtHopDong);
            this.groupBox2.Controls.Add(this.dtHetHan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(310, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 624);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 109);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(695, 509);
            this.gridControl1.TabIndex = 119;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Duoc_Id,
            this.DonGiaHopDong,
            this.DonGiaDuTru,
            this.SoLuongCungCap,
            this.SoLuongDaNhap,
            this.MaThongTu,
            this.SoViSa,
            this.MaQuyetDinh,
            this.SoNamHopDong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // rdNhaThuoc
            // 
            this.rdNhaThuoc.AutoSize = true;
            this.rdNhaThuoc.Location = new System.Drawing.Point(568, 48);
            this.rdNhaThuoc.Name = "rdNhaThuoc";
            this.rdNhaThuoc.Size = new System.Drawing.Size(85, 19);
            this.rdNhaThuoc.TabIndex = 117;
            this.rdNhaThuoc.TabStop = true;
            this.rdNhaThuoc.Text = "Nhà Thuốc";
            this.rdNhaThuoc.UseVisualStyleBackColor = true;
            // 
            // rdBenhVien
            // 
            this.rdBenhVien.AutoSize = true;
            this.rdBenhVien.Location = new System.Drawing.Point(568, 20);
            this.rdBenhVien.Name = "rdBenhVien";
            this.rdBenhVien.Size = new System.Drawing.Size(79, 19);
            this.rdBenhVien.TabIndex = 116;
            this.rdBenhVien.TabStop = true;
            this.rdBenhVien.Text = "Bệnh Viện";
            this.rdBenhVien.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(495, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "Phạm Vi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(250, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "Gói Thầu:";
            // 
            // dtNgayCungCap
            // 
            this.dtNgayCungCap.EditValue = null;
            this.dtNgayCungCap.Location = new System.Drawing.Point(351, 52);
            this.dtNgayCungCap.Name = "dtNgayCungCap";
            this.dtNgayCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayCungCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayCungCap.Size = new System.Drawing.Size(122, 20);
            this.dtNgayCungCap.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(250, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 112;
            this.label6.Text = "Ngày Cung Cấp:";
            // 
            // dtHopDong
            // 
            this.dtHopDong.EditValue = null;
            this.dtHopDong.Location = new System.Drawing.Point(117, 52);
            this.dtHopDong.Name = "dtHopDong";
            this.dtHopDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHopDong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHopDong.Size = new System.Drawing.Size(122, 20);
            this.dtHopDong.TabIndex = 111;
            // 
            // dtHetHan
            // 
            this.dtHetHan.EditValue = null;
            this.dtHetHan.Location = new System.Drawing.Point(117, 78);
            this.dtHetHan.Name = "dtHetHan";
            this.dtHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHetHan.Size = new System.Drawing.Size(122, 20);
            this.dtHetHan.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Ngày Hết Hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 104;
            this.label4.Text = "Ngày Hợp Đồng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(11, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 102;
            this.label5.Text = "Nhà Cung Cấp:";
            // 
            // lkNCC
            // 
            this.lkNCC.Location = new System.Drawing.Point(65, 16);
            this.lkNCC.Name = "lkNCC";
            this.lkNCC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkNCC.Properties.Appearance.Options.UseFont = true;
            this.lkNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNCC.Properties.NullText = "";
            this.lkNCC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkNCC.Size = new System.Drawing.Size(231, 22);
            this.lkNCC.TabIndex = 104;
            // 
            // lkGT
            // 
            this.lkGT.Location = new System.Drawing.Point(65, 44);
            this.lkGT.Name = "lkGT";
            this.lkGT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkGT.Properties.Appearance.Options.UseFont = true;
            this.lkGT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkGT.Properties.NullText = "";
            this.lkGT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkGT.Size = new System.Drawing.Size(231, 22);
            this.lkGT.TabIndex = 105;
            // 
            // lkDuoc
            // 
            this.lkDuoc.Location = new System.Drawing.Point(65, 72);
            this.lkDuoc.Name = "lkDuoc";
            this.lkDuoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkDuoc.Properties.Appearance.Options.UseFont = true;
            this.lkDuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDuoc.Properties.NullText = "";
            this.lkDuoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkDuoc.Size = new System.Drawing.Size(231, 22);
            this.lkDuoc.TabIndex = 106;
            // 
            // lkNhaCungCap
            // 
            this.lkNhaCungCap.Location = new System.Drawing.Point(114, 16);
            this.lkNhaCungCap.Name = "lkNhaCungCap";
            this.lkNhaCungCap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkNhaCungCap.Properties.Appearance.Options.UseFont = true;
            this.lkNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhaCungCap.Properties.NullText = "";
            this.lkNhaCungCap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkNhaCungCap.Size = new System.Drawing.Size(359, 22);
            this.lkNhaCungCap.TabIndex = 120;
            // 
            // lkGoiThau
            // 
            this.lkGoiThau.Location = new System.Drawing.Point(315, 76);
            this.lkGoiThau.Name = "lkGoiThau";
            this.lkGoiThau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkGoiThau.Properties.Appearance.Options.UseFont = true;
            this.lkGoiThau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkGoiThau.Properties.NullText = "";
            this.lkGoiThau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkGoiThau.Size = new System.Drawing.Size(332, 22);
            this.lkGoiThau.TabIndex = 121;
            // 
            // Duoc_Id
            // 
            this.Duoc_Id.Caption = "Dược";
            this.Duoc_Id.FieldName = "Duoc_Id";
            this.Duoc_Id.Name = "Duoc_Id";
            this.Duoc_Id.Visible = true;
            this.Duoc_Id.VisibleIndex = 0;
            // 
            // DonGiaHopDong
            // 
            this.DonGiaHopDong.Caption = "Giá hợp đồng";
            this.DonGiaHopDong.FieldName = "DonGiaHopDong";
            this.DonGiaHopDong.Name = "DonGiaHopDong";
            this.DonGiaHopDong.Visible = true;
            this.DonGiaHopDong.VisibleIndex = 1;
            // 
            // DonGiaDuTru
            // 
            this.DonGiaDuTru.Caption = "Đơn giá dự trù";
            this.DonGiaDuTru.FieldName = "DonGiaDuTru";
            this.DonGiaDuTru.Name = "DonGiaDuTru";
            this.DonGiaDuTru.Visible = true;
            this.DonGiaDuTru.VisibleIndex = 2;
            // 
            // SoLuongCungCap
            // 
            this.SoLuongCungCap.Caption = "Số lượng";
            this.SoLuongCungCap.FieldName = "SoLuongCungCap";
            this.SoLuongCungCap.Name = "SoLuongCungCap";
            this.SoLuongCungCap.Visible = true;
            this.SoLuongCungCap.VisibleIndex = 3;
            // 
            // SoLuongDaNhap
            // 
            this.SoLuongDaNhap.Caption = "Đã mua";
            this.SoLuongDaNhap.FieldName = "SoLuongDaNhap";
            this.SoLuongDaNhap.Name = "SoLuongDaNhap";
            this.SoLuongDaNhap.Visible = true;
            this.SoLuongDaNhap.VisibleIndex = 4;
            // 
            // MaThongTu
            // 
            this.MaThongTu.Caption = "Mã thông tư";
            this.MaThongTu.FieldName = "MaThongTu";
            this.MaThongTu.Name = "MaThongTu";
            this.MaThongTu.Visible = true;
            this.MaThongTu.VisibleIndex = 5;
            // 
            // SoViSa
            // 
            this.SoViSa.Caption = "Số Visa";
            this.SoViSa.FieldName = "SoViSa";
            this.SoViSa.Name = "SoViSa";
            this.SoViSa.Visible = true;
            this.SoViSa.VisibleIndex = 6;
            // 
            // MaQuyetDinh
            // 
            this.MaQuyetDinh.Caption = "Mã quyết định";
            this.MaQuyetDinh.FieldName = "MaQuyetDinh";
            this.MaQuyetDinh.Name = "MaQuyetDinh";
            this.MaQuyetDinh.Visible = true;
            this.MaQuyetDinh.VisibleIndex = 7;
            // 
            // SoNamHopDong
            // 
            this.SoNamHopDong.Caption = "Số năm hợp đông";
            this.SoNamHopDong.FieldName = "SoNamHopDong";
            this.SoNamHopDong.Name = "SoNamHopDong";
            this.SoNamHopDong.Visible = true;
            this.SoNamHopDong.VisibleIndex = 8;
            // 
            // mnc1DMGiaThauBenhVienUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mnc1DMGiaThauBenhVienUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCungCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHopDong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHopDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkGT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkGoiThau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvGoiThau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnBoLoc;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdNhaThuoc;
        private System.Windows.Forms.RadioButton rdBenhVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit dtNgayCungCap;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtHopDong;
        private DevExpress.XtraEditors.DateEdit dtHetHan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lkDuoc;
        private DevExpress.XtraEditors.LookUpEdit lkGT;
        private DevExpress.XtraEditors.LookUpEdit lkNCC;
        private DevExpress.XtraEditors.LookUpEdit lkGoiThau;
        private DevExpress.XtraEditors.LookUpEdit lkNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn Duoc_Id;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaDuTru;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongDaNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaThongTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoViSa;
        private DevExpress.XtraGrid.Columns.GridColumn MaQuyetDinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoNamHopDong;
    }
}

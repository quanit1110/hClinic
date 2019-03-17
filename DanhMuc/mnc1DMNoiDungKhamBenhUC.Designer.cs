namespace DanhMuc
{
    partial class mnc1DMNoiDungKhamBenhUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnc1DMNoiDungKhamBenhUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Chon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DichVu_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InputCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhomDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tvNhomBenh = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(333, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 624);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(678, 603);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Chon,
            this.DichVu_Id,
            this.InputCode,
            this.TenDichVu,
            this.TenNhomDichVu,
            this.TenLoaiDichVu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Chon
            // 
            this.Chon.Caption = "Chon";
            this.Chon.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Chon.FieldName = "Chon";
            this.Chon.Name = "Chon";
            this.Chon.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Chon.Visible = true;
            this.Chon.VisibleIndex = 0;
            this.Chon.Width = 117;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // DichVu_Id
            // 
            this.DichVu_Id.Caption = "Dịch vụ ID";
            this.DichVu_Id.FieldName = "DichVu_Id";
            this.DichVu_Id.Name = "DichVu_Id";
            this.DichVu_Id.Visible = true;
            this.DichVu_Id.VisibleIndex = 1;
            this.DichVu_Id.Width = 100;
            // 
            // InputCode
            // 
            this.InputCode.Caption = "InputCode";
            this.InputCode.FieldName = "InputCode";
            this.InputCode.Name = "InputCode";
            this.InputCode.Visible = true;
            this.InputCode.VisibleIndex = 2;
            this.InputCode.Width = 100;
            // 
            // TenDichVu
            // 
            this.TenDichVu.Caption = "Tên dịch vụ";
            this.TenDichVu.FieldName = "TenDichVu";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.Visible = true;
            this.TenDichVu.VisibleIndex = 3;
            this.TenDichVu.Width = 151;
            // 
            // TenNhomDichVu
            // 
            this.TenNhomDichVu.Caption = "Tên nhóm dịch vụ";
            this.TenNhomDichVu.FieldName = "TenNhomDichVu";
            this.TenNhomDichVu.Name = "TenNhomDichVu";
            this.TenNhomDichVu.Visible = true;
            this.TenNhomDichVu.VisibleIndex = 4;
            this.TenNhomDichVu.Width = 99;
            // 
            // TenLoaiDichVu
            // 
            this.TenLoaiDichVu.Caption = "Tên loại dịch vụ";
            this.TenLoaiDichVu.FieldName = "TenLoaiDichVu";
            this.TenLoaiDichVu.Name = "TenLoaiDichVu";
            this.TenLoaiDichVu.Visible = true;
            this.TenLoaiDichVu.VisibleIndex = 5;
            this.TenLoaiDichVu.Width = 93;
            // 
            // tvNhomBenh
            // 
            this.tvNhomBenh.Location = new System.Drawing.Point(3, 3);
            this.tvNhomBenh.Name = "tvNhomBenh";
            this.tvNhomBenh.Size = new System.Drawing.Size(324, 624);
            this.tvNhomBenh.TabIndex = 2;
            this.tvNhomBenh.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvNhomBenh_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-go-next-icon.png");
            this.imageList1.Images.SetKeyName(2, "Home-icon.png");
            // 
            // mnc1DMNoiDungKhamBenhUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvNhomBenh);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mnc1DMNoiDungKhamBenhUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvNhomBenh;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DichVu_Id;
        private DevExpress.XtraGrid.Columns.GridColumn InputCode;
        private DevExpress.XtraGrid.Columns.GridColumn TenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhomDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}

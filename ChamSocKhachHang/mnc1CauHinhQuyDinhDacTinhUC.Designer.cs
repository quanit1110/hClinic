namespace ChamSocKhachHang
{
    partial class mnc1CauHinhQuyDinhDacTinhUC
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
            this.tvDacTinh = new System.Windows.Forms.TreeView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.Giam = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTyLe = new DevExpress.XtraEditors.TextEdit();
            this.cbTatCaDichVu = new System.Windows.Forms.CheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.Giam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTyLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDacTinh
            // 
            this.tvDacTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvDacTinh.Location = new System.Drawing.Point(3, 3);
            this.tvDacTinh.Name = "tvDacTinh";
            this.tvDacTinh.Size = new System.Drawing.Size(283, 624);
            this.tvDacTinh.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(292, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.Giam;
            this.xtraTabControl1.Size = new System.Drawing.Size(725, 627);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Giam,
            this.xtraTabPage2,
            this.xtraTabPage1,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // Giam
            // 
            this.Giam.Appearance.Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giam.Appearance.Header.Options.UseFont = true;
            this.Giam.Controls.Add(this.gridControl1);
            this.Giam.Controls.Add(this.cbTatCaDichVu);
            this.Giam.Controls.Add(this.txtTyLe);
            this.Giam.Controls.Add(this.label1);
            this.Giam.Name = "Giam";
            this.Giam.Size = new System.Drawing.Size(719, 597);
            this.Giam.Text = "Giảm giá";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(719, 597);
            this.xtraTabPage1.Text = "Khuyến mãi KSK tổng quát";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(719, 597);
            this.xtraTabPage3.Text = "Miễn phí lần khám";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Appearance.Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage4.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(719, 597);
            this.xtraTabPage4.Text = "Thời hạn sử dụng thẻ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(719, 597);
            this.xtraTabPage2.Text = "Giảm giá chương trình trọn gói";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tỷ lệ (%)";
            // 
            // txtTyLe
            // 
            this.txtTyLe.Location = new System.Drawing.Point(65, 9);
            this.txtTyLe.Name = "txtTyLe";
            this.txtTyLe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyLe.Properties.Appearance.Options.UseFont = true;
            this.txtTyLe.Size = new System.Drawing.Size(144, 22);
            this.txtTyLe.TabIndex = 1;
            // 
            // cbTatCaDichVu
            // 
            this.cbTatCaDichVu.AutoSize = true;
            this.cbTatCaDichVu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTatCaDichVu.Location = new System.Drawing.Point(65, 37);
            this.cbTatCaDichVu.Name = "cbTatCaDichVu";
            this.cbTatCaDichVu.Size = new System.Drawing.Size(102, 19);
            this.cbTatCaDichVu.TabIndex = 2;
            this.cbTatCaDichVu.Text = "Tất cả dịch vụ";
            this.cbTatCaDichVu.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(710, 532);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // mnc1CauHinhQuyDinhDacTinhUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.tvDacTinh);
            this.Name = "mnc1CauHinhQuyDinhDacTinhUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.Giam.ResumeLayout(false);
            this.Giam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTyLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDacTinh;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage Giam;
        private DevExpress.XtraEditors.TextEdit txtTyLe;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.CheckBox cbTatCaDichVu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

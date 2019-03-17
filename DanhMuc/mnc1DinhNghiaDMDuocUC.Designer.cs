namespace DanhMuc
{
    partial class mnc1DinhNghiaDMDuocUC
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
            this.Khoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lkKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.lkNoiSuDung = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenNoiSuDungMoi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNoiSuDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNoiSuDungMoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 587);
            this.gridControl1.TabIndex = 0;
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
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(3, 16);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(36, 15);
            this.Khoa.TabIndex = 1;
            this.Khoa.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nơi sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nơi sử dụng mới";
            // 
            // lkKhoa
            // 
            this.lkKhoa.Location = new System.Drawing.Point(45, 11);
            this.lkKhoa.Name = "lkKhoa";
            this.lkKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkKhoa.Properties.Appearance.Options.UseFont = true;
            this.lkKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoa.Properties.NullText = "";
            this.lkKhoa.Size = new System.Drawing.Size(234, 22);
            this.lkKhoa.TabIndex = 4;
            // 
            // lkNoiSuDung
            // 
            this.lkNoiSuDung.Location = new System.Drawing.Point(364, 9);
            this.lkNoiSuDung.Name = "lkNoiSuDung";
            this.lkNoiSuDung.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkNoiSuDung.Properties.Appearance.Options.UseFont = true;
            this.lkNoiSuDung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNoiSuDung.Properties.NullText = "";
            this.lkNoiSuDung.Size = new System.Drawing.Size(234, 22);
            this.lkNoiSuDung.TabIndex = 5;
            // 
            // txtTenNoiSuDungMoi
            // 
            this.txtTenNoiSuDungMoi.Location = new System.Drawing.Point(727, 10);
            this.txtTenNoiSuDungMoi.Name = "txtTenNoiSuDungMoi";
            this.txtTenNoiSuDungMoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNoiSuDungMoi.Properties.Appearance.Options.UseFont = true;
            this.txtTenNoiSuDungMoi.Size = new System.Drawing.Size(248, 22);
            this.txtTenNoiSuDungMoi.TabIndex = 6;
            // 
            // mnc1DinhNghiaDMDuocUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTenNoiSuDungMoi);
            this.Controls.Add(this.lkNoiSuDung);
            this.Controls.Add(this.lkKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Khoa);
            this.Controls.Add(this.gridControl1);
            this.Name = "mnc1DinhNghiaDMDuocUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNoiSuDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNoiSuDungMoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lkKhoa;
        private DevExpress.XtraEditors.LookUpEdit lkNoiSuDung;
        private DevExpress.XtraEditors.TextEdit txtTenNoiSuDungMoi;
    }
}

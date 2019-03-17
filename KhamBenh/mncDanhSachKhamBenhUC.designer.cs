namespace KhamBenh
{
    partial class mncDanhSachKhamBenhUC
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
            this.btbBoLoc = new DevExpress.XtraEditors.SimpleButton();
            this.lkPhongBan = new DevExpress.XtraEditors.LookUpEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btbMaYte = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaYTe = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayKham = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaYTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btbBoLoc
            // 
            this.btbBoLoc.Location = new System.Drawing.Point(914, 8);
            this.btbBoLoc.Name = "btbBoLoc";
            this.btbBoLoc.Size = new System.Drawing.Size(72, 27);
            this.btbBoLoc.TabIndex = 41;
            this.btbBoLoc.Text = "Bỏ lọc";
            this.btbBoLoc.Click += new System.EventHandler(this.btbBoLoc_Click);
            // 
            // lkPhongBan
            // 
            this.lkPhongBan.Location = new System.Drawing.Point(105, 11);
            this.lkPhongBan.Name = "lkPhongBan";
            this.lkPhongBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkPhongBan.Properties.Appearance.Options.UseFont = true;
            this.lkPhongBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhongBan.Properties.NullText = "";
            this.lkPhongBan.Size = new System.Drawing.Size(190, 24);
            this.lkPhongBan.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Phòng khám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Bệnh nhân";
            // 
            // btbMaYte
            // 
            this.btbMaYte.Location = new System.Drawing.Point(549, 15);
            this.btbMaYte.Name = "btbMaYte";
            this.btbMaYte.Size = new System.Drawing.Size(15, 20);
            this.btbMaYte.TabIndex = 600;
            this.btbMaYte.Text = "...";
            this.btbMaYte.Click += new System.EventHandler(this.btbMaYte_Click);
            // 
            // txtMaYTe
            // 
            this.txtMaYTe.Location = new System.Drawing.Point(397, 15);
            this.txtMaYTe.Name = "txtMaYTe";
            this.txtMaYTe.Size = new System.Drawing.Size(146, 20);
            this.txtMaYTe.TabIndex = 599;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 601;
            this.label2.Text = "Ngày";
            // 
            // dtNgayKham
            // 
            this.dtNgayKham.EditValue = null;
            this.dtNgayKham.Location = new System.Drawing.Point(627, 13);
            this.dtNgayKham.Name = "dtNgayKham";
            this.dtNgayKham.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKham.Properties.Appearance.Options.UseFont = true;
            this.dtNgayKham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKham.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKham.Size = new System.Drawing.Size(151, 22);
            this.dtNgayKham.TabIndex = 602;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1011, 569);
            this.gridControl1.TabIndex = 603;
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
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(806, 8);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(72, 27);
            this.btnLoc.TabIndex = 604;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // mncDanhSachKhamBenhUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dtNgayKham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbMaYte);
            this.Controls.Add(this.txtMaYTe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbBoLoc);
            this.Controls.Add(this.lkPhongBan);
            this.Controls.Add(this.label9);
            this.Name = "mncDanhSachKhamBenhUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.Load += new System.EventHandler(this.mncDanhSachKhamBenhUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkPhongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaYTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btbBoLoc;
        private DevExpress.XtraEditors.LookUpEdit lkPhongBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btbMaYte;
        private DevExpress.XtraEditors.TextEdit txtMaYTe;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtNgayKham;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
    }
}

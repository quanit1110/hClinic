namespace DanhMuc
{
    partial class mnc1DMDuocCanhBaoUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkPhamVi = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLoaiVatTu = new DevExpress.XtraEditors.LookUpEdit();
            this.btLoc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhamVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVatTu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Loại Vật Tư:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(22, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Phạm Vi:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1014, 569);
            this.gridControl1.TabIndex = 64;
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
            // lkPhamVi
            // 
            this.lkPhamVi.Location = new System.Drawing.Point(80, 6);
            this.lkPhamVi.Name = "lkPhamVi";
            this.lkPhamVi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkPhamVi.Properties.Appearance.Options.UseFont = true;
            this.lkPhamVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhamVi.Properties.NullText = "";
            this.lkPhamVi.Size = new System.Drawing.Size(322, 22);
            this.lkPhamVi.TabIndex = 65;
            // 
            // lkLoaiVatTu
            // 
            this.lkLoaiVatTu.Location = new System.Drawing.Point(80, 33);
            this.lkLoaiVatTu.Name = "lkLoaiVatTu";
            this.lkLoaiVatTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLoaiVatTu.Properties.Appearance.Options.UseFont = true;
            this.lkLoaiVatTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiVatTu.Properties.NullText = "";
            this.lkLoaiVatTu.Size = new System.Drawing.Size(322, 22);
            this.lkLoaiVatTu.TabIndex = 66;
            // 
            // btLoc
            // 
            this.btLoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoc.Appearance.Options.UseFont = true;
            this.btLoc.Location = new System.Drawing.Point(421, 7);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(75, 23);
            this.btLoc.TabIndex = 67;
            this.btLoc.Text = "Lọc";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(421, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 68;
            this.simpleButton1.Text = "Bỏ lọc";
            // 
            // mnc1DMDuocCanhBaoUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.lkLoaiVatTu);
            this.Controls.Add(this.lkPhamVi);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "mnc1DMDuocCanhBaoUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhamVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiVatTu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lkPhamVi;
        private DevExpress.XtraEditors.LookUpEdit lkLoaiVatTu;
        private DevExpress.XtraEditors.SimpleButton btLoc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

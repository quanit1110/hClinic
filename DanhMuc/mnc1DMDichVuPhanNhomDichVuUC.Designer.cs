namespace DanhMuc
{
    partial class mnc1DMDichVuPhanNhomDichVuUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnc1DMDichVuPhanNhomDichVuUC));
            this.tvDichVu = new System.Windows.Forms.TreeView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lkPhanNhomDichVu = new DevExpress.XtraEditors.LookUpEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhanNhomDichVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDichVu
            // 
            this.tvDichVu.CheckBoxes = true;
            this.tvDichVu.Location = new System.Drawing.Point(3, 36);
            this.tvDichVu.Name = "tvDichVu";
            this.tvDichVu.Size = new System.Drawing.Size(324, 591);
            this.tvDichVu.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(329, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(688, 591);
            this.gridControl1.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Phân Nhóm Dịch Vụ:";
            // 
            // lkPhanNhomDichVu
            // 
            this.lkPhanNhomDichVu.Location = new System.Drawing.Point(123, 8);
            this.lkPhanNhomDichVu.Name = "lkPhanNhomDichVu";
            this.lkPhanNhomDichVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkPhanNhomDichVu.Properties.Appearance.Options.UseFont = true;
            this.lkPhanNhomDichVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPhanNhomDichVu.Properties.NullText = "";
            this.lkPhanNhomDichVu.Size = new System.Drawing.Size(268, 22);
            this.lkPhanNhomDichVu.TabIndex = 44;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Home-icon.png");
            this.imageList1.Images.SetKeyName(2, "Steak-icon.png");
            this.imageList1.Images.SetKeyName(3, "strawberry-icon.png");
            // 
            // mnc1DMDichVuPhanNhomDichVuUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lkPhanNhomDichVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tvDichVu);
            this.Name = "mnc1DMDichVuPhanNhomDichVuUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPhanNhomDichVu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDichVu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lkPhanNhomDichVu;
        private System.Windows.Forms.ImageList imageList1;
    }
}

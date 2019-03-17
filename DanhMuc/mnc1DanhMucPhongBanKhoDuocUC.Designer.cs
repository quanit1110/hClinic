namespace DanhMuc
{
    partial class mnc1DanhMucPhongBanKhoDuocUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnc1DanhMucPhongBanKhoDuocUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvPhongBan = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.tvKhoDuoc = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvKhoDuoc);
            this.groupBox1.Location = new System.Drawing.Point(333, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 624);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // tvPhongBan
            // 
            this.tvPhongBan.Location = new System.Drawing.Point(3, 3);
            this.tvPhongBan.Name = "tvPhongBan";
            this.tvPhongBan.Size = new System.Drawing.Size(324, 624);
            this.tvPhongBan.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-go-next-icon.png");
            this.imageList1.Images.SetKeyName(2, "Home-icon.png");
            // 
            // tvKhoDuoc
            // 
            this.tvKhoDuoc.CheckBoxes = true;
            this.tvKhoDuoc.Location = new System.Drawing.Point(6, 17);
            this.tvKhoDuoc.Name = "tvKhoDuoc";
            this.tvKhoDuoc.Size = new System.Drawing.Size(672, 601);
            this.tvKhoDuoc.TabIndex = 5;
            // 
            // mnc1DanhMucPhongBanKhoDuocUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvPhongBan);
            this.Name = "mnc1DanhMucPhongBanKhoDuocUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvPhongBan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvKhoDuoc;
    }
}

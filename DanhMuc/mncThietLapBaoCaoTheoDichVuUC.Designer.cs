namespace DanhMuc
{
    partial class mncThietLapBaoCaoTheoDichVuUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mncThietLapBaoCaoTheoDichVuUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvMauBaoCao = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvChiTiet = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvMauBaoCao);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 721);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tvMauBaoCao
            // 
            this.tvMauBaoCao.Location = new System.Drawing.Point(6, 21);
            this.tvMauBaoCao.Name = "tvMauBaoCao";
            this.tvMauBaoCao.Size = new System.Drawing.Size(354, 603);
            this.tvMauBaoCao.TabIndex = 0;
            this.tvMauBaoCao.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMauBaoCao_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvChiTiet);
            this.groupBox2.Location = new System.Drawing.Point(375, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 721);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // tvChiTiet
            // 
            this.tvChiTiet.CheckBoxes = true;
            this.tvChiTiet.Location = new System.Drawing.Point(6, 21);
            this.tvChiTiet.Name = "tvChiTiet";
            this.tvChiTiet.Size = new System.Drawing.Size(636, 603);
            this.tvChiTiet.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-go-next-icon.png");
            this.imageList1.Images.SetKeyName(2, "Home-icon.png");
            // 
            // mncThietLapBaoCaoTheoDichVuUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mncThietLapBaoCaoTheoDichVuUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvMauBaoCao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvChiTiet;
        private System.Windows.Forms.ImageList imageList1;
    }
}

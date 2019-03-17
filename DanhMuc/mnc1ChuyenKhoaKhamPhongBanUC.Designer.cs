namespace DanhMuc
{
    partial class mnc1ChuyenKhoaKhamPhongBanUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnc1ChuyenKhoaKhamPhongBanUC));
            this.tvPhongKham = new System.Windows.Forms.TreeView();
            this.tvChuyenKHoa = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvPhongKham
            // 
            this.tvPhongKham.CheckBoxes = true;
            this.tvPhongKham.Location = new System.Drawing.Point(362, 3);
            this.tvPhongKham.Name = "tvPhongKham";
            this.tvPhongKham.Size = new System.Drawing.Size(655, 624);
            this.tvPhongKham.TabIndex = 6;
            // 
            // tvChuyenKHoa
            // 
            this.tvChuyenKHoa.Location = new System.Drawing.Point(3, 3);
            this.tvChuyenKHoa.Name = "tvChuyenKHoa";
            this.tvChuyenKHoa.Size = new System.Drawing.Size(353, 624);
            this.tvChuyenKHoa.TabIndex = 5;
            this.tvChuyenKHoa.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvChuyenKHoa_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-go-next-icon.png");
            this.imageList1.Images.SetKeyName(2, "Home-icon.png");
            // 
            // mnc1ChuyenKhoaKhamPhongBanUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvPhongKham);
            this.Controls.Add(this.tvChuyenKHoa);
            this.Name = "mnc1ChuyenKhoaKhamPhongBanUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tvPhongKham;
        private System.Windows.Forms.TreeView tvChuyenKHoa;
        private System.Windows.Forms.ImageList imageList1;
    }
}

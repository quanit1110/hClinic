namespace ChamSocKhachHang
{
    partial class mnc1LoaiKhachHangDacTinhUC
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
            this.tvLoaiKhachHang = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tvLoaiKhachHang
            // 
            this.tvLoaiKhachHang.Location = new System.Drawing.Point(3, 3);
            this.tvLoaiKhachHang.Name = "tvLoaiKhachHang";
            this.tvLoaiKhachHang.Size = new System.Drawing.Size(218, 624);
            this.tvLoaiKhachHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 624);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết";
            // 
            // mnc1LoaiKhachHangDacTinhUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvLoaiKhachHang);
            this.Name = "mnc1LoaiKhachHangDacTinhUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvLoaiKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

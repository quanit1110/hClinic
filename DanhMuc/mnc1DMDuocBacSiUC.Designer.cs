namespace DanhMuc
{
    partial class mnc1DMDuocBacSiUC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvDuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grvBacSi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdDuocBacSi = new System.Windows.Forms.RadioButton();
            this.rdBacSiDuoc = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBacSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBacSiDuoc);
            this.groupBox1.Controls.Add(this.rdDuocBacSi);
            this.groupBox1.Controls.Add(this.grvDuoc);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dược";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grvBacSi);
            this.groupBox2.Location = new System.Drawing.Point(496, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 624);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bác Sĩ";
            // 
            // grvDuoc
            // 
            this.grvDuoc.Location = new System.Drawing.Point(6, 21);
            this.grvDuoc.MainView = this.gridView1;
            this.grvDuoc.Name = "grvDuoc";
            this.grvDuoc.Size = new System.Drawing.Size(477, 528);
            this.grvDuoc.TabIndex = 0;
            this.grvDuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grvDuoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grvBacSi
            // 
            this.grvBacSi.Location = new System.Drawing.Point(6, 21);
            this.grvBacSi.MainView = this.gridView2;
            this.grvBacSi.Name = "grvBacSi";
            this.grvBacSi.Size = new System.Drawing.Size(509, 597);
            this.grvBacSi.TabIndex = 0;
            this.grvBacSi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grvBacSi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // rdDuocBacSi
            // 
            this.rdDuocBacSi.AutoSize = true;
            this.rdDuocBacSi.Location = new System.Drawing.Point(37, 566);
            this.rdDuocBacSi.Name = "rdDuocBacSi";
            this.rdDuocBacSi.Size = new System.Drawing.Size(110, 19);
            this.rdDuocBacSi.TabIndex = 1;
            this.rdDuocBacSi.TabStop = true;
            this.rdDuocBacSi.Text = "Dược =>  Bác Sĩ";
            this.rdDuocBacSi.UseVisualStyleBackColor = true;
            // 
            // rdBacSiDuoc
            // 
            this.rdBacSiDuoc.AutoSize = true;
            this.rdBacSiDuoc.Location = new System.Drawing.Point(37, 591);
            this.rdBacSiDuoc.Name = "rdBacSiDuoc";
            this.rdBacSiDuoc.Size = new System.Drawing.Size(107, 19);
            this.rdBacSiDuoc.TabIndex = 2;
            this.rdBacSiDuoc.TabStop = true;
            this.rdBacSiDuoc.Text = "Bác Sĩ => Dược";
            this.rdBacSiDuoc.UseVisualStyleBackColor = true;
            // 
            // mnc1DMDuocBacSiUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mnc1DMDuocBacSiUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBacSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBacSiDuoc;
        private System.Windows.Forms.RadioButton rdDuocBacSi;
        private DevExpress.XtraGrid.GridControl grvDuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl grvBacSi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}

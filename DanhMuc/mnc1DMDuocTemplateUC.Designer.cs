namespace DanhMuc
{
    partial class mnc1DMDuocTemplateUC
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbTemplate = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTentemplate = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdx = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaTemplate = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.lkKhoDuoc = new DevExpress.XtraEditors.LookUpEdit();
            this.lkLoaiTemplate = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTentemplate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTemplate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoDuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiTemplate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, -3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(290, 624);
            this.treeView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkLoaiTemplate);
            this.groupBox1.Controls.Add(this.lkKhoDuoc);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.cbTemplate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTentemplate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIdx);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaTemplate);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(296, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 624);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 154);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(709, 464);
            this.gridControl1.TabIndex = 94;
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
            // cbTemplate
            // 
            this.cbTemplate.AutoSize = true;
            this.cbTemplate.Location = new System.Drawing.Point(370, 124);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(15, 14);
            this.cbTemplate.TabIndex = 93;
            this.cbTemplate.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(285, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 92;
            this.label15.Text = "Template:";
            // 
            // txtTentemplate
            // 
            this.txtTentemplate.Location = new System.Drawing.Point(121, 66);
            this.txtTentemplate.Name = "txtTentemplate";
            this.txtTentemplate.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTentemplate.Properties.Appearance.Options.UseFont = true;
            this.txtTentemplate.Size = new System.Drawing.Size(459, 22);
            this.txtTentemplate.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(9, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 82;
            this.label10.Text = "Kho Dược:";
            // 
            // txtIdx
            // 
            this.txtIdx.Location = new System.Drawing.Point(121, 120);
            this.txtIdx.Name = "txtIdx";
            this.txtIdx.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdx.Properties.Appearance.Options.UseFont = true;
            this.txtIdx.Size = new System.Drawing.Size(110, 22);
            this.txtIdx.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 83;
            this.label9.Text = "Mã Template:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(9, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 84;
            this.label8.Text = "Tên Template:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(9, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Loại Template:";
            // 
            // txtMaTemplate
            // 
            this.txtMaTemplate.Location = new System.Drawing.Point(121, 41);
            this.txtMaTemplate.Name = "txtMaTemplate";
            this.txtMaTemplate.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTemplate.Properties.Appearance.Options.UseFont = true;
            this.txtMaTemplate.Size = new System.Drawing.Size(459, 22);
            this.txtMaTemplate.TabIndex = 87;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(9, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 15);
            this.label18.TabIndex = 86;
            this.label18.Text = "Idx:";
            // 
            // lkKhoDuoc
            // 
            this.lkKhoDuoc.Location = new System.Drawing.Point(121, 15);
            this.lkKhoDuoc.Name = "lkKhoDuoc";
            this.lkKhoDuoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkKhoDuoc.Properties.Appearance.Options.UseFont = true;
            this.lkKhoDuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhoDuoc.Properties.NullText = "";
            this.lkKhoDuoc.Size = new System.Drawing.Size(459, 22);
            this.lkKhoDuoc.TabIndex = 95;
            // 
            // lkLoaiTemplate
            // 
            this.lkLoaiTemplate.Location = new System.Drawing.Point(121, 91);
            this.lkLoaiTemplate.Name = "lkLoaiTemplate";
            this.lkLoaiTemplate.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLoaiTemplate.Properties.Appearance.Options.UseFont = true;
            this.lkLoaiTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiTemplate.Properties.NullText = "";
            this.lkLoaiTemplate.Size = new System.Drawing.Size(459, 22);
            this.lkLoaiTemplate.TabIndex = 96;
            // 
            // mnc1DMDuocTemplateUC
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "mnc1DMDuocTemplateUC";
            this.Size = new System.Drawing.Size(1020, 630);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTentemplate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTemplate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhoDuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiTemplate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTentemplate;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtIdx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtMaTemplate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbTemplate;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lkLoaiTemplate;
        private DevExpress.XtraEditors.LookUpEdit lkKhoDuoc;
    }
}

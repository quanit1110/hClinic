namespace DanhMuc
{
    partial class mncHeThongDanhMucUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mncHeThongDanhMucUC));
            this.tviewDinhNghiaDanhMuc = new System.Windows.Forms.TreeView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNode = new System.Windows.Forms.Label();
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tviewDinhNghiaDanhMuc
            // 
            this.tviewDinhNghiaDanhMuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tviewDinhNghiaDanhMuc.Location = new System.Drawing.Point(3, 3);
            this.tviewDinhNghiaDanhMuc.Name = "tviewDinhNghiaDanhMuc";
            this.tviewDinhNghiaDanhMuc.Size = new System.Drawing.Size(234, 624);
            this.tviewDinhNghiaDanhMuc.TabIndex = 1;
            this.tviewDinhNghiaDanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tviewDinhNghiaDanhMuc_NodeMouseClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl1.Location = new System.Drawing.Point(243, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(763, 50);
            this.labelControl1.TabIndex = 2;
            // 
            // txtTenNode
            // 
            this.txtTenNode.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNode.Location = new System.Drawing.Point(251, 11);
            this.txtTenNode.Name = "txtTenNode";
            this.txtTenNode.Size = new System.Drawing.Size(749, 36);
            this.txtTenNode.TabIndex = 3;
            this.txtTenNode.Text = "Trạng Thái";
            this.txtTenNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(243, 59);
            this.grControl.MainView = this.gridView1;
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(763, 568);
            this.grControl.TabIndex = 4;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-go-next-icon.png");
            this.imageList1.Images.SetKeyName(2, "Home-icon.png");
            // 
            // mncHeThongDanhMucUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grControl);
            this.Controls.Add(this.txtTenNode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tviewDinhNghiaDanhMuc);
            this.Name = "mncHeThongDanhMucUC";
            this.Size = new System.Drawing.Size(1020, 630);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tviewDinhNghiaDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label txtTenNode;
        private DevExpress.XtraGrid.GridControl grControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

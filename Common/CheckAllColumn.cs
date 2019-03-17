using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Common
{
    #region CheckAllColumnCheckingEventArgs

    public class CheckAllColumnCheckingEventArgs : EventArgs
    {
        private bool checking;
        private bool allow = true;
        private GridColumn gridColumn;
        private int rowHandle;

        public bool Checking
        {
            get { return checking; }
        }

        public bool Allow
        {
            get { return allow; }
            set { allow = value; }
        }

        public GridColumn GridColumn
        {
            get { return gridColumn; }
        }

        public int RowHandle
        {
            get { return rowHandle; }
        }

        public CheckAllColumnCheckingEventArgs(bool checking, GridColumn gridColumn, int rowHandle)
        {
            this.checking = checking;
            this.gridColumn = gridColumn;
            this.rowHandle = rowHandle;
        }
    }

    #endregion

    public delegate void ColumnChecking(object sender, CheckAllColumnCheckingEventArgs e);

    public class CheckAllColumn
    {
        private GridColumn booleanColumn;
        private GridView gridView;
        private RepositoryItemCheckEdit edit;
        private bool checkAllState = false;
        public event ColumnChecking ColumnCheckingEvent;
        int count = 0;

        public CheckAllColumn(GridView gridView, GridColumn booleanColumn, HorzAlignment horzAlignment)
        {
            SetupColumn(gridView, booleanColumn, horzAlignment);
        }
        
        public CheckAllColumn(GridView gridView, GridColumn booleanColumn)
        {
            SetupColumn(gridView, booleanColumn, DevExpress.Utils.HorzAlignment.Default);
        }

        private void SetupColumn(GridView gridView, GridColumn booleanColumn, DevExpress.Utils.HorzAlignment horzAlignment)
        {
            this.booleanColumn = booleanColumn;
            this.gridView = gridView;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                if (Convert.ToBoolean(gridView.GetRowCellValue(i, booleanColumn)) == true)
                {
                    count = count + 1;
                }
            }
            if (count == gridView.RowCount) { checkAllState = true; }
            //Create a repository item check edit to use in the column header
            edit = new RepositoryItemCheckEdit();
            //Set the caption to the same as the column header
            edit.Caption = " " + booleanColumn.GetCaption();
            edit.GlyphAlignment = horzAlignment;

            //Turn off sorting and the column caption
            booleanColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            booleanColumn.OptionsColumn.ShowCaption = false;

            //Wire up the grid view events
            gridView.Click += new EventHandler(gridView_Click);
            gridView.CustomDrawColumnHeader += new ColumnHeaderCustomDrawEventHandler(gridView_CustomDrawColumnHeader);
        }

        protected void DrawCheckBox(Graphics g, AppearanceObject a, Rectangle r, bool Checked)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = edit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = edit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;
            info.Bounds = r;
            info.Appearance = a;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }

        void gridView_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            //If drawing the boolean column header, draw the checkbox
            if (e.Column == booleanColumn)
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e.Graphics, e.Appearance, e.Bounds, checkAllState);
                e.Handled = true;
            }
        }

        void gridView_Click(object sender, EventArgs e)
        {
            //If the boolean column header is clicked, check all or check none as appropriate
            GridHitInfo info;
            Point pt = gridView.GridControl.PointToClient(Control.MousePosition);
            info = gridView.CalcHitInfo(pt);
            if (info.InColumn && info.Column == booleanColumn)
            {
                if (checkAllState)
                {
                    CheckNone();
                    checkAllState = false;
                }
                else
                {
                    CheckAll();
                    checkAllState = true;
                }
            }
        }

        private void CheckNone()
        {
            Cursor cursor = gridView.GridControl.Cursor;
            gridView.GridControl.Cursor = Cursors.WaitCursor;

            try
            {
                gridView.BeginDataUpdate();
                //Uncheck all rows
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    CheckAllColumnCheckingEventArgs e = new CheckAllColumnCheckingEventArgs(false, booleanColumn, i);
                    if (ColumnCheckingEvent != null)
                    {
                        ColumnCheckingEvent(this, e);
                    }
                    if (e.Allow)
                    {
                        gridView.SetRowCellValue(i, booleanColumn, false);
                    }
                }
                gridView.EndDataUpdate();
            }
            finally
            {
                gridView.GridControl.Cursor = cursor;
            }
        }

        private void CheckAll()
        {
            Cursor cursor = gridView.GridControl.Cursor;
            gridView.GridControl.Cursor = Cursors.WaitCursor;

            try
            {
                gridView.BeginDataUpdate();
                //Check all rows
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    CheckAllColumnCheckingEventArgs e = new CheckAllColumnCheckingEventArgs(false, booleanColumn, i);
                    if (ColumnCheckingEvent != null)
                    {
                        ColumnCheckingEvent(this, e);
                    }
                    if (e.Allow)
                    {
                        gridView.SetRowCellValue(i, booleanColumn, true);
                    }
                }
                gridView.EndDataUpdate();
            }
            finally
            {
                gridView.GridControl.Cursor = cursor;
            }
        }
    }
}

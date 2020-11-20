namespace LKU8.shoukuan
{
    partial class Frmkc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCAS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cinvcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cinvaddcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cinvname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cinvstd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ccomunitname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAS";
            // 
            // txtCAS
            // 
            this.txtCAS.Location = new System.Drawing.Point(100, 30);
            this.txtCAS.Name = "txtCAS";
            this.txtCAS.Size = new System.Drawing.Size(248, 28);
            this.txtCAS.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCAS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 80);
            this.panel1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(864, 339);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cinvcode,
            this.cinvaddcode,
            this.cinvname,
            this.cinvstd,
            this.ccomunitname,
            this.cbatch,
            this.iquantity,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cinvcode
            // 
            this.cinvcode.Caption = "存货编码";
            this.cinvcode.FieldName = "InvCode";
            this.cinvcode.Name = "cinvcode";
            this.cinvcode.Visible = true;
            this.cinvcode.VisibleIndex = 1;
            // 
            // cinvaddcode
            // 
            this.cinvaddcode.Caption = "CAS";
            this.cinvaddcode.FieldName = "invaddcode";
            this.cinvaddcode.Name = "cinvaddcode";
            this.cinvaddcode.Visible = true;
            this.cinvaddcode.VisibleIndex = 2;
            // 
            // cinvname
            // 
            this.cinvname.Caption = "存货名称";
            this.cinvname.FieldName = "Invanme";
            this.cinvname.Name = "cinvname";
            this.cinvname.Visible = true;
            this.cinvname.VisibleIndex = 3;
            // 
            // cinvstd
            // 
            this.cinvstd.Caption = "规格";
            this.cinvstd.FieldName = "InvStd";
            this.cinvstd.Name = "cinvstd";
            this.cinvstd.Visible = true;
            this.cinvstd.VisibleIndex = 4;
            // 
            // ccomunitname
            // 
            this.ccomunitname.Caption = "单位";
            this.ccomunitname.FieldName = "ComUnitName";
            this.ccomunitname.Name = "ccomunitname";
            this.ccomunitname.Visible = true;
            this.ccomunitname.VisibleIndex = 5;
            // 
            // cbatch
            // 
            this.cbatch.Caption = "批号";
            this.cbatch.FieldName = "cBatch";
            this.cbatch.Name = "cbatch";
            this.cbatch.Visible = true;
            this.cbatch.VisibleIndex = 6;
            // 
            // iquantity
            // 
            this.iquantity.Caption = "数量";
            this.iquantity.FieldName = "iQuantity";
            this.iquantity.Name = "iquantity";
            this.iquantity.Visible = true;
            this.iquantity.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库";
            this.gridColumn1.FieldName = "cwhname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Frmkc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 419);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmkc";
            this.Text = "查询库存";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCAS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cinvcode;
        private DevExpress.XtraGrid.Columns.GridColumn cinvaddcode;
        private DevExpress.XtraGrid.Columns.GridColumn cinvname;
        private DevExpress.XtraGrid.Columns.GridColumn cinvstd;
        private DevExpress.XtraGrid.Columns.GridColumn ccomunitname;
        private DevExpress.XtraGrid.Columns.GridColumn cbatch;
        private DevExpress.XtraGrid.Columns.GridColumn iquantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
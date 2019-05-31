namespace QuanLyKhoHang
{
    partial class ReportPhieuXuat
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonMuaHang = new QuanLyKhoHang.HoaDonMuaHang();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOADONBANHANGTableAdapter = new QuanLyKhoHang.HoaDonMuaHangTableAdapters.HOADONBANHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBANHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // HOADONBANHANGBindingSource
            // 
            this.HOADONBANHANGBindingSource.DataMember = "HOADONBANHANG";
            this.HOADONBANHANGBindingSource.DataSource = this.HoaDonMuaHang;
            // 
            // HoaDonMuaHang
            // 
            this.HoaDonMuaHang.DataSetName = "HoaDonMuaHang";
            this.HoaDonMuaHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "HoaDonBanHang";
            reportDataSource2.Value = this.HOADONBANHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhoHang.HoaDonBanHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // HOADONBANHANGTableAdapter
            // 
            this.HOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPhieuXuat";
            this.Text = "ReportPhieuXuat";
            this.Load += new System.EventHandler(this.ReportPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBANHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonMuaHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBANHANGBindingSource;
        private HoaDonMuaHang HoaDonMuaHang;
        private HoaDonMuaHangTableAdapters.HOADONBANHANGTableAdapter HOADONBANHANGTableAdapter;
    }
}
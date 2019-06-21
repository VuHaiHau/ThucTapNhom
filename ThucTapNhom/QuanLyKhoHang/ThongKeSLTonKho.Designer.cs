namespace QuanLyKhoHang
{
    partial class ThongKeSLTonKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TK_SoLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyKhoHangDataSet2 = new QuanLyKhoHang.QuanLyKhoHangDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TK_SoLuongTableAdapter = new QuanLyKhoHang.QuanLyKhoHangDataSet2TableAdapters.TK_SoLuongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TK_SoLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhoHangDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TK_SoLuongBindingSource
            // 
            this.TK_SoLuongBindingSource.DataMember = "TK_SoLuong";
            this.TK_SoLuongBindingSource.DataSource = this.QuanLyKhoHangDataSet2;
            // 
            // QuanLyKhoHangDataSet2
            // 
            this.QuanLyKhoHangDataSet2.DataSetName = "QuanLyKhoHangDataSet2";
            this.QuanLyKhoHangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ThongKe_SoLuong";
            reportDataSource1.Value = this.TK_SoLuongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhoHang.ThongKeSLTonKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TK_SoLuongTableAdapter
            // 
            this.TK_SoLuongTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeSLTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKeSLTonKho";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.FrmThongKeSL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_SoLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhoHangDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TK_SoLuongBindingSource;
        private QuanLyKhoHangDataSet2 QuanLyKhoHangDataSet2;
        private QuanLyKhoHangDataSet2TableAdapters.TK_SoLuongTableAdapter TK_SoLuongTableAdapter;
    }
}
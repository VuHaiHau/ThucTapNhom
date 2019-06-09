namespace QuanLyKhoHang
{
    partial class FrmThongTinNhanVien
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyKhoHangDataSet3 = new QuanLyKhoHang.QuanLyKhoHangDataSet3();
            this.ThongTinNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongTinNhanVienTableAdapter = new QuanLyKhoHang.QuanLyKhoHangDataSet3TableAdapters.ThongTinNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhoHangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThongTinNhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhoHang.ThongTinNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyKhoHangDataSet3
            // 
            this.QuanLyKhoHangDataSet3.DataSetName = "QuanLyKhoHangDataSet3";
            this.QuanLyKhoHangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongTinNhanVienBindingSource
            // 
            this.ThongTinNhanVienBindingSource.DataMember = "ThongTinNhanVien";
            this.ThongTinNhanVienBindingSource.DataSource = this.QuanLyKhoHangDataSet3;
            // 
            // ThongTinNhanVienTableAdapter
            // 
            this.ThongTinNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmThongTinNhanVien";
            this.Text = "FrmThongTinNhanVien";
            this.Load += new System.EventHandler(this.FrmThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhoHangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongTinNhanVienBindingSource;
        private QuanLyKhoHangDataSet3 QuanLyKhoHangDataSet3;
        private QuanLyKhoHangDataSet3TableAdapters.ThongTinNhanVienTableAdapter ThongTinNhanVienTableAdapter;
    }
}
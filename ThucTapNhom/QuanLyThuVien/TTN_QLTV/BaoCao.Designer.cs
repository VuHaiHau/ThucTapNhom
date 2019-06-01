namespace TTN_QLTV
{
    partial class BaoCao
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
            this.rpv_baocao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpv_baocao
            // 
            this.rpv_baocao.Location = new System.Drawing.Point(-1, 12);
            this.rpv_baocao.Name = "rpv_baocao";
            this.rpv_baocao.ServerReport.BearerToken = null;
            this.rpv_baocao.Size = new System.Drawing.Size(720, 642);
            this.rpv_baocao.TabIndex = 0;
            this.rpv_baocao.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 655);
            this.Controls.Add(this.rpv_baocao);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_baocao;
    }
}
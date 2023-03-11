
namespace QLSinhvien
{
    partial class FR_DSSinhvien
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
            this.qlsvRv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // qlsvRv
            // 
            this.qlsvRv.Location = new System.Drawing.Point(-1, 0);
            this.qlsvRv.Name = "qlsvRv";
            this.qlsvRv.ServerReport.BearerToken = null;
            this.qlsvRv.Size = new System.Drawing.Size(801, 453);
            this.qlsvRv.TabIndex = 0;
            // 
            // FR_DSSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qlsvRv);
            this.Name = "FR_DSSinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.FR_DSSinhvien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer qlsvRv;
    }
}
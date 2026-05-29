namespace CapaPresentacion
{
    partial class FormReporteMedicos
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
            this.rvMedicos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvMedicos
            // 
            this.rvMedicos.AutoSize = true;
            this.rvMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvMedicos.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.ReportMedicos.rdlc";
            this.rvMedicos.Location = new System.Drawing.Point(0, 0);
            this.rvMedicos.Name = "rvMedicos";
            this.rvMedicos.ServerReport.BearerToken = null;
            this.rvMedicos.Size = new System.Drawing.Size(800, 450);
            this.rvMedicos.TabIndex = 0;
            this.rvMedicos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // FormReporteMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvMedicos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReporteMedicos";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReporteMedicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMedicos;
    }
}
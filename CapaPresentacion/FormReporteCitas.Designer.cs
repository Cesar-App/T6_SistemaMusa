namespace CapaPresentacion
{
    partial class FormReporteCitas
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
            this.rvCitas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvCitas
            // 
            this.rvCitas.AutoSize = true;
            this.rvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvCitas.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.ReportCitas.rdlc";
            this.rvCitas.Location = new System.Drawing.Point(0, 0);
            this.rvCitas.Name = "rvCitas";
            this.rvCitas.ServerReport.BearerToken = null;
            this.rvCitas.Size = new System.Drawing.Size(800, 450);
            this.rvCitas.TabIndex = 0;
            this.rvCitas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // FormReporteCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvCitas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReporteCitas";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReporteCitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCitas;
    }
}
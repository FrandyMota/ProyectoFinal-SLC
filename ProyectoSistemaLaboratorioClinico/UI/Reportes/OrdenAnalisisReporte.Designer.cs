namespace ProyectoSistemaLaboratorioClinico.UI.Reportes
{
    partial class OrdenAnalisisReporte
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
            this.OrdenAnalisisReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListadoOrdenAnalisis1 = new ProyectoSistemaLaboratorioClinico.ListadoOrdenAnalisis();
            this.SuspendLayout();
            // 
            // OrdenAnalisisReportViewer
            // 
            this.OrdenAnalisisReportViewer.ActiveViewIndex = -1;
            this.OrdenAnalisisReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdenAnalisisReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrdenAnalisisReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdenAnalisisReportViewer.Location = new System.Drawing.Point(0, 0);
            this.OrdenAnalisisReportViewer.Name = "OrdenAnalisisReportViewer";
            this.OrdenAnalisisReportViewer.ReportSource = this.ListadoOrdenAnalisis1;
            this.OrdenAnalisisReportViewer.Size = new System.Drawing.Size(800, 450);
            this.OrdenAnalisisReportViewer.TabIndex = 0;
            // 
            // OrdenAnalisisReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdenAnalisisReportViewer);
            this.Name = "OrdenAnalisisReporte";
            this.Text = "OrdenAnalisisReporte";
            this.Load += new System.EventHandler(this.OrdenAnalisisReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer OrdenAnalisisReportViewer;
        private ListadoOrdenAnalisis ListadoOrdenAnalisis1;
    }
}
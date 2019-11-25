namespace ProyectoSistemaLaboratorioClinico.UI.Reportes
{
    partial class PacientesReporte
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
            this.PacientesReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListadoPacientes1 = new ProyectoSistemaLaboratorioClinico.ListadoPacientes();
            this.SuspendLayout();
            // 
            // PacientesReportViewer
            // 
            this.PacientesReportViewer.ActiveViewIndex = -1;
            this.PacientesReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PacientesReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PacientesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PacientesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PacientesReportViewer.Name = "PacientesReportViewer";
            this.PacientesReportViewer.ReportSource = this.ListadoPacientes1;
            this.PacientesReportViewer.Size = new System.Drawing.Size(800, 450);
            this.PacientesReportViewer.TabIndex = 0;
            // 
            // PacientesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PacientesReportViewer);
            this.Name = "PacientesReporte";
            this.Text = "PacientesReporte";
            this.Load += new System.EventHandler(this.PacientesReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PacientesReportViewer;
        private ListadoPacientes ListadoPacientes1;
    }
}